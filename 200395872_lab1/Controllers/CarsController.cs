using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _200395872_lab1.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View(carView);
        }

        public ActionResult Content()
        {
            return View(carView);
        }
    }
}