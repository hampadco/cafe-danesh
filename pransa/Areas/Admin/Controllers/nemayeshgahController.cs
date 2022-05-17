using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DataLayer.AdminEntities.Blog;
using DataLayer.AdminEntities.Category;
using DataLayer.Context;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using ViewModels.AdminViewModel.Blog;
using ViewModels.AdminViewModel.Calender;
using ViewModels.AdminViewModel.Category;
using pransa.Models;
using DataLayer.AdminEntities.Calender;
using Extensions;
using AutoMapper;

namespace pransa.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class nemayeshgahController : BaseController
    {
        public ContextHampadco Db { get; }
        public IWebHostEnvironment Env { get; }
        private readonly IMapper map;

        public nemayeshgahController(
            ContextHampadco _db,
            IWebHostEnvironment env,IMapper map
        ) :
            base(_db, env)
        {
            Db = _db;
            Env = env;
            this.map = map;
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
        public IActionResult index(int? id)
        {
            var qlist = db.tbl_Calenders.Where(a => a.Id==id).FirstOrDefault();
            var qmap = map.Map<MCalender>(qlist);
            //city
            var qcity = db.tb_Cities.OrderBy(a=>a.Id).ToList();
            ViewBag.City = new SelectList(qcity, "Name", "Name");
            //location
             var qnam = db.tb_Namayeshgahs.OrderBy(a=>a.Id).ToList();
            ViewBag.nam = new SelectList(qnam, "Name", "Name");

             //location
             var qtnam = db.tb_TNamayeshgahs.OrderBy(a=>a.Id).ToList();
            ViewBag.tnam = new SelectList(qtnam, "Name", "Name");
            return View(qmap);
        }

         public IActionResult update(int? id)
        {
            var qlist = db.tbl_Calenders.Where(a => a.Id==id).FirstOrDefault();
            var qmap = map.Map<MCalender>(qlist);
            return View(qmap);
        }

        [HttpPost]
           public async Task<IActionResult> update(MCalender calender)
        {
           
                
            var qlist = db.tbl_Calenders.Where(a => a.Id==calender.Id).FirstOrDefault();
            string Baner = qlist.Baner;

            ///list
                qlist.Title=calender.Title;
                qlist.Years=calender.Years;
                qlist.Month=calender.Month;
                qlist.StartingDay=calender.StartingDay;
                qlist.EndDay=calender.EndDay;
                qlist.City=calender.City;
                qlist.DataReceive=calender.DataReceive.ToGeorgianDateTime();
                qlist.DateDestruction=calender.DateDestruction.ToGeorgianDateTime();
                qlist.TimeReceive=calender.TimeReceive;
                qlist.TimeDestruction=calender.TimeDestruction;
                qlist.executing=calender.executing;
                qlist.Tel1=calender.Tel1;
                qlist.Tel2=calender.Tel2;
                qlist.Supervisor=calender.Supervisor;
                qlist.SupervisorTel=calender.SupervisorTel;
                qlist.WebSite=calender.WebSite;
                qlist.Location=calender.Location;
           
             if (calender.Banerf != null)
             {
               Baner = await UplodeFile(calender.Banerf);
             }

            qlist.Baner = Baner;

            db.tbl_Calenders.Update(qlist);
            db.SaveChanges();
            TempData["msg"] = "ثبت با موفقیت انجام شد";
            return RedirectToAction("list");
        }
        
        
        
        [HttpPost]
        public async Task<IActionResult> index(MCalender calender)
        {
            string Baner = null;
            if (calender.Banerf != null)
                Baner = await UplodeFile(calender.Banerf);

            Tbl_Calender vs = new Tbl_Calender {

                Title=calender.Title,
                Years=calender.Years,
                Month=calender.Month,
                StartingDay=calender.StartingDay,
                EndDay=calender.EndDay,
                City=calender.City,
                Baner=Baner,
                DataReceive=calender.DataReceive.ToGeorgianDateTime(),
                DateDestruction=calender.DateDestruction.ToGeorgianDateTime(),
                TimeReceive=calender.TimeReceive,
                TimeDestruction=calender.TimeDestruction,
                executing=calender.executing,
                Tel1=calender.Tel1,
                Tel2=calender.Tel2,
                Supervisor=calender.Supervisor,
                SupervisorTel=calender.SupervisorTel,
                WebSite=calender.WebSite,
                Location=calender.Location
             };

            db.tbl_Calenders.Add(vs);
            db.SaveChanges();
            TempData["msg"] = "ثبت با موفقیت انجام شد";
            return RedirectToAction("list");
        }
        

        public IActionResult list()
        {
            var qlist = db.tbl_Calenders.OrderByDescending(a => a.Id).ToList();
            var qmap = map.Map<List<MCalender>>(qlist);
            return View(qmap);
        }

        public IActionResult del(int id)
        {
            var qlist = db.tbl_Calenders.Where(a => a.Id==id).FirstOrDefault();
            db.tbl_Calenders.Remove(qlist);
            db.SaveChanges();
            return RedirectToAction("list");

            
        }
        
        
    }
}
