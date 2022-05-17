using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pransa.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using DataLayer.Context;
using Microsoft.AspNetCore.Hosting;
using ViewModels.AdminViewModel.Users;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using DataLayer.AdminEntities.Users;

namespace pransa.Areas.Admin.Controllers
{
    [Area("Admin")]
   
    public class HomeController : BaseController
    {
        public static string msg ;
        public HomeController(ContextHampadco _db,IWebHostEnvironment  env) :base(_db,env)
        {
        }
        public IActionResult Index()
        {
            var user = db.Tbl_User.Where(a => a.UserNameUs=="admin").FirstOrDefault();
            if (user != null)
            {
                menu.img=user.ProfileImageUs;
            }
             
            menu.resiver=db.Tbl_Message.Where(a=>a.StateMess==false && a.SenderMess!="admin").Count();
            menu.sender=db.Tbl_Message.Where(a=>a.StateMess==false && a.SenderMess=="admin").Count();
          
            return View();
        }
        public IActionResult exit()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("index","home");
        }

        public IActionResult RayChat()
        {
          return View();
        }

        public IActionResult login()
        {
            if ( msg != null )
            {
                ViewBag.msg = msg ;
                msg = null ;   
            }

            return View();
        }

        public IActionResult checklogin(Vm_User vu)
        {

            if ((Captcha.ValidateCaptchaCode(vu.Token, HttpContext)))
            {
                var user = db.Tbl_User.Where(a => a.UserNameUs=="admin").FirstOrDefault();
                if (user==null)
                {
                    Tb_User us = new Tb_User()
                    {
                        UserNameUs = "admin",
                        PasswordUs="admin",
                        PhoneUs="09149501938",
                        UserFamilyUs="مدیریت "

                   };
                    db.Tbl_User.Add(us);
                    db.SaveChanges();

                }
             user = db.Tbl_User.Where(a => a.UserNameUs=="admin").FirstOrDefault();
            if ( vu.UserNameUs == user.UserNameUs && vu.PasswordUs == user.PasswordUs )
            {
                var claims = new List<Claim> () {
                new Claim (ClaimTypes.NameIdentifier,"admin"),
                new Claim (ClaimTypes.Name, user.UserFamilyUs)
                };
                HttpContext.Session.SetString("mobile",user.PhoneUs);
    
                var identity = new ClaimsIdentity (claims, CookieAuthenticationDefaults.AuthenticationScheme);
    
                var principal = new ClaimsPrincipal (identity);
    
                var properties = new AuthenticationProperties {
                    ExpiresUtc = DateTime.UtcNow.AddYears(1),
                    IsPersistent = true
                };
                HttpContext.SignInAsync (principal, properties);
                return RedirectToAction( "index" , "home" );
            }
            else
            {
                msg = "نام کاربری یا رمز اشتباه است" ;
                return RedirectToAction( "login" , "home" ); 
            }


            }
            else
            {
                 msg = "کد تصویری وارد شده اشتباه است ." ;
                return RedirectToAction( "login" , "home" ); 
                
            }


           

            

        }

      
    }
}