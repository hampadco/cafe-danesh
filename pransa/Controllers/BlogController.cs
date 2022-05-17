using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.AdminEntities.Blog;
using DataLayer.Context;
using pransa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModels.AdminViewModel.Blog;
using ViewModels.AdminViewModel.Comment;
using pransa.Models;
using Extensions;
using Microsoft.AspNetCore.Hosting;
using AutoMapper;
using pransa.Controllers;


namespace pransa.Controllers
{

    public class BlogController : BaseController
    {
        private readonly IMapper map;

        ////////////////////////////////////////////////////type db

        public BlogController(ContextHampadco _db, IWebHostEnvironment env, IMapper map) : base(_db, env)
        {
            this.map = map;
        }
        //////////////////////////////////////////////////////////
        public IActionResult Index(int id)
        {



            /////////////////////////////////////////////////////////////////////////////////////////////////////blog
            setdata();
            if (id != null)
            {
                ViewBag.blog = db.Tbl_Blog.Where(a => a.IdCtegoryBlo == id).OrderByDescending(a => a.IdCtegoryBlo == id).ToList();


            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////
            return View();
        }

        public IActionResult details(int id)
        {
            setdata();

            var qgallery = db.tbl_Galleryblogs.Where(a => a.IdProduct == id).ToList();
            List<string> h = new List<string>();
            foreach (var item in qgallery)
            {

                h.Add(item.ImagePath);
            }
            ViewBag.qimg = h;

            var result = db.Tbl_Blog.Where(a => a.Id == id).FirstOrDefault();
            var rmap = map.Map<Vm_Blog>(result);

            /////////////////////////////////////////////////////////////////////////////////////////////////////// 

            return View(rmap);
        }

        public IActionResult category(int id)
        {
            var listblog = db.Tbl_Blog.Where(a => a.IdCtegoryBlo == id).OrderByDescending(a => a.Id).ToList();
            var result = map.Map<List<Vm_Blog>>(listblog);
            return View(result);
        }


    }
}