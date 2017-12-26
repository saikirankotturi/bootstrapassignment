using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class productsController : Controller
    {
        // GET: products



        public ActionResult products()
        {


            return View();
        }


        public ActionResult laptop()
        {
            return View();
        }

        public ActionResult Tv()
        {
            return View();
        }

        public ActionResult microwave()
        {
            return View();
        }

        public ActionResult Mobile()
        {
            return View();
        }
    }
}