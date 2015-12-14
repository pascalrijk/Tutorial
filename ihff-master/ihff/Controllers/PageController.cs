using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ihff.Models;
using ihff.Repositories;

namespace ihff.Controllers
{
    public class PageController : Controller
    {

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult FestivalInfo()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}