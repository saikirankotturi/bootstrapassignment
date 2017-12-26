using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class serviceController : Controller
    {
        // GET: service

        public ActionResult services()
        {
            return View();
        }
        public ActionResult laptopservice()
        {
            return View();
        }
        public ActionResult Tvservice()
        {
            return View();
        }

        public ActionResult Mobileservice()
        {
            return View();
        }

        public ActionResult microwaveservice()
        {
            return View();
        }
    }
}