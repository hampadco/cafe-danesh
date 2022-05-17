﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DataLayer.Context;
using pransa.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModels.AdminViewModel.Users;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace pransa.Areas.Admin.Controllers {

    [Area("Admin")]
    [Authorize]
    public class ProfileController : BaseController {
        ////////////////////////////////////////////////////type db
        public ProfileController (ContextHampadco _db, IWebHostEnvironment env) : base (_db, env) { }
        //////////////////////////////////////////////////////////

        public IActionResult Index () {
            

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////count msg
            menu.resiver = db.Tbl_Message.Where (a => a.StateMess == false && a.SenderMess != "admin").Count ();
            menu.sender = db.Tbl_Message.Where (a => a.StateMess == false && a.SenderMess == "admin").Count ();
            var user = db.Tbl_User.Where (a => a.UserNameUs == "admin").FirstOrDefault ();
            if (user != null) {
                menu.img = user.ProfileImageUs;
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////eror message
            if (eror != null) {
                ViewBag.err = eror;
                eror = null;
            }
            var quser = db.Tbl_User.Where (a => a.UserNameUs == "admin").FirstOrDefault ();
            Vm_User us = new Vm_User () {
                UserNameUs = quser.UserNameUs,
                PhoneUs = quser.PhoneUs,
                ProfileImageUs = quser.ProfileImageUs,
                PasswordUs = quser.PasswordUs,
                AddressUs = quser.AddressUs,
            };
            return View (us);
        }

        public async Task<IActionResult> add (Vm_User us) {


          




            if (us.img != null) {
                ///////////////upload file
                string FileExtension1 = Path.GetExtension (us.imgf.FileName);
                NewFileName = String.Concat (Guid.NewGuid ().ToString (), FileExtension1);
                var path = $"{_env.WebRootPath}\\fileupload\\{NewFileName}";
                using (var stream = new FileStream (path, FileMode.Create)) {

                    await us.imgf.CopyToAsync (stream);

                }
                //////////////////////////end upload file 
                var quser = db.Tbl_User.Where (a => a.UserNameUs == "admin").FirstOrDefault ();
                quser.PhoneUs = us.PhoneUs;
                quser.PasswordUs = us.PasswordUs;
                quser.AddressUs = us.AddressUs;
                quser.ProfileImageUs = NewFileName;
                quser.Language = "fa";
                db.Tbl_User.Update (quser);
                db.SaveChanges ();
                eror = "اطلاعات با موفقیت بروز رسانی شد.";
                return RedirectToAction ("index", "profile", new { Areas = "admin" });
            } else {

                var quser = db.Tbl_User.Where (a => a.UserNameUs == "admin").FirstOrDefault ();
                quser.PhoneUs = us.PhoneUs;
                quser.PasswordUs = us.PasswordUs;
                quser.Language = "fa";
                quser.AddressUs = us.AddressUs;
                db.Tbl_User.Update (quser);
                db.SaveChanges ();
                eror = "اطلاعات با موفقیت بروز رسانی شد.";
                return RedirectToAction ("index", "profile", new { Areas = "admin" });
            }
        }

    }
}