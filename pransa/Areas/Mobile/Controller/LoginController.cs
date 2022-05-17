using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataLayer.AdminEntities.Users;
using ViewModels.AdminViewModel.Users;
using DataLayer.Context;
using Microsoft.AspNetCore.Hosting;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using pransa.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using DataLayer.AdminEntities.Product;
using Microsoft.AspNetCore.Http;
using System.Security.AccessControl;
using DataLayer.AdminEntities;
using Kavenegar;
using Microsoft.AspNetCore.Authorization;
using ViewModels.AdminViewModel.User1;
using pransa.Controllers;

[Area("Mobile")]
public class LoginController : BaseController
    {

        public static string msg ;

        public LoginController(ContextHampadco _db, IWebHostEnvironment env) : base(_db, env)
        {

        }


        public IActionResult login()
        {
            
            if (HttpContext.Session.GetString("msg")!="null")
            {
                ViewBag.er = HttpContext.Session.GetString("msg");
                HttpContext.Session.SetString("msg", "null");
            }

            

            return View();
        }


        public IActionResult Register()
        {
            if (HttpContext.Session.GetString("msg")!="null")
            {
                ViewBag.msg = HttpContext.Session.GetString("msg");
                HttpContext.Session.SetString("msg", "null");
            }

            return View();
        }


        public IActionResult verify()
        {


            if (HttpContext.Session.GetString("msg")!="null")
            {
                ViewBag.er = HttpContext.Session.GetString("msg");
                HttpContext.Session.SetString("msg", "null");
            }

            

            if (HttpContext.Session.GetString("mobile") != null)
            {
                ViewBag.mobile = HttpContext.Session.GetString("mobile");
            }

            var q = db.Tbl_User.Where(a => a.PhoneUs == HttpContext.Session.GetString("mobile")).FirstOrDefault();
            ViewBag.Mobile = mobile;

            return View();
        }
        public IActionResult sendtoken(Vm_User us)
        {
            Random rnd = new Random();
            string number = rnd.Next(1000, 9999).ToString();
            HttpContext.Session.SetString("mobile", us.PhoneUs);
              
            
            var qcheck = db.Tbl_User.Where(a => a.PhoneUs == us.PhoneUs).FirstOrDefault();
            if (qcheck == null)
            {
                Tb_User user = new Tb_User()
                {
                    PhoneUs = us.PhoneUs,
                    Token = number,
                    PasswordUs=us.PasswordUs,
                    typework=us.repass

                };
                db.Tbl_User.Add(user);
                db.SaveChanges();
                var api = new KavenegarApi("3871353043697339486A70384F544A4A574C74612B51432F4C7A4B305076645457396F5267456F7A5A34383D");
                api.VerifyLookup(us.PhoneUs, number, "demo");
                return RedirectToAction("verify", "login");

            }
            else
            {
                HttpContext.Session.SetString("msg", "این ایمیل یا شماره تلفن قبلا ثبت شده است به بخش ورود برگردید و از بخش فراموشی رمز عبور اقدام کنید ");
               
                return RedirectToAction("Register");

            }
        }

        public IActionResult checkcode(Vm_User us)
        {
            ViewBag.Mobile= HttpContext.Session.GetString("mobile");
            var q=db.Tbl_User.Where(a =>a.PhoneUs==HttpContext.Session.GetString("mobile")).FirstOrDefault();
            if (q.Token==us.Token)
            {
               var claims = new List<Claim> () {
               new Claim (ClaimTypes.NameIdentifier,q.PhoneUs),
               new Claim (ClaimTypes.Name, "")
               };

               var identity = new ClaimsIdentity (claims, CookieAuthenticationDefaults.AuthenticationScheme);

               var principal = new ClaimsPrincipal (identity);

               var properties = new AuthenticationProperties {
                   ExpiresUtc = DateTime.UtcNow.AddYears(1),
                   IsPersistent = true
               };
               HttpContext.SignInAsync (principal, properties);
               var se=HttpContext.Session.GetString ("order");
               if (se != null)
               {
                   return RedirectToAction("index","profile");
               }
               

               return RedirectToAction("index","profile");
            }
            else
            {
                HttpContext.Session.SetString("msg", "کد ورودی نادرست است");
                
                return RedirectToAction("verify");
            }
        }



          public IActionResult checklogin(Vm_User us)
        {
             if ((Captcha.ValidateCaptchaCode(us.repass, HttpContext)))
            {
              


                var q = db.Tbl_User.Where(a => a.EmailUS == us.PhoneUs && a.PasswordUs == us.PasswordUs).FirstOrDefault();
                if (q == null)
                {

                    q = db.Tbl_User.Where(a => a.PhoneUs == us.PhoneUs && a.PasswordUs == us.PasswordUs).FirstOrDefault();
                }

                if (q != null)
                {

                    var claims = new List<Claim>() {
               new Claim (ClaimTypes.NameIdentifier,q.PhoneUs),
               new Claim (ClaimTypes.Name, "")
               };

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal(identity);

                    var properties = new AuthenticationProperties
                    {
                        ExpiresUtc = DateTime.UtcNow.AddYears(1),
                        IsPersistent = true
                    };
                    HttpContext.SignInAsync(principal, properties);
                    var se = HttpContext.Session.GetString("order");
                    if (se != null)
                    {
                        return RedirectToAction("index", "profile");
                    }


                    return RedirectToAction("index", "profile");
                }
                else
                {
                    HttpContext.Session.SetString("msg", "نام کاربری یا رمز عبور شما نادرست است");

                    return RedirectToAction("login");
                }

                



          }else
          {
              HttpContext.Session.SetString("msg", "کد تصویر نادرست است");

                    return RedirectToAction("login");
              
          }


     }


[HttpPost]
               public IActionResult sendtokenforget(Vm_User us)
                    {
                    Random rnd = new Random();
                    string number = rnd.Next(1000, 9999).ToString();
                    HttpContext.Session.SetString("mobile", us.PhoneUs);
                    
                    
                    var qcheck = db.Tbl_User.Where(a => a.PhoneUs == us.PhoneUs).FirstOrDefault();
                    if (qcheck != null)
                    {

                       qcheck.Token = number;

                        db.Tbl_User.Update(qcheck);
                        db.SaveChanges();
                        var api = new KavenegarApi("3871353043697339486A70384F544A4A574C74612B51432F4C7A4B305076645457396F5267456F7A5A34383D");
                        api.VerifyLookup(us.PhoneUs, number, "demo");
                        return RedirectToAction("verifyforget", "login");

                    }
                    else
                    {
                        HttpContext.Session.SetString("msg", "این ایمیل یا شماره تلفن  ثبت نشده است");
                    
                        return RedirectToAction("forget","login");

                    }
                }


[HttpPost]
     
 public IActionResult checkcodeforget(Vm_User us)
        {
            ViewBag.Mobile= HttpContext.Session.GetString("mobile");
            var q=db.Tbl_User.Where(a =>a.PhoneUs==HttpContext.Session.GetString("mobile")).FirstOrDefault();
            if (q.Token==us.Token)
            {
               var claims = new List<Claim> () {
               new Claim (ClaimTypes.NameIdentifier,q.PhoneUs),
               new Claim (ClaimTypes.Name, "")
               };

               var identity = new ClaimsIdentity (claims, CookieAuthenticationDefaults.AuthenticationScheme);

               var principal = new ClaimsPrincipal (identity);

               var properties = new AuthenticationProperties {
                   ExpiresUtc = DateTime.UtcNow.AddYears(1),
                   IsPersistent = true
               };
               HttpContext.SignInAsync (principal, properties);
               var se=HttpContext.Session.GetString ("order");
               if (se != null)
               {
                   return RedirectToAction("index","profile");
               }
               

               return RedirectToAction("index","profile");
            }
            else
            {
                HttpContext.Session.SetString("msg", "کد ورودی نادرست است");
                
                return RedirectToAction("verify");
            }
        }

        public IActionResult forget()
        {
             if (HttpContext.Session.GetString("msg")!="null")
            {
                ViewBag.msg = HttpContext.Session.GetString("msg");
                HttpContext.Session.SetString("msg", "null");
            }
            return View();
        }

        public IActionResult verifyforget()
        {
            // TODO: Your code here
            return View();
        }
        

    

        

    
     
}
 