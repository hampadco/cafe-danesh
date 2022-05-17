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
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using DataLayer.AdminEntities;
using Kavenegar;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

using ViewModels.AdminViewModel.GalleryProduct;

namespace pransa.Controllers
{
    
    public class categoryController :BaseController
    {
        
           ////////////////////////////////////////////type db
        public categoryController(ContextHampadco _db,IWebHostEnvironment env):base(_db,env)
        {
            
        }
         
         
       

        public IActionResult index(int id)
        {
            ViewBag.list = ShowList();
            ViewBag.B=db.Tbl_Product.Where (a =>Convert.ToInt32(a.CategoryIdPro)==id  && a.TypeCarPro=="1").ToList();

           
            return View();
        }

       
        public IActionResult Discount(int page)
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
            var Discount=db.Tbl_Product.Where(a=>a.MaterialPro=="تخفیف" && a.TypeCarPro=="1").OrderByDescending (a => a.Id).Skip(skip*12).Take(12).ToList();
                decimal count1 = db.Tbl_Product.Where(a=>a.MaterialPro=="تخفیف" && a.TypeCarPro=="1").Count();
                decimal sdd=count1/12;
                var countpage=Math.Ceiling(sdd);   
                ViewBag.Discount = Discount;
                ViewBag.countpage=Convert.ToInt16(countpage);      
            return View();
        }
       
        
      public IActionResult best(int page )
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
            var best=db.Tbl_Product.Where(a=>a.MaterialPro=="پرفروش" && a.TypeCarPro=="1").OrderByDescending (a => a.Id).Skip(skip*12).Take(12).ToList();
                decimal count1 = db.Tbl_Product.Where(a=>a.MaterialPro=="پرفروش" && a.TypeCarPro=="1").Count();
                decimal sdd=count1/12;
                var countpage=Math.Ceiling(sdd);   
                ViewBag.best = best;
                ViewBag.countpage=Convert.ToInt16(countpage);
            return View();
        }
        public IActionResult highlight(int page )
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
            var highlight=db.Tbl_Product.Where(a=>a.MaterialPro=="برجسته" && a.TypeCarPro=="1").OrderByDescending (a => a.Id).Skip(skip*12).Take(12).ToList();
                decimal count1 = db.Tbl_Product.Where(a=>a.MaterialPro=="برجسته" && a.TypeCarPro=="1").Count();
                decimal sdd=count1/12;
                var countpage=Math.Ceiling(sdd);   
                ViewBag.highlight = highlight;
                ViewBag.countpage=Convert.ToInt16(countpage);
            return View();
        }
        public IActionResult newpro(int page)
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
            var newpro=db.Tbl_Product.Where(a=>a.MaterialPro=="جدیدترین" && a.TypeCarPro=="1").OrderByDescending (a => a.Id).Skip(skip*12).Take(12).ToList();
                decimal count1 = db.Tbl_Product.Where(a=>a.MaterialPro=="جدیدترین" && a.TypeCarPro=="1").Count();
                decimal sdd=count1/12;
                var countpage=Math.Ceiling(sdd);   
                ViewBag.newpro = newpro;
                ViewBag.countpage=Convert.ToInt16(countpage);
            return View();
        }
        public IActionResult shegeft(int page)
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
            var shegeft=db.Tbl_Product.Where(a=>a.MaterialPro=="پیشنهادشگفت انگیز" && a.TypeCarPro=="1").OrderByDescending (a => a.Id).Skip(skip*12).Take(12).ToList();
                decimal count1 = db.Tbl_Product.Where(a=>a.MaterialPro=="پیشنهادشگفت انگیز" && a.TypeCarPro=="1").Count();
                decimal sdd=count1/12;
                var countpage=Math.Ceiling(sdd);   
                ViewBag.shegeft = shegeft;
                ViewBag.countpage=Convert.ToInt16(countpage);
            return View();
        }
        public IActionResult pishnahad(int page)
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
            var pishnahad=db.Tbl_Product.Where(a=>a.MaterialPro=="پیشنهادما" && a.TypeCarPro=="1").OrderByDescending (a => a.Id).Skip(skip*12).Take(12).ToList();
                decimal count1 = db.Tbl_Product.Where(a=>a.MaterialPro=="پیشنهادما" && a.TypeCarPro=="1").Count();
                decimal sdd=count1/12;
                var countpage=Math.Ceiling(sdd);   
                ViewBag.pishnahad = pishnahad;
                ViewBag.countpage=Convert.ToInt16(countpage);
            return View();
        }
        public IActionResult lahzeh(int page)
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
            var lahzeh=db.Tbl_Product.Where(a=>a.MaterialPro=="پیشنهادلحظه ای" && a.TypeCarPro=="1").OrderByDescending (a => a.Id).Skip(skip*12).Take(12).ToList();
                decimal count1 = db.Tbl_Product.Where(a=>a.MaterialPro=="پیشنهادلحظه ای" && a.TypeCarPro=="1").Count();
                decimal sdd=count1/12;
                var countpage=Math.Ceiling(sdd);   
                ViewBag.lahzeh = lahzeh;
                ViewBag.countpage=Convert.ToInt16(countpage);
            return View();
        }
        
    }
}