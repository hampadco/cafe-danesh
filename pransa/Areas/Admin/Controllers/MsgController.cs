﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pransa.Models;
using DataLayer.Context;
using ViewModels.AdminViewModel.Users;

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using DataLayer.AdminEntities.Message;
using ViewModels.AdminViewModel.Message;
using pransa.Models;
using Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace pransa.Areas.Admin.Controllers
{
   
    [Area("Admin")]
    [Authorize]
       public class MsgController : BaseController
    {
        ////////////////////////////////////////////////////type db
      public MsgController(ContextHampadco _db,IWebHostEnvironment  env) :base(_db,env)
        {
        }
        //////////////////////////////////////////////////////////


        public IActionResult Index()
        {
             ///////////////////////////////////////////////////////////////////////////logo & titel
            var logo=db.Tbl_Logo.Where(a=>a.Language==ln).FirstOrDefault();
            if (logo != null)
            {
                  ViewBag.logo=logo.ImageLogo;
                  ViewBag.Title=logo.TitleLogo;
                 
            }else
            {
                ViewBag.logo=null;
                 ViewBag.Title=null;
            }
          ////////////////////////////////////////////////////////////////////////////////social network
           var social=db.Tbl_SocialNetwork.ToList();
            if (social != null)
            {
                  ViewBag.social=social;
                 
            }else
            {
                 ViewBag.social=null;
            }
          ////////////////////////////////////////////////////////////////////////////////////////////////
             ////////////////////////////////////////////////////////////////////////////////////////////////////menu
             var qmenu=db.tbl_category.ToList();
             if (qmenu != null)
             {
                 ViewBag.menu=qmenu;
             }




            /////////////////////////////////////////////////////////////////////////////////////////////////////eror message
            if (eror != null)
            {
                ViewBag.err=eror;
                eror=null;
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////count msg
             ViewBag.resiver=db.Tbl_Message.Where(a=>a.StateMess==false && a.SenderMess !="admin").Count();
              ViewBag.sender=db.Tbl_Message.Where(a=>a.StateMess==false && a.SenderMess=="admin").Count();



            ////////////////////////////////////////////////////////////////////////////////////////////////////end count msg

             var userlist=db.Tbl_User.OrderByDescending(a=>a.Id).ToList();
             ViewBag.list=new SelectList(userlist,"Id","UserNameUs");





            //////////////////////////////////////////////////////////////////////////////
             var quser=db.Tbl_Message.Where(a=>a.ResiverMess== "admin" ).ToList();
             List<Vm_Message> qlist=new List<Vm_Message>();
             foreach (var item in quser)
             {
                 var q=db.Tbl_User.Where(a =>a.Id==Convert.ToInt32(item.SenderMess)  ).FirstOrDefault();
                 Vm_Message us =new Vm_Message()
             {
                 Id=item.Id,
                 SubjectMess=item.SubjectMess,
                 TextMess=item.TextMess,
                 pathfile=item.pathfile,
                 DateMess=item.DateMess.ToPersianDateString(), 
                 StateMess=item.StateMess,  
                 namesender=q.UserNameUs             
                 
             };
             qlist.Add(us);
             }
             
             ViewBag.msg=qlist.OrderByDescending(a=>a.Id).ToList();
            return View();
        }
        


        public async Task<IActionResult> add_msg(Vm_Message msg)
        {
             ///////////////////////////////////////////////////////////////////////////////////////////////////////////count msg
               ViewBag.resiver=db.Tbl_Message.Where(a=>a.StateMess==false && a.SenderMess !="admin").Count();
              ViewBag.sender=db.Tbl_Message.Where(a=>a.StateMess==false && a.SenderMess=="admin").Count();



            ////////////////////////////////////////////////////////////////////////////////////////////////////end count msg
            if (msg.file != null)
            {
                 ///////////////upload file
                string FileExtension1 = Path.GetExtension(msg.file.FileName);
                NewFileName = String.Concat(Guid.NewGuid().ToString(), FileExtension1);
                var path = $"{_env.WebRootPath}\\fileupload\\{NewFileName}";
                using (var stream = new FileStream(path, FileMode.Create))
                {

                    await msg.file.CopyToAsync(stream);



                }
                Tb_Message message=new Tb_Message()
                {
                    SenderMess="admin",
                    ResiverMess=msg.ResiverMess,
                    DateMess=DateTime.Today,
                    SubjectMess=msg.SubjectMess,
                    TextMess=msg.TextMess,
                    StateMess=false,
                    Language="fa",
                    pathfile=NewFileName


                };
                db.Tbl_Message.Add(message);
                db.SaveChanges();
                eror="پیام با موفقیت ارسال شد";
                //////////////////////////end upload file 

            }else
            {
                Tb_Message message=new Tb_Message()
                {
                    SenderMess="admin",
                    ResiverMess=msg.ResiverMess,
                    DateMess=DateTime.Today,
                    SubjectMess=msg.SubjectMess,
                    TextMess=msg.TextMess,
                    StateMess=false,
                    Language="fa",
                   


                };
                db.Tbl_Message.Add(message);
                db.SaveChanges();
                eror="پیام با موفقیت ارسال شد";
            }
            return RedirectToAction("index");
        }
    

         public IActionResult Details(int id)
         {
              ///////////////////////////////////////////////////////////////////////////////////////////////////////////count msg
              ViewBag.resiver=db.Tbl_Message.Where(a=>a.StateMess==false && a.SenderMess !="admin").Count();
              ViewBag.sender=db.Tbl_Message.Where(a=>a.StateMess==false && a.SenderMess=="admin").Count();


              var userlist=db.Tbl_User.OrderByDescending(a=>a.Id).ToList();
             ViewBag.list=new SelectList(userlist,"Id","UserNameUs");
            ////////////////////////////////////////////////////////////////////////////////////////////////////end count msg
               ///////////////////////////////////////////////////////////////////////////logo & titel
            var logo=db.Tbl_Logo.Where(a=>a.Language==ln).FirstOrDefault();
            if (logo != null)
            {
                  ViewBag.logo=logo.ImageLogo;
                  ViewBag.Title=logo.TitleLogo;
                 
            }else
            {
                ViewBag.logo=null;
                 ViewBag.Title=null;
            }
          ////////////////////////////////////////////////////////////////////////////////social network
           var social=db.Tbl_SocialNetwork.ToList();
            if (social != null)
            {
                  ViewBag.social=social;
                 
            }else
            {
                 ViewBag.social=null;
            }
          ////////////////////////////////////////////////////////////////////////////////////////////////
             ////////////////////////////////////////////////////////////////////////////////////////////////////menu
             var qmenu=db.tbl_category.ToList();
             if (qmenu != null)
             {
                 ViewBag.menu=qmenu;
             }




            /////////////////////////////////////////////////////////////////////////////////////////////////////eror message
            if (eror != null)
            {
                ViewBag.err=eror;
                eror=null;
            }
             var quser=db.Tbl_Message.Where(a=>a.Id==id ).ToList();
             List<Vm_Message> qlist=new List<Vm_Message>();
             foreach (var item in quser)
             {
                 Vm_Message us =new Vm_Message()
             {
                 Id=item.Id,
                 SubjectMess=item.SubjectMess,
                 TextMess=item.TextMess,
                 pathfile=item.pathfile,
                 DateMess=item.DateMess.ToPersianDateString(), 
                 StateMess=item.StateMess,               
                 
             };
             qlist.Add(us);
             }
             
             ViewBag.msg=qlist.OrderByDescending(a=>a.Id).ToList();
             var q=db.Tbl_Message.Where(a=>a.Id==id ).FirstOrDefault();
             q.StateMess=true;
             db.Tbl_Message.Update(q);
             db.SaveChanges();
            return View();
           
         }
       
           public IActionResult Detailssnd(int id)
         {
              ///////////////////////////////////////////////////////////////////////////////////////////////////////////count msg
              ViewBag.resiver=db.Tbl_Message.Where(a=>a.StateMess==false && a.SenderMess !="admin").Count();
              ViewBag.sender=db.Tbl_Message.Where(a=>a.StateMess==false && a.SenderMess=="admin").Count();
                var userlist=db.Tbl_User.OrderByDescending(a=>a.Id).ToList();
             ViewBag.list=new SelectList(userlist,"Id","UserNameUs");


            ////////////////////////////////////////////////////////////////////////////////////////////////////end count msg
               ///////////////////////////////////////////////////////////////////////////logo & titel
            var logo=db.Tbl_Logo.Where(a=>a.Language==ln).FirstOrDefault();
            if (logo != null)
            {
                  ViewBag.logo=logo.ImageLogo;
                  ViewBag.Title=logo.TitleLogo;
                 
            }else
            {
                ViewBag.logo=null;
                 ViewBag.Title=null;
            }
          ////////////////////////////////////////////////////////////////////////////////social network
           var social=db.Tbl_SocialNetwork.ToList();
            if (social != null)
            {
                  ViewBag.social=social;
                 
            }else
            {
                 ViewBag.social=null;
            }
          ////////////////////////////////////////////////////////////////////////////////////////////////
             ////////////////////////////////////////////////////////////////////////////////////////////////////menu
             var qmenu=db.tbl_category.ToList();
             if (qmenu != null)
             {
                 ViewBag.menu=qmenu;
             }




            /////////////////////////////////////////////////////////////////////////////////////////////////////eror message
            if (eror != null)
            {
                ViewBag.err=eror;
                eror=null;
            }
             var quser=db.Tbl_Message.Where(a=>a.Id==id ).ToList();
             List<Vm_Message> qlist=new List<Vm_Message>();
             foreach (var item in quser)
             {
                 Vm_Message us =new Vm_Message()
             {
                 Id=item.Id,
                 SubjectMess=item.SubjectMess,
                 TextMess=item.TextMess,
                 pathfile=item.pathfile,
                 DateMess=item.DateMess.ToPersianDateString(), 
                 StateMess=item.StateMess,               
                 
             };
             qlist.Add(us);
             }
             
             ViewBag.msg=qlist.OrderByDescending(a=>a.Id).ToList();
             
            return View();
           
         }
       
         
         public IActionResult del(int id)
         {

             var qselect=db.Tbl_Message.Where(a=>a.Id==id).FirstOrDefault();
             db.Tbl_Message.Remove(qselect);
             db.SaveChanges();
              eror="پیام با موفقیت حذف شد";
             return RedirectToAction("index");

         }




   public IActionResult send()
        {
             ///////////////////////////////////////////////////////////////////////////////////////////////////////////count msg
              ViewBag.resiver=db.Tbl_Message.Where(a=>a.StateMess==false && a.SenderMess !="admin").Count();
              ViewBag.sender=db.Tbl_Message.Where(a=>a.StateMess==false && a.SenderMess=="admin").Count();
                var userlist=db.Tbl_User.OrderByDescending(a=>a.Id).ToList();
             ViewBag.list=new SelectList(userlist,"Id","UserNameUs");

            ////////////////////////////////////////////////////////////////////////////////////////////////////end count msg
             ///////////////////////////////////////////////////////////////////////////logo & titel
            var logo=db.Tbl_Logo.Where(a=>a.Language==ln).FirstOrDefault();
            if (logo != null)
            {
                  ViewBag.logo=logo.ImageLogo;
                  ViewBag.Title=logo.TitleLogo;
                 
            }else
            {
                ViewBag.logo=null;
                 ViewBag.Title=null;
            }
          ////////////////////////////////////////////////////////////////////////////////social network
           var social=db.Tbl_SocialNetwork.ToList();
            if (social != null)
            {
                  ViewBag.social=social;
                 
            }else
            {
                 ViewBag.social=null;
            }
          ////////////////////////////////////////////////////////////////////////////////////////////////
             ////////////////////////////////////////////////////////////////////////////////////////////////////menu
             var qmenu=db.tbl_category.ToList();
             if (qmenu != null)
             {
                 ViewBag.menu=qmenu;
             }




            /////////////////////////////////////////////////////////////////////////////////////////////////////eror message
            if (eror != null)
            {
                ViewBag.err=eror;
                eror=null;
            }
             var quser=db.Tbl_Message.Where(a=>a.SenderMess== "admin").ToList();
             
             List<Vm_Message> qlist=new List<Vm_Message>();
             foreach (var item in quser)
             {
                 var q=db.Tbl_User.Where(a=>a.Id== Convert.ToInt32(item.ResiverMess)).FirstOrDefault();
                 Vm_Message us =new Vm_Message()
             {
                 Id=item.Id,
                 SubjectMess=item.SubjectMess,
                 TextMess=item.TextMess,
                 pathfile=item.pathfile,
                 DateMess=item.DateMess.ToPersianDateString(), 
                 StateMess=item.StateMess, 
                 namesender=q.UserNameUs           
                 
             };
             qlist.Add(us);
             }
             
             ViewBag.msg=qlist.OrderByDescending(a=>a.Id).ToList();
            return View();
        }
        







    }
}
