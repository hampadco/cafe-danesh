using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.AdminEntities.Order;
using DataLayer.Context;
using Dto.Payment;
using Kavenegar;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pransa.Controllers;
using pransa.Models;
using ZarinPal.Class;
//using pransa.Models;

[Area("Mobile")]
    public class PayController : BaseController
    {
        public static string msg ;
        private readonly Payment _payment; 
        private readonly Authority _authority; 
        private readonly Transactions _transactions;
        public PayController(ContextHampadco _db,IWebHostEnvironment env):base(_db,env)
        {
            var expose = new Expose();
            _payment = expose.CreatePayment();
            _authority = expose.CreateAuthority();
            _transactions = expose.CreateTransactions();
        }

        public IActionResult Index(int Id)
        {
            
            if (msg == "success")
            {
                ViewBag.factor=db.Tbl_Factors.Where(b=>b.RFactor==Id).ToList();
                ViewBag.sum=HttpContext.Session.GetString("sum");
                ViewBag.count=HttpContext.Session.GetString("count");
                HttpContext.Session.Remove("sum");
                HttpContext.Session.Remove("count");
                HttpContext.Session.Remove("shop");
            }
            if (msg !=null)
            {
                ViewBag.msg = msg ;
                msg = null ;
            }

            return View();
        }

        public async Task<IActionResult> Request()
        {
            var Amount=Convert.ToInt32(HttpContext.Session.GetString("sum"));
            var result = await _payment.Request(new DtoRequest()
            {
                Mobile = User.Identity.GetId(),
                CallbackUrl = menu.site+"mobile/pay/validate",
                Description = "پرداخت سبد خرید ",
                Email = "your@email.com",
                Amount = Amount,
                MerchantId = menu.zarincode,
            }, ZarinPal.Class.Payment.Mode.sandbox);
            return Redirect($"https://sandbox.zarinpal.com/pg/StartPay/{result.Authority}");
        }

        public async Task<IActionResult> Validate(string authority, string status)
        {
            var Amount=Convert.ToInt32(HttpContext.Session.GetString("sum"));
            var verification = await _payment.Verification(new DtoVerification
            {
                Amount = Amount,
                MerchantId =menu.zarincode,
                Authority = authority,
            }, Payment.Mode.sandbox);
           
            if (verification.Status == 100)
            {
                var kala=ShowList();
                int Rn;
                var R=new Random();
                Rn=R.Next(100000, 999999);
                 foreach (var item in kala)
                {
                    var price=Convert.ToInt32(item.Price_Pro);
                    var count=Convert.ToInt32(item.count);
                    var sum=price*count;
                    Tb_Factor to = new Tb_Factor()
                    {
                        
                        Id_Order=User.Identity.GetId(),
                        Product_Id=item.Id,
                        product_Name=item.TitleProductPro,
                        Product_Count=count,
                        product_Price=price,
                        Total_sum=sum,
                        RFactor =Rn,


                    }; 
                    db.Tbl_Factors.Add(to);
                    db.SaveChanges();
                }
                var user=db.Tbl_User.Where(a=>a.PhoneUs==User.Identity.GetId()).FirstOrDefault();
                Tb_Order order=new Tb_Order()
                {
                   Id_user=User.Identity.GetId(),
                   Date_Order=DateTime.UtcNow,
                   Pay =HttpContext.Session.GetString("sum"),
                   Address=user.AddressUs,
                   Post=user.Post,
                   State ="OK",
                   RFactor=Rn, 

                }; 
                db.Tbl_Order.Add(order);
                db.SaveChanges();
                var ss=menu.site+"/admin/order/index";
                var phone=menu.phone;
                var api = new KavenegarApi("3871353043697339486A70384F544A4A574C74612B51432F4C7A4B305076645457396F5267456F7A5A34383D");
                api.VerifyLookup(phone, ss, "deliverylink");
                msg = "success";
                return RedirectToAction("Index", new{Id=Rn}); 
            }
            else
            {
                msg = "error"; 
                return RedirectToAction("Index");   
            }
        }

    }

