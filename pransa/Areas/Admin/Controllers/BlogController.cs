using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.AdminEntities.Blog;
using DataLayer.AdminEntities.Category;
using DataLayer.Context;
using pransa.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using ViewModels.AdminViewModel.Blog;
using ViewModels.AdminViewModel.Category;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace pransa.Areas.Admin.Controllers {
    [Area("Admin")]
    [Authorize]
   
    public class BlogController : BaseController {
       public BlogController(ContextHampadco _db,IWebHostEnvironment  env) :base(_db,env)
        {
        }
        public IActionResult Index () {

            //////////////////////////////////////////////////////////////////////////////////list
            var qlist = db.tbl_category.Where (a => a.FatherIdCat == -2 || a.FatherIdCat==-3).ToList ();
            var listtb = new List<Tb_Category> ();

            if (qlist != null) {
                foreach (var item in qlist) {
                    var qselect = db.tbl_category.Where (a => a.FatherIdCat == item.Id).ToList ();
                    if (qselect.Count() != 0) {
                        foreach (var item1 in qselect) {
                        var b = new Tb_Category () {
                        Id = item1.Id,
                        NameCat = item1.NameCat + "  " + "-->" + "  " + item.NameCat,
                        FatherIdCat = item1.FatherIdCat
                            };
                            listtb.Add (b);
                        }

                    } else {
                        listtb.Add (item);

                    }

                }
                ViewBag.list = new SelectList (listtb, "Id", "NameCat");
            } else {
                ViewBag.list = null;
            }

            //////////////////////////////////////////////////////////////////////////////////list
            if (err != null) {
                ViewBag.er = err;
                err = null;
            }

            return View ();
        }

        public IActionResult updateblog (int id) {
            //////////////////////////////////////////////////////////////////////////////////list
            var qlist = db.tbl_category.Where (a => a.FatherIdCat == -2 || a.FatherIdCat == -3).ToList ();
            var listtb = new List<Tb_Category> ();

            if (qlist != null) 
            {
                foreach (var item in qlist)
                {
                    var qselect = db.tbl_category.Where (a => a.FatherIdCat == item.Id).ToList ();
                    if (qselect.Count() != 0)
                     {
                        foreach (var item1 in qselect) 
                        {
                        var b = new Tb_Category () {
                        Id = item1.Id,
                        NameCat = item1.NameCat + "  " + "-->" + "  " + item.NameCat,
                        FatherIdCat = item1.FatherIdCat
                            };
                            listtb.Add (b);
                        }

                    }
                     else {
                        listtb.Add (item);

                    }

                }
                ViewBag.list = new SelectList (listtb, "Id", "NameCat");
            }
            else
             {
                ViewBag.list = null;
              }

            //////////////////////////////////////////////////////////////////////////////////list
            if (err != null) {
                ViewBag.er = err;
                err = null;
            }
            var qgallery = db.tbl_Galleryblogs.Where (a => a.IdProduct == id).ToList ();
            List<string> h=new List<string>();
            foreach (var item in qgallery)
            {

                h.Add(item.ImagePath);
            }
            ViewBag.img=h;

            if (id != null) {
                Vm_Blog qblog = new Vm_Blog ();
                var list = db.Tbl_Blog.Where (a => a.Id == id).FirstOrDefault ();
                qblog.Id = list.Id;
                qblog.TitleBLo = list.TitleBLo;
                qblog.Language = list.Language;
                qblog.IdCtegoryBlo = list.IdCtegoryBlo;
                qblog.SummaryBlo = list.SummaryBlo;
                qblog.ImageMainBlo = list.ImageMainBlo;
                qblog.FullTextBlo = list.FullTextBlo;
                qblog.KeywordsBlo = list.KeywordsBlo;

                return View (qblog);
            }

            


            return View ();

        }

        public IActionResult list () {
            //////////////////////////////////////////////////////////////////////////////////list
            if (err != null) {
                ViewBag.er = err;
                err = null;
            }
           
           ///
                 var d = db.Tbl_Blog.ToList ();
            if (d != null) {
                List<Vm_Blog> s = new List<Vm_Blog> ();
                foreach (var item in d) {
                    var q = db.Tbl_Blog.Where (a => a.Id == item.IdCtegoryBlo).FirstOrDefault ();
                  
                    var n = new Vm_Blog () {
                    Id = item.Id,
                    TitleBLo = item.TitleBLo,
                    Language = item.Language,
                    ImageMainBlo = item.ImageMainBlo,
                    // catname = q.NameCat
                    };
                    s.Add (n);

                }
                ViewBag.list = s.OrderByDescending (a => a.Id).ToList ();
            }else
            {
                 ViewBag.list=null;
            }

            return View ();
        }

        public async Task<IActionResult> add (Vm_Blog blog) {
            ///////////////upload file
            string FileExtension1 = Path.GetExtension (blog.file.FileName);
            NewFileName = String.Concat (Guid.NewGuid ().ToString (), FileExtension1);
            var path = $"{_env.WebRootPath}\\fileupload\\{NewFileName}";
            using (var stream = new FileStream (path, FileMode.Create)) {

                await blog.file.CopyToAsync (stream);

            }
            //////////////////////////end upload file 
            var b = new Tb_Blog () {
                Language = blog.Language,
                TitleBLo = blog.TitleBLo,
                IdCtegoryBlo = blog.IdCtegoryBlo,
                SummaryBlo = blog.SummaryBlo,
                ImageMainBlo = NewFileName,
                KeywordsBlo = blog.KeywordsBlo,
                FullTextBlo = blog.FullTextBlo,

            };
            db.Tbl_Blog.Add (b);
            db.SaveChanges ();
            var q = db.Tbl_Blog.OrderByDescending (a => a.Id).Take (1).FirstOrDefault ();
            ////////////////////////////////////////////////////////upload multi image
            if (blog.upload_imgs != null)
            {
                foreach (var item in blog.upload_imgs)
                {
                    ///////////////upload file
                    string FileExtension2 = Path.GetExtension (item.FileName);
                    NewFileName = String.Concat (Guid.NewGuid ().ToString (), FileExtension2);
                    var path2 = $"{_env.WebRootPath}\\fileupload\\{NewFileName}";
                    using (var stream = new FileStream (path2, FileMode.Create))
                    {
                        await item.CopyToAsync (stream);
                    }
                    Tbl_galleryblog g = new Tbl_galleryblog ()
                    {
                        Language = blog.Language,
                        ImagePath = NewFileName,
                        IdProduct = q.Id
                    };
                    db.tbl_Galleryblogs.Add(g);
                    db.SaveChanges();
                    //////////////////////////end upload file 
                }
            }
            err = "اطلاعات با موفقیت ثبت شد";

            return RedirectToAction ("index");
        }

        public async Task<IActionResult> update (Vm_Blog blog) {
            var qselect = db.Tbl_Blog.Where (a => a.Id == blog.Id).FirstOrDefault ();

            if (blog.upload_imgs != null)
            {
                var qgallery = db.tbl_Galleryblogs.Where(a => a.IdProduct == blog.Id).ToList();
                foreach (var item in qgallery)
                {
                    db.tbl_Galleryblogs.Remove(item);
                    db.SaveChanges();

                }

                ////////////////////////////////////////////////////////upload multi image

                foreach (var item in blog.upload_imgs)
                {
                    ///////////////upload file
                    string FileExtension1 = Path.GetExtension(item.FileName);
                    NewFileName = String.Concat(Guid.NewGuid().ToString(), FileExtension1);
                    var path = $"{_env.WebRootPath}\\fileupload\\{NewFileName}";
                    using (var stream = new FileStream(path, FileMode.Create))
                    {

                        await item.CopyToAsync(stream);

                    }
                    Tbl_galleryblog g = new Tbl_galleryblog()
                    {
                        Language = blog.Language,
                        ImagePath = NewFileName,
                        IdProduct = blog.Id
                    };
                    db.tbl_Galleryblogs.Add(g);
                    db.SaveChanges();

                    //////////////////////////end upload file 
                }



            }












            ///////////////upload file
            if (blog.file != null) {
                string FileExtension1 = Path.GetExtension (blog.file.FileName);
                NewFileName = String.Concat (Guid.NewGuid ().ToString (), FileExtension1);
                var path = $"{_env.WebRootPath}\\fileupload\\{NewFileName}";
                using (var stream = new FileStream (path, FileMode.Create)) {

                    await blog.file.CopyToAsync (stream);

                }
                ////////////////////////////////////////////
                if (qselect != null) {
                    qselect.TitleBLo = blog.TitleBLo;
                    qselect.IdCtegoryBlo = blog.IdCtegoryBlo;
                    qselect.Language = blog.Language;
                    qselect.SummaryBlo = blog.SummaryBlo;
                    qselect.ImageMainBlo = NewFileName;
                    qselect.FullTextBlo = blog.FullTextBlo;
                    qselect.KeywordsBlo = blog.KeywordsBlo;

                };
                db.Tbl_Blog.Update (qselect);
                db.SaveChanges ();
                err = "اطلاعات با موفقیت بروز رسانی شد";
                return RedirectToAction ("list");

            } else {
                ////////////////////////////////////////////
                if (qselect != null) {
                    qselect.TitleBLo = blog.TitleBLo;
                    qselect.IdCtegoryBlo = blog.IdCtegoryBlo;
                    qselect.Language = blog.Language;
                    qselect.SummaryBlo = blog.SummaryBlo;
                    qselect.FullTextBlo = blog.FullTextBlo;
                    qselect.KeywordsBlo = blog.KeywordsBlo;

                };
                db.Tbl_Blog.Update (qselect);
                db.SaveChanges ();
                err = "اطلاعات با موفقیت بروز رسانی شد";
                return RedirectToAction ("list");
            }

        }

        public IActionResult del (int id) {
            if (id != null) {
                var qselect = db.Tbl_Blog.Where (a => a.Id == id).FirstOrDefault ();
                db.Tbl_Blog.Remove (qselect);
                db.SaveChanges ();
                err = "رکورد مورد نظر با موفقیت حذف شد";
                return RedirectToAction ("list");

            }
            return RedirectToAction ("list");

        }

    }
}