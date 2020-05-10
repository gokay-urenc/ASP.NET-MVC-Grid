using MVC_28_Grid_Kavrami.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_28_Grid_Kavrami.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UrunleriListele()
        {
            NORTHWND db = new NORTHWND();
            return View(db.Products.ToList());
        }
    }
}