using System.ComponentModel.Design;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.AdminEntities.Blog;
using DataLayer.Context;
using pransa.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using ViewModels.AdminViewModel.SocialNetwork;
using ViewModels.AdminViewModel.Product;
using AutoMapper;
using ViewModels.AdminViewModel.Calender;
using Microsoft.AspNetCore.Mvc.Rendering;
using ViewModel.AdminViewModel.Page;
using ViewModels.AdminViewModel.Blog;
using pransa.Controllers;

[Area("Mobile")]
    public class HomeController : BaseController {
        private readonly ContextHampadco db;
        private readonly IWebHostEnvironment env;
        private readonly IMapper map;

        ////////////////////////////////////////////////////type db
        public HomeController (ContextHampadco _db, IWebHostEnvironment env,IMapper map) : base (_db, env) {
            db = _db;
            this.env = env;
            this.map = map;
        }

        //////////////////////////////////////////////////////////
        public  IActionResult Index () {
            setdata();
            ShowList();

            ViewBag.page = "main";

            ViewBag.user = db.Tbl_User.ToList();
            //شرکت های غرفه سازی
            ViewBag.ghorfe = db.tbl_Pages.Where(a => a.MainCat == "شرکت های غرفه سازی").OrderByDescending(a => a.Id).Take(4).ToList();
             //تامین کنندگان خدمات غرفه سازی
            ViewBag.khadamat = db.tbl_Pages.Where(a => a.MainCat == "تامین کنندگان خدمات غرفه سازی").OrderByDescending(a => a.Id).Take(6).ToList();
             //تامین کنندگان کالای غرفه سازی
            ViewBag.kala = db.tbl_Pages.Where(a => a.MainCat == "تامین کنندگان کالای غرفه سازی").OrderByDescending(a => a.Id).Take(6).ToList();
             //تامین کنندگان منابع انسانی
            ViewBag.ensan = db.tbl_Pages.Where(a => a.MainCat == "تامین کنندگان منابع انسانی").OrderByDescending(a => a.Id).Take(6).ToList();
           //تامین کنندگان ماشین های اداری و کارگاهی
            ViewBag.mashin = db.tbl_Pages.Where(a => a.MainCat == "تامین کنندگان ماشین های اداری و کارگاهی").OrderByDescending(a => a.Id).Take(4).ToList();
           //فری لنسرها
            ViewBag.free = db.tbl_Pages.Where(a => a.MainCat == "فری لنسرها").OrderByDescending(a => a.Id).Take(6).ToList();
           //علاقه مندی
            ViewBag.fav = db.tbl_Pages.Skip(5).Take(6).ToList();
            //محصولات
            ViewBag.product = db.Tbl_Product.OrderByDescending(a => a.Id).Take(6).ToList();
            //اسلایدر
            ViewBag.slider = db.Tbl_Slider.OrderByDescending(a => a.Id).Take(3).ToList();
             //بنر
            ViewBag.baner = db.Tbl_Baner.OrderByDescending(a => a.Id).Take(2).ToList();
            //آخریم مقالات
            ViewBag.magale = db.Tbl_Blog.Where(a => a.IdCtegoryBlo == 1).OrderByDescending(a => a.Id).Take(6).ToList();
         

          
         



            return View ();
        }

        public IActionResult exit () {
            HttpContext.SignOutAsync (CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction ("index", "home");
        }

        // public IActionResult orgincheck (string id) {
        //      setdata();
        //     var orgin = db.Tbl_Originality.Where (a => a.HologramCodeOri == id).ToList ();
        //     if (orgin.Count () != 0) {
        //         ///////////////////////////////////////////////////////////list

        //         List<Vm_Originality> originality = new List<Vm_Originality> ();
        //         foreach (var item in orgin) {
        //             var product = db.Tbl_Product.Where (a => a.Id == item.IdProductOri).FirstOrDefault ();
        //             Vm_Originality origin = new Vm_Originality () {
        //                 Id = item.Id,
        //                 nameproduct = product.TitleProductPro,
        //                 HologramCodeOri = item.HologramCodeOri,
        //                 NumberProductOri = item.NumberProductOri,
        //                 Language = item.Language,
        //                 DateCreateOri = item.DateCreateOri,
        //                 img = product.ImageMainPro,
        //                 IdProductOri=product.Id
        //             };
        //             originality.Add (origin);

        //         }

        //         ViewBag.listp = originality.OrderByDescending (a => a.Id).ToList ();
        //         //////////////////////////////////////////////////////////
        //     } else {
        //         error = "چنین کد هولوگرامی در شرکت سون استار ثبت نشده است";
        //         return RedirectToAction ("orgin");
        //     }
        //     return View ();
        // }

        // [Authorize]
        public IActionResult orgin () 
        {
            ViewBag.list = ShowList();
            if (error != null) {
                ViewBag.e = error;
                error = null;
            }
            return View ();
        }


        ///////////////////////////////////////////addshop
        public IActionResult addshop (int id) {
            
            ViewBag.list = ShowList();

            string a=HttpContext.Session.GetString ("shop");

            if ( a != null)
            {
                 HttpContext.Session.SetString ("shop",a+id.ToString()+",");
            }else
            {
                HttpContext.Session.SetString ("shop",id.ToString()+",");
            }
            

           
            return RedirectToAction ("index");
        }

        public IActionResult search(string city,string myinput)
        {
            ViewBag.quser = db.Tbl_User.ToList();
            if (city == null)
            {
                var result = db.tbl_Pages.Where(a => a.Title.Contains(myinput) ).ToList();
                if (result.Count()==0)
                {
                      result = db.tbl_Pages.Where(a => a.description.Contains(myinput) ).ToList();
                      if (result.Count()==0)
                      {
                          result = db.tbl_Pages.Where(a => a.Citys.Contains(myinput) ).ToList();
                      }
                }

                var mresult = map.Map<List<MPages>>(result);
                return View(mresult);
            }
            else if (city != "همه" && myinput != null)
            {
                var result = db.tbl_Pages.Where(a => a.Title.Contains(myinput) && a.Citys.Contains(city)).ToList();
                if (result.Count()==0)
                {
                      result = db.tbl_Pages.Where(a => a.description.Contains(myinput) && a.Citys.Contains(city) ).ToList();
                      if (result.Count()==0)
                      {
                          result = db.tbl_Pages.Where(a => a.Citys.Contains(myinput) && a.Citys.Contains(city) ).ToList();
                      }
                }

                var mresult = map.Map<List<MPages>>(result);
                return View(mresult);
            }
             else if (myinput == null)
            {
                var result = db.tbl_Pages.Where(a =>  a.Citys.Contains(city)).ToList();
                if (result.Count()==0)
                {
                      result = db.tbl_Pages.Where(a =>  a.Citys.Contains(city) ).ToList();
                      if (result.Count()==0)
                      {
                          result = db.tbl_Pages.Where(a => a.Citys.Contains(city) ).ToList();
                      }
                }

                var mresult = map.Map<List<MPages>>(result);
                return View(mresult);
            }

            return View();


        }
        public IActionResult searchcat(int page,int Id)
        {
            int skip;
            if (page == 0)
            {
                skip= 0 ;
            }
            else
            {
                skip =page-1;
            }
            ViewBag.list = ShowList();
            var cat = db.Tbl_Product.Where(a =>a.CategoryIdPro==Id.ToString() && a.TypeCarPro=="1").OrderByDescending (a => a.Id).Skip(skip*12).Take(12).ToList();
            if (cat.Count != 0)
            {
                    decimal count1 = db.Tbl_Product.Where(a =>a.CategoryIdPro==Id.ToString() && a.TypeCarPro=="1").Count();
                    decimal sdd=count1/12;
                    var countpage=Math.Ceiling(sdd);

                List<Vm_Product> vp = new List<Vm_Product>();

                foreach (var item in cat)
                {
                    var fav = db.Tbl_MyFavorites.Where(a => a.IdKala == item.Id && a.IdUser== User.Identity.GetId()).FirstOrDefault();
                    var check_fav = "0" ;
                    if (fav != null)
                    {
                        check_fav = "1" ;
                    }
                    Vm_Product vm = new Vm_Product
                    {
                        Id = item.Id ,
                        TitleProductPro = item.TitleProductPro ,
                        ImageMainPro = item.ImageMainPro ,
                        BrandPro = item.BrandPro ,
                        PricePro = item.PricePro ,
                        Language = check_fav ,
                    };

                    vp.Add(vm);
                }
                ViewBag.cat = vp;
                ViewBag.Id=Id;
                ViewBag.countpage=Convert.ToInt16(countpage);
            }
            else
            {
                ViewBag.msg="کالایی یافت نشد";
            }

            return View();
        }
        public IActionResult searchchildcat(int page,int Id)
        {
            int skip;
            if (page == 0)
            {
                skip= 0 ;
            }
            else
            {
                skip =page-1;
            }
            ViewBag.list = ShowList();
            var cat = db.Tbl_Product.Where(a =>a.CategoryChildIdPro==Id.ToString() && a.TypeCarPro=="1").OrderByDescending (a => a.Id).Skip(skip*12).Take(12).ToList();
            if (cat.Count != 0)
            {
                    decimal count1 = db.Tbl_Product.Where(a =>a.CategoryChildIdPro==Id.ToString() && a.TypeCarPro=="1").Count();
                    decimal sdd=count1/12;
                    var countpage=Math.Ceiling(sdd);

                List<Vm_Product> vp = new List<Vm_Product>();
            
                foreach (var item in cat)
                {
                var fav = db.Tbl_MyFavorites.Where(a => a.IdKala == item.Id && a.IdUser== User.Identity.GetId()).FirstOrDefault();
                var check_fav = "0" ;
                if (fav != null)
                {
                    check_fav = "1" ;
                }
                Vm_Product vm = new Vm_Product
                {
                    Id = item.Id ,
                    TitleProductPro = item.TitleProductPro ,
                    ImageMainPro = item.ImageMainPro ,
                    BrandPro = item.BrandPro ,
                    PricePro = item.PricePro ,
                    Language = check_fav ,
                };

                vp.Add(vm);
                }
                ViewBag.cat = vp;
                ViewBag.Id=Id;
                ViewBag.countpage=Convert.ToInt16(countpage);
            }
            else
            {
                ViewBag.msg="کالایی یافت نشد";
            }

            return View();
        }

        public IActionResult privacyrul()
        {
            // TODO: Your code here
            return View();
        }

        public IActionResult calender(int? id)
        {
            var qlist = db.tbl_Calenders.Where(a => a.Id==id).FirstOrDefault();
            var m = map.Map<MCalender>(qlist);
            return View(m);
        }

        public IActionResult bio()
        {
            // TODO: Your code here
            return View();
        }
        

        public IActionResult calenderlist()
        {
            var qlist = db.tbl_Calenders.OrderByDescending(a => a.Id).ToList();
            var m = map.Map<List<MCalender>>(qlist);
            //city
            var qcity = db.tb_Cities.OrderBy(a=>a.Id).ToList();
            ViewBag.City = new SelectList(qcity, "Name", "Name");
            //location
             var qnam = db.tb_Namayeshgahs.OrderBy(a=>a.Id).ToList();
            ViewBag.nam = new SelectList(qnam, "Name", "Name");

             //location
             var qtnam = db.tb_TNamayeshgahs.OrderBy(a=>a.Id).ToList();
            ViewBag.tnam = new SelectList(qtnam, "Name", "Name");

            return View(m);
        }



 [HttpPost]
        public async Task<IActionResult> calenderlist(string shahr,string loc,string title)
        {
            var qlist= db.tbl_Calenders.OrderByDescending(a => a.Id).ToList();
            if(shahr!="همه" && loc=="همه" && title=="همه")
            {
               qlist= db.tbl_Calenders.Where(a=>a.City==shahr).OrderByDescending(a => a.Id).ToList();
            }
            else if(shahr!="همه" && loc!="همه" && title=="همه")
            {
               qlist= db.tbl_Calenders.Where(a=>a.City==shahr && a.Location==loc).OrderByDescending(a => a.Id).ToList();
            }
             else if(shahr!="همه" && loc!="همه" && title!="همه")
            {
               qlist= db.tbl_Calenders.Where( a=>a.City==shahr && a.Location==loc && a.Title==title).OrderByDescending(a => a.Id).ToList();
            }
             else if(shahr=="همه" && loc!="همه" && title=="همه")
            {
               qlist= db.tbl_Calenders.Where(a=>a.Location==loc).OrderByDescending(a => a.Id).ToList();
            }
             else if(shahr=="همه" && loc=="همه" && title!="همه")
            {
               qlist= db.tbl_Calenders.Where(a=>a.Title==title).OrderByDescending(a => a.Id).ToList();
            }

            //city
            var qcity = db.tb_Cities.OrderBy(a=>a.Id).ToList();
            ViewBag.City = new SelectList(qcity, "Name", "Name");
            //location
             var qnam = db.tb_Namayeshgahs.OrderBy(a=>a.Id).ToList();
            ViewBag.nam = new SelectList(qnam, "Name", "Name");

             //location
             var qtnam = db.tb_TNamayeshgahs.OrderBy(a=>a.Id).ToList();
            ViewBag.tnam = new SelectList(qtnam, "Name", "Name");
                     
            var m = map.Map<List<MCalender>>(qlist);
            

            return View(m);
        }


        
        
        
           public IActionResult Category(string? name)
            {
              var qp=db.tbl_Pages.Where(a=>a.SubCat==name).ToList();
              if (qp.Count() !=0)
              {
                   var qpag = map.Map<List<MPages>>(qp);
                ViewBag.quser = db.Tbl_User.ToList();
                TempData["cat"] = name;
                return View(qpag);
              }


            return View();

        }


             public IActionResult details(int? id)
        {
            var qpage = db.tbl_Pages.Where(a => a.Id == id).FirstOrDefault();
            var q = map.Map<MPages>(qpage);
            ViewBag.qus=db.Tbl_User.Where(a => a.PhoneUs == qpage.UserId).FirstOrDefault();
            return View(q);
        }

        private class Mpages
        {
        }


             public IActionResult detailsshop(int? id)
        {
            setdata();
            var qpage = db.Tbl_Product.Where(a => a.Id == id).FirstOrDefault();
            var q = map.Map<Vm_Product>(qpage);
            ViewBag.qimg=db.tb_GalleryProducts.Where(a => a.IdProduct == qpage.Id).ToList();
            var qcolor = db.Tbl_ColorProducts.Where( a => a.IdProduct == qpage.Id ).ToList();
            ViewBag.color = qcolor;
            ShowList();
            return View(q);
        }


        public IActionResult selectcat()
        {
          
            return View();
        }
        public IActionResult categoryshop()
        {
            //محصولات
            var product = db.Tbl_Product.OrderByDescending(a => a.Id).ToList();
        var result = map.Map<List<Vm_Product>>(product);
        return View(result);
        }
        
        
    }
