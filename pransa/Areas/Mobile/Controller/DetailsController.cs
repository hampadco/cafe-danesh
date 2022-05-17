using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataLayer.Context;
using DataLayer.AdminEntities.Product;
using pransa.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pransa.Models;
using DataLayer.Context;
using DataLayer.AdminEntities;
using Kavenegar;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using ViewModels.AdminViewModel.GalleryProduct;
using ViewModels;
using ViewModels.Area.Questions;
using DataLayer.AdminEntities.Comment;
using pransa.Controllers;

[Area("Mobile")]
    public class DetailsController :BaseController
    {
        
           ////////////////////////////////////////////type db
           public DetailsController(ContextHampadco _db,IWebHostEnvironment env):base(_db,env)
        {
            
        }

        public IActionResult index(int Id)
        {
            if (msg != null) {
                ViewBag.msg = msg;
                msg = null;
            }

            ViewBag.list = ShowList();
            ViewBag.product=db.Tbl_Product.Where(a=>a.TypeCarPro=="1").OrderByDescending(a => a.Id).Take(6).ToList();

            ViewBag.kala=db.Tbl_Product.Where(a=>a.Id==Id && a.TypeCarPro=="1").ToList();

            var s = db.tb_GalleryProducts.Where(a => a.IdProduct == Id).ToList();
            List<Vm_GalleryProduct> sd = new List<Vm_GalleryProduct>();
            foreach (var item in s)
            {
                Vm_GalleryProduct q = new Vm_GalleryProduct()
                {
                    Id = item.Id,
                    ImagePath = item.ImagePath,
                    
                };
                sd.Add(q);
            }
            ViewBag.GaleryP = sd;
            ViewBag.fav = db.Tbl_MyFavorites.Where(a => a.IdKala == Id && a.IdUser== User.Identity.GetId()).FirstOrDefault();
            
            var qcolor = db.Tbl_ColorProducts.Where( a => a.IdProduct == Id ).ToList();
            ViewBag.color = qcolor;

            return View();
        }
        //addcatr
        public IActionResult addcart(int id)
        {
            //add
            string a=HttpContext.Session.GetString ("shop");

            if ( a != null)
            {
                 HttpContext.Session.SetString ("shop",a+id.ToString()+",");
            }else
            {
                HttpContext.Session.SetString ("shop",id.ToString()+",");
            }
            
            //count
           
            ShowList();

            return RedirectToAction ("detailsshop","home",new{id=id});
        }

        public IActionResult del(int id)
        {

            //  String[] listshop=(HttpContext.Session.GetString("shop")).Split(",");
            //     if (listshop != null)
            //     { 
                  
            //         foreach (var item in listshop)
            //         {
            //             if (item==id.ToString())
            //             {
                            
            //             }else
            //             {
                            
            //             }


            HttpContext.Session.SetString("shop",HttpContext.Session.GetString("shop").Replace(id.ToString()+",",""));
            ShowList();
            
             return RedirectToAction("index",new{id=id});
        }
        
        public IActionResult question(Vm_Questions Question)
        {
            Tb_Comment c = new Tb_Comment()
            {
                User = User.Identity.GetId(),
                Date = DateTime.UtcNow,
                Message = Question.Message,
                product_id = Question.ProductId,
            };
            db.Tbl_Comments.Add(c);
            db.SaveChanges();
            msg="پرسش شما با موفقیت ثبت شد";
            return RedirectToAction("index",new{id=Question.ProductId});
        }
        
        
        
    }
