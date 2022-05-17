using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using AutoMapper;
using DataLayer.AdminEntities;
using DataLayer.AdminEntities.Order;
using DataLayer.AdminEntities.Page;
using DataLayer.AdminEntities.Product;
using DataLayer.AdminEntities.Users;
using DataLayer.Context;
using Kavenegar;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModel.AdminViewModel.Page;
using ViewModels.AdminViewModel.GalleryProduct;
using ViewModels.AdminViewModel.Product;
using ViewModels.AdminViewModel.Users;
using pransa.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using pransa.Controllers;

[Area("Mobile")]
public class profileController : BaseController
    {
        public static string msg;

        private readonly IMapper map;

        //--------------type db
        public profileController(
            ContextHampadco _db,
            IWebHostEnvironment env,
            IMapper _map
        ) :
            base(_db, env)
        {
            map = _map;
        }

        public IActionResult index()
        {
            // ViewBag.list = ShowList();
            // var user = db.Tbl_User.Where(a => a.PhoneUs == HttpContext.Session.GetString("mobile")).FirstOrDefault();
            // List<Vm_User> vs = new List<Vm_User>();
            // Vm_User vuser = new Vm_User()
            // {
            //     UserNameUs = user.UserNameUs ,
            //     UserFamilyUs = user.UserFamilyUs ,
            //     NationalCode = user.NationalCode ,
            //     PhoneUs = user.PhoneUs ,
            //     AddressUs = user.AddressUs ,
            //     Post = user.Post ,
            //     EmailUS = user.EmailUS ,
            //     ProfileImageUs = user.ProfileImageUs ,
            // };
            // vs.Add(vuser);
            // ViewBag.us = vs;
            // HttpContext.Session.SetString("username", (vuser.UserNameUs+" "+vuser.UserFamilyUs));
            // HttpContext.Session.SetString("phone", vuser.PhoneUs);
            // if ( vuser.ProfileImageUs != null)
            // {
            //     HttpContext.Session.SetString("photo" , vuser.ProfileImageUs );
            // }
            return View();
        }

        public IActionResult nazarat()
        {
            ViewBag.nazarat =
                db
                    .Tbl_Comments
                    .Where(a => a.User == User.Identity.GetId())
                    .ToList();
            return View();
        }

        public IActionResult CheckPardakht()
        {
            var adr =
                db
                    .Tbl_User
                    .Where(a => a.PhoneUs == User.Identity.GetId())
                    .FirstOrDefault();

            if (adr.AddressUs != null)
            {
                return RedirectToAction("Request", "Pay");
            }
            else
            {
                msg = " لطفا پروفایل خود را تکمیل کنید ";
                return RedirectToAction("update");
            }
        }

        public IActionResult Update()
        {
            if (msg != null)
            {
                ViewBag.msg = msg;
                msg = null;
            }
            var user =
                db
                    .Tbl_User
                    .Where(a =>
                        a.PhoneUs == HttpContext.Session.GetString("mobile"))
                    .FirstOrDefault();

            // List<Vm_User> vs = new List<Vm_User>();
            Vm_User vuser =
                new Vm_User()
                {
                    UserNameUs = user.UserNameUs,
                    UserFamilyUs = user.UserFamilyUs,
                    NationalCode = user.NationalCode,
                    PhoneUs = user.PhoneUs,
                    AddressUs = user.AddressUs,
                    Post = user.Post,
                    EmailUS = user.EmailUS,
                    ProfileImageUs = user.ProfileImageUs
                };

            ViewBag.img = vuser;

            return View(vuser);
        }

        public async Task<IActionResult> updateprofile(Vm_User vs)
        {
            var quser =
                db
                    .Tbl_User
                    .Where(a => a.PhoneUs == User.Identity.GetId())
                    .FirstOrDefault();

            if (quser.UserNameUs == "admin")
            {
                quser.EmailUS = vs.EmailUS;
                quser.AddressUs = vs.AddressUs;
                quser.Post = vs.Post;
                quser.NationalCode = vs.NationalCode;
                quser.UserFamilyUs = vs.UserFamilyUs;

                if (vs.img != null)
                {
                    //--------------------------------------------upload file
                    string FileExtension1 = Path.GetExtension(vs.imgf.FileName);
                    NewFileName =
                        String
                            .Concat(Guid.NewGuid().ToString(), FileExtension1);
                    var path = $"{_env.WebRootPath}\\fileupload\\{NewFileName}";
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await vs.imgf.CopyToAsync(stream);
                    }
                    quser.ProfileImageUs = NewFileName;
                }

                db.Tbl_User.Update (quser);
                db.SaveChanges();
                var se = HttpContext.Session.GetString("order");
                if (se != null)
                {
                    return RedirectToAction("index", "order");
                }
                return RedirectToAction("Index");
            }
            else
            {
                quser.UserNameUs = vs.UserNameUs;
                quser.EmailUS = vs.EmailUS;
                quser.AddressUs = vs.AddressUs;
                quser.Post = vs.Post;
                quser.NationalCode = vs.NationalCode;
                quser.UserFamilyUs = vs.UserFamilyUs;

                if (vs.img != null)
                {
                    //--------------------------------------------upload file
                    string FileExtension1 = Path.GetExtension(vs.imgf.FileName);
                    NewFileName =
                        String
                            .Concat(Guid.NewGuid().ToString(), FileExtension1);
                    var path = $"{_env.WebRootPath}\\fileupload\\{NewFileName}";
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await vs.imgf.CopyToAsync(stream);
                    }
                    quser.ProfileImageUs = NewFileName;
                }

                db.Tbl_User.Update (quser);
                db.SaveChanges();
                var se = HttpContext.Session.GetString("order");
                if (se != null)
                {
                    return RedirectToAction("index", "order");
                }
                return RedirectToAction("Index");
            }
        }

        public IActionResult addadress()
        {
            return View();
        }

        public IActionResult addfavorite(int Id)
        {
            var s =
                db
                    .Tbl_MyFavorites
                    .Where(a =>
                        a.IdKala == Id && a.IdUser == User.Identity.GetId())
                    .FirstOrDefault();
            if (s != null)
            {
                db.Tbl_MyFavorites.Remove (s);
                db.SaveChanges();
                return RedirectToAction("index", "Details", new { id = Id });
            }
            else
            {
                Tbl_MyFavorite Ad =
                    new Tbl_MyFavorite()
                    { IdKala = Id, IdUser = User.Identity.GetId() };
                db.Tbl_MyFavorites.Add (Ad);
                db.SaveChanges();
                return RedirectToAction("index", "Details", new { id = Id });
            }
        }

        public IActionResult Factor()
        {
            ViewBag.order =
                db
                    .Tbl_Order
                    .Where(a => a.Id_user == User.Identity.GetId())
                    .OrderByDescending(a => a.Id)
                    .ToList();
            return View();
        }

        public IActionResult detailfactor(int id)
        {
            ViewBag.order = db.Tbl_Factors.Where(a => a.RFactor == id).ToList();
            return View();
        }

        public IActionResult favorite()
        {
            var ik =
                db
                    .Tbl_MyFavorites
                    .Where(a => a.IdUser == User.Identity.GetId())
                    .Select(a => a.IdKala)
                    .ToList();

            // var kala = db.Tbl_Product.Where( a=> a.Id == ik).ToList();
            List<Vm_Product> lvp = new List<Vm_Product>();

            foreach (var item in ik)
            {
                var kala =
                    db.Tbl_Product.Where(a => a.Id == item).FirstOrDefault();
                if (kala.TypeCarPro == "1")
                {
                    Vm_Product vp =
                        new Vm_Product()
                        {
                            Id = kala.Id,
                            TitleProductPro = kala.TitleProductPro,
                            BrandPro = kala.BrandPro,
                            PricePro = kala.PricePro,
                            ImageMainPro = kala.ImageMainPro
                        };
                    lvp.Add (vp);
                }
            }

            ViewBag.oll = lvp;

            return View();
        }

        //    public IActionResult addfavorite()
        //    {
        //        return View();
        //    }
        public IActionResult add()
        {
              //maincat
            var q = db.tbl_category.Where(a=>a.NameCat=="نمایشگاه").OrderBy(a=>a.Id).FirstOrDefault();
            if (q != null)
            {
                var q2 = db.tbl_category.Where(a => a.FatherIdCat == q.Id).ToList();
                 ViewBag.catmain = new SelectList(q2, "NameCat", "NameCat");

            }
           
            //subcat

             var q1 = db.tbl_category.Where(a=>a.NameCat=="نمایشگاه").OrderBy(a=>a.Id).FirstOrDefault();
            if (q1 != null)
            {
                var q3 = db.tbl_category.Where(a => a.FatherIdCat != q.Id && a.FatherIdCat !=0).ToList();
                 ViewBag.catsub = new SelectList(q3, "NameCat", "NameCat");

            }
            return View();
        }

        public IActionResult profileme()
        {
            var phone = User.Identity.GetId();
            var quser =
                db.Tbl_User.Where(a => a.PhoneUs == phone).FirstOrDefault();
            var result = map.Map<Vm_User>(quser);

            return View(result);
        }

        public IActionResult pass()
        {
            var b = TempData["msg"];
            return View();
        }

        public IActionResult listnotvertify()
        {
            return View();
        }

        public IActionResult listvertify()
        {
           var qpage = db.tbl_Pages.OrderByDescending(a => a.Id).ToList();
            var mpage = map.Map<List<MPages>>(qpage);

            return View(mpage);
            
        }

        public IActionResult listreport()
        {
            // TODO: Your code here
            return View();
        }

        public IActionResult listreject()
        {
            // TODO: Your code here
            return View();
        }

        [HttpPost]
        public IActionResult pass(Vm_User us)
        {
            if (us.PasswordUs == us.repass)
            {
                var phone = User.Identity.GetId();
                var quser =
                    db
                        .Tbl_User
                        .Where(a => a.PhoneUs == phone)
                        .FirstOrDefault();
                quser.PasswordUs = us.PasswordUs;

                db.Tbl_User.Update (quser);
                db.SaveChanges();
                TempData["msg"] = "تغییر رمز عبور شما با موفقیت انجام شد";
            }
            else
            {
                TempData["msge"] = "رمز عبورهای شما با هم مطابقت ندارند ";
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> profileme(Vm_User us)
        {
            var phone = User.Identity.GetId();
            var quser =
                db.Tbl_User.Where(a => a.PhoneUs == phone).FirstOrDefault();
            quser.NameCompany = us.NameCompany;
            quser.Tel = us.Tel;
            quser.Ostan = us.Ostan;
            quser.City = us.City;
            quser.Website = us.Website;
            quser.Instagram = us.Instagram;
            quser.Telegram = us.Telegram;
            quser.WhatsApp = us.WhatsApp;
            quser.Shoar = us.Shoar;
            quser.AddressUs = us.AddressUs;

            if (us.imgf != null)
                quser.ProfileImageUs = await UplodeFile(us.imgf);

            if (us.CoverImagef != null)
                quser.CoverImage = await UplodeFile(us.CoverImagef);

            db.Tbl_User.Update (quser);
            db.SaveChanges();

            return RedirectToAction("profileme");
        }

        public async Task<string> UplodeFile(IFormFile img)
        {
            if (img != null)
            {
                //--------------------------------------------upload file
                string FileExtension1 = Path.GetExtension(img.FileName);
                string NewFileName =
                    String.Concat(Guid.NewGuid().ToString(), FileExtension1);
                var path = $"{_env.WebRootPath}\\fileupload\\{NewFileName}";
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await img.CopyToAsync(stream);
                }
                return NewFileName;
            }
            return "";
        }

        [HttpPost]
        public async Task<IActionResult> add(MPages mp)
        {
            string mainimage=null,image1=null,image2=null,image3=null,image4=null;

            if (mp.MainImagef != null) mainimage = await UplodeFile(mp.MainImagef);
            if (mp.Image1f != null) image1 = await UplodeFile(mp.Image1f);
            if (mp.Image2f != null) image2 = await UplodeFile(mp.Image2f);
            if (mp.Image3f != null) image3 = await UplodeFile(mp.Image3f);
            if (mp.Image4f != null) image4 = await UplodeFile(mp.Image4f);
            Tbl_Pages page = new Tbl_Pages()
            {
                    UserId = User.Identity.GetId(),
                    Title = mp.Title,
                    MainCat = mp.MainCat,
                    SubCat = mp.SubCat,
                    MainImage = mainimage,
                    Image1 = image1,
                    Image2 = image2,
                    Image3 = image3,
                    Image4 = image4,
                    Citys = mp.Citys,
                    TypeSend = mp.TypeSend,
                    TypePay = mp.TypePay,
                    LocationPay = mp.LocationPay,
                    description = mp.description
                };
            db.tbl_Pages.Add (page);
            db.SaveChanges();
            TempData["msg"] = "ثبت با موفقیت انجام شد";
            return RedirectToAction("listvertify");
        }
       
       public IActionResult del(int id)
       {
            var q = db.tbl_Pages.Where(a => a.Id == id).FirstOrDefault();
            db.tbl_Pages.Remove(q);
            db.SaveChanges();
            return RedirectToAction("listvertify");
       }
       
        
    }

