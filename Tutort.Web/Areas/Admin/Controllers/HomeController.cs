﻿using System.Web.Mvc;

namespace Tutort.Web.Areas.Admin.Controllers
{
	public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}