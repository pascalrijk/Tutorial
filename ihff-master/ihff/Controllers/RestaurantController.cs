using ihff.Models;
using ihff.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ihff.Controllers
{
    public class RestaurantController : Controller
    {
        IRestaurantRepository restaurantRepository = new DBRestaurantRepository();
        public ActionResult Index()
        {
            IEnumerable<Restaurant> restaurants = new List<Restaurant>();
            restaurants = restaurantRepository.getAll().ToList();
            return View(restaurants);
        }
    }
}