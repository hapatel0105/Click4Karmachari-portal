﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Click4Karmachari_portal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Details()
            {
                ViewBag.Message = "Your Detail page.";

                return View();
            }
        public ActionResult Login()
        {
            ViewBag.Message = "Your Detail page.";

            return View();
        }
        public ActionResult Project_task()
        {
            ViewBag.Message = "Your Detail page.";

            return View();
        }
        public ActionResult Daily_task()
        {
            ViewBag.Message = "Your Detail page.";

            return View();
        }
        public ActionResult Voucher()
        {
            ViewBag.Message = "Your Detail page.";

            return View();
        }
        public ActionResult Voucher_req()
        {
            ViewBag.Message = "Your Detail page.";

            return View();
        }
        public ActionResult Resignation()
        {
            ViewBag.Message = "Your Detail page.";

            return View();
        }
        public ActionResult Statement()
        {
            ViewBag.Message = "Your Detail page.";

            return View();
        }
        public ActionResult Assets()
        {
            ViewBag.Message = "Your Detail page.";

            return View();
        }
        public ActionResult leaves()
        {
            ViewBag.Message = "Your Detail page.";

            return View();
        }
        public ActionResult Document()
        {
            ViewBag.Message = "Your Detail page.";

            return View();
        }
        public ActionResult Salary()
        {
            ViewBag.Message = "Your Detail page.";

            return View();
        }
    }
}