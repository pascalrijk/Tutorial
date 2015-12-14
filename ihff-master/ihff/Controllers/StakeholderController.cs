using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ihff.Controllers
{
    public class StakeholderController : Controller
    {
        // GET: Stakeholder
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}