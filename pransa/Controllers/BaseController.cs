using System.Reflection.Metadata.Ecma335;
using System.Reflection.Metadata;
using System.ComponentModel.Design;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.AdminEntities.Blog;
using DataLayer.AdminEntities.Comment;
using DataLayer.Context;
using pransa.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;
using Microsoft.AspNetCore.Http;
using DataLayer.AdminEntities.Product;
using ViewModels.AdminViewModel.Product;
using ViewModels.AdminViewModel.Users;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
// using ViewModels.AdminViewModel.Originality;

namespace pransa.Controllers {
    public class BaseController : Controller {
        ////////////////////////////////////////////////////type db
        public readonly ContextHampadco db;

        

        public readonly IWebHostEnvironment _env;
      
        public static string mobile;

        public static string ln = "fa", error, eror,msg, suc, NewFileName,number;

      

        public BaseController (ContextHampadco _db, IWebHostEnvironment env) {
            _env = env;
            db = _db;

        }

        public async void setdata()
        {
            
            
           
             menu.cat = db.tbl_category.ToList ();
           
          
            menu.Richat = db.Tbl_Richats.FirstOrDefault ()?.ScriptChat;
            menu.enemad=db.Tbl_Richats.FirstOrDefault ()?.enemad;
            menu.find=db.Tbl_Product.Select(a=>a.TitleProductPro).ToList();

            
           


            menu.site=db.Tbl_Richats.FirstOrDefault ()?.website;
            menu.zarincode=db.Tbl_Richats.FirstOrDefault ()?.zarinpal;
            menu.phone=db.Tbl_Richats.FirstOrDefault ()?.phone;
            menu.sms=db.Tbl_Richats.FirstOrDefault ()?.paternsms;
            menu.newp=db.Tbl_Gallery.Where(a => a.TitleGal == "new").FirstOrDefault()?.pathImage;
            menu.majicp=db.Tbl_Gallery.Where(a => a.TitleGal == "majic").FirstOrDefault()?.pathImage;
             menu.watsap=db.Tbl_Gallery.Where(a => a.TitleGal == "watsap").FirstOrDefault()?.pathImage;
            menu.contactus=db.Tbl_Gallery.Where(a => a.TitleGal == "contactus").FirstOrDefault()?.pathImage;
             menu.app=db.Tbl_Gallery.Where(a => a.TitleGal == "app").FirstOrDefault()?.pathImage;
            menu.SocialNetwork = db.Tbl_SocialNetwork.FirstOrDefault();


            // /////////////////////////////////////////////////////////////////////////////count cart basket
            // if (User.Identity.IsAuthenticated) {
            //     var qorder = db.Tbl_Order.Where (a => a.Id_user == Convert.ToInt32 (User.Identity.GetId ()) && a.State == "record").FirstOrDefault ();
            //     if (qorder != null) {
            //         var qf = db.Tbl_Factors.Where (a => a.Id_Order == qorder.Id).ToList ();
            //         if (qorder != null) {
            //             int sum = 0;
            //             if (qf.Count () != 0) {
            //                 foreach (var item in qf) {
            //                     sum = sum + item.Product_Count;
            //                 }
            //                 menu.order_count = sum;
            //             } else {
            //                 menu.order_count = 0;
            //             }

            //         }

            //     }

            // }else
            // {
            //      menu.order_count = 0;
            // }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////count msg
            menu.resiver = db.Tbl_Message.Where (a => a.StateMess == false && a.SenderMess == "admin" && a.ResiverMess == User.Identity.GetId ()).Count ();
            menu.sender = db.Tbl_Message.Where (a => a.StateMess == false && a.SenderMess == User.Identity.GetId ()).Count ();
            ///////////////////////////////////////////////////////////////////////////logo & titel
            var logo = db.Tbl_Logo.FirstOrDefault ();
            if (logo != null)
            {
                menu.logo = logo.ImageLogo;
                menu.Title = logo.TitleLogo;
                menu.favicon=logo.FavIcon;
            }
            else
            {
                menu.logo = null;
                menu.Title = null;
                menu.favicon=null;    
            }
            /////////////////////////////////////////////////////////////////////////////////favicon
            
            ////////////////////////////////////////////////////////////////////////////////social network
            var social = db.Tbl_SocialNetwork.FirstOrDefault();
            if (social != null)
            {
                menu.Tel=social.Telegram;
                menu.Insta=social.Instagram;
                menu.Face=social.Facebook;
                menu.Twit=social.Twitter;
                menu.Whts=social.Whatsapp;  
            }
            else 
            {
                menu.Tel="Telegram";
                menu.Insta="Instagram";
                menu.Face="Facebook";
                menu.Twit="Twitter";
                menu.Whts="Whatsapp";
            }
            /////////////////////////////////////////////////////////////////////////////search product
            var qproduct = db.Tbl_Product.Where (a => a.Language == ln && a.TypeCarPro=="1").ToList ();
            List<String> lp = new List<string> ();
            foreach (var item in qproduct)
            {
                lp.Add (item.TitleProductPro);
            }
            ViewData["FieldsList"] = lp;
            /////////////////////////////////////////////////////////////////////////////search blog
            var qproduct1 = db.Tbl_Blog.ToList ();
            List<String> lp1 = new List<string> ();
            foreach (var item in qproduct1) {
                lp1.Add (item.TitleBLo);
            }
            ViewData["FieldsList1"] = lp1;
          
        }

        public List<Vm_Product> ShowList()
        {
            ///show list
            // int count = 0;
            if (HttpContext.Session.GetString("shop") != null)
            {
                String[] listshop=(HttpContext.Session.GetString("shop")).Split(",");
                
                if (listshop != null)
                { 
                    List<Vm_Product> q=new  List<Vm_Product>();
                    int sum = 0;
                    int c = 0;
                    foreach (var item in listshop)
                    {
                        var product=db.Tbl_Product.Where(a=>a.Id.ToString()==item && a.TypeCarPro=="1").FirstOrDefault();
                        if (product!=null)
                        {
                            var qlist = q.Any(a => a.Id == product.Id);
                            if (qlist)
                            {
                                var ql=q.Where(a => a.Id == product.Id).FirstOrDefault();
                                int count = ql.count;
                                q.Remove(ql);
                                Vm_Product vm_Products = new Vm_Product()
                                    {
                                        Id = product.Id,
                                        TitleProductPro = product.TitleProductPro,
                                        ImageMainPro = product.ImageMainPro,
                                        PricePro = product.PricePro,
                                        Price_Pro = product.Price_Pro,
                                        BrandPro = product.BrandPro,
                                        OfferPro = product.OfferPro,
                                        MaterialPro = product.MaterialPro ,
                                        TotalPro = product.TotalPro ,
                                        SizePro  = product.SizePro ,
                                        ColorPro = product.ColorPro,
                                        count = count+1
                                    };
                                c++;
                                q.Add(vm_Products);
                                sum = sum + product.Price_Pro;
                            }
                            else
                            {
                                Vm_Product vm_Products = new Vm_Product()
                                {
                                    Id = product.Id,
                                    TitleProductPro = product.TitleProductPro,
                                    ImageMainPro = product.ImageMainPro,
                                    PricePro = product.PricePro,
                                    Price_Pro = product.Price_Pro,
                                    BrandPro = product.BrandPro,
                                    OfferPro = product.OfferPro,
                                    MaterialPro = product.MaterialPro ,
                                    TotalPro = product.TotalPro ,
                                    SizePro  = product.SizePro ,
                                    ColorPro = product.ColorPro,
                                    count = 1
                                };
                                c++;
                                q.Add(vm_Products);
                                sum = sum + product.Price_Pro;
                            }
                        }                              
                    }
                    HttpContext.Session.SetString("count", c.ToString());
                    HttpContext.Session.SetString("sum", sum.ToString());
                    return q;

                  
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}