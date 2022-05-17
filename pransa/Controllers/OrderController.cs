using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pransa.Models;
using pransa.Controllers;
//using pransa.Models;

namespace pransa.Controllers
{

    public class OrderController : BaseController
    {
        public static string msg;
        public OrderController(ContextHampadco _db, IWebHostEnvironment env) : base(_db, env)
        {
        }

        public IActionResult Index()
        {
            HttpContext.Session.SetString("order", "order");

            ViewBag.list = ShowList();
            return View();
        }

        //add cart
        public IActionResult addcart(int id)
        {
            //add
            String a = HttpContext.Session.GetString("shop");

            if (a != null)
            {
                HttpContext.Session.SetString("shop", a + id.ToString() + ",");
            }
            else
            {
                HttpContext.Session.SetString("shop", id.ToString() + ",");
            }

            //count

            ShowList();

            return RedirectToAction("index", new { id = id });
        }
        //min vart
        public IActionResult mincart(int id)
        {

            String[] listshop = (HttpContext.Session.GetString("shop")).Split(",");
            if (listshop != null)
            {
                int check = 0;
                HttpContext.Session.Remove("shop");
                foreach (var item in listshop)
                {
                    string a = HttpContext.Session.GetString("shop");

                    if (item == id.ToString() && check == 0)
                    {
                        check++;
                    }
                    else
                    {
                        if (a != null)
                        {
                            HttpContext.Session.SetString("shop", a + item + ",");
                        }
                        else
                        {
                            HttpContext.Session.SetString("shop", item + ",");
                        }
                    }
                }
            }

            //count

            ShowList();

            return RedirectToAction("index", new { id = id });
        }
        public IActionResult Pardakht()
        {
            return View();
        }

    }
}