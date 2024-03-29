using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pransa.Models;
using DataLayer.Context;
using DataLayer.AdminEntities.Category;
using ViewModels.AdminViewModel.Category;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Hosting;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace pransa.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
      public class  CategoryController: BaseController
    {
       public CategoryController(ContextHampadco _db,IWebHostEnvironment  env) :base(_db,env)
        {
        }
        public IActionResult Index()
        {
            if (err != null)
            {
                ViewBag.er=err;
                err=null;
            }
            //////////////////////////////////////////////////////////////////////////////////select list
             var qlist=db.tbl_category.ToList();
           
             ViewBag.lselect= new SelectList(qlist, "Id", "NameCat");
           ////////////////////////////////////////////////////////////////////////////list view bag complete
            var qlistt=db.tbl_category.ToList();
           var tq=new List<Vm_Category>();
           foreach (var item in qlistt)
           {
            
               if (item.FatherIdCat==0)
               {
                   NewFileName="دسته اصلی ";
               }
              
               else
               {
                    var namefather=qlistt.Where(a=>a.Id== item.FatherIdCat).FirstOrDefault();
                    NewFileName=namefather.NameCat;
               }
              
               
               
                    var d=new Vm_Category()
               {
                   Id=item.Id,
                   NameCat=item.NameCat,
                   FatherIdCat=item.FatherIdCat,
                   fathername=NewFileName
               };
               tq.Add(d);
               
              
               
           }




             ViewBag.list=tq.OrderByDescending(a=>a.Id).ToList();

            //////////////////////////////////////////
           
          
            return View();
            
        }


        public IActionResult add(Vm_Category cat)
        {
           var qcat=db.tbl_category.Where(a=>a.NameCat==cat.NameCat && a.FatherIdCat==cat.FatherIdCat).FirstOrDefault();
           if (qcat != null)
           {
               err="این نام قبلا ثبت شده است";
           }
           else
           {
               var tbcat=new Tb_Category()
               {
                   Language=cat.Language,
                   NameCat=cat.NameCat,
                   FatherIdCat=cat.FatherIdCat
               };
               db.tbl_category.Add(tbcat);
               db.SaveChanges();
               suc="اطلاعات با موفقیت ثبت شد";

           }
           return RedirectToAction("index");
        }



        public IActionResult del(int id)
        {
            if (db.tbl_category.Any(a=>a.FatherIdCat==id) )
            {
                err="این رکورد شامل زیر مجموعه است ابتدا باید زیر مجموعه های آن را حذف کنید";
                return RedirectToAction("index");
            }
            // if (db.tbl_category.Any(a=>a.NameCat==id.ToString()))
            // {
                
            //     err1="پیغام";
            //     return RedirectToAction("index");
            // }
            if (db.Tbl_Product.Any(a =>a.CategoryChildIdPro==id.ToString()))
            {
                
               err="برای این دسته صفحه   ثبت شده ابتدا باید صفحه   رو حذف کنید";
                return RedirectToAction("index");

            }
            
            else
            {
                 var qcat=db.tbl_category.Where(a=>a.Id==id).FirstOrDefault();
             db.tbl_category.Remove(qcat);
             db.SaveChanges();
             suc="رکورد با موفقیت حذف شد";
            }
            
             return RedirectToAction("index");
        }

    }
}