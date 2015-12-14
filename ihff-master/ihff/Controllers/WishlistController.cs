using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ihff.Repositories;
using ihff.Models;

namespace ihff.Controllers
{
    public class WishlistController : Controller
    {
        private IWishlistRepository repository/* = new DBWishlistRepository()*/;

        // GET: Wishlist
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetWishlist(string code)
        {
            Wishlist activeWishlist = repository.findByCode(code);
            Session["loggedin_user"] = activeWishlist;
            return RedirectToAction("Index");
        }

        public ActionResult AddActivity()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteActivity()
        {
            return View();
        }

        public ActionResult EditActivity()
        {
            return View();
        }

        public ActionResult SaveWishlist()
        {
            return View();
        }

        public ActionResult DeleteWishlist()
        {
            return View();
        }
    }
}