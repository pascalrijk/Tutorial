using ihff.Models;
using ihff.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ihff.Controllers
{
    public class ActivityController : Controller
    {        
        // GET: Activity
        IShowRepository showRepository = new DBShowRepository();
        public ActionResult Index(string sortOrder)
        {
            //ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "day_desc" : "day_desc";
            if (sortOrder == null) { sortOrder = "day_desc"; }
            IEnumerable<Show> shows = new List<Show>();
            switch (sortOrder)
            {
                case "day_desc":
                    shows = showRepository.getAll().ToList();
                    shows = shows.OrderBy(s => ((int)s.Day+4)%7);
                    break;
                case "wednesday":
                    DayOfWeek day = DayOfWeek.Wednesday;
                    shows = showRepository.getByDay(day).ToList();
                    break;
                case "thursday":
                    day = DayOfWeek.Thursday;
                    shows = showRepository.getByDay(day).ToList();
                    break;
                case "friday":
                    day = DayOfWeek.Friday;
                    shows = showRepository.getByDay(day).ToList();
                    break;
                case "saturday":
                    day = DayOfWeek.Saturday;
                    shows = showRepository.getByDay(day).ToList();
                    break;
                case "sunday":
                    day = DayOfWeek.Sunday;
                    shows = showRepository.getByDay(day).ToList();
                    break;
                case "location":
                    shows = showRepository.getAll().ToList();
                    shows = shows.OrderBy(s => s.Location.Name).ToList();                    
                    break;
                case "philharmoniehaarlem":
                    shows = showRepository.getByLocationName("Philharmonie Haarlem").ToList();                   
                    break;
                case "toneelschuur":
                    shows = showRepository.getByLocationName("Toneelschuur").ToList();
                    break;
                case "patronaat":
                    shows = showRepository.getByLocationName("Patronaat").ToList();
                    break;
                case "pathe":
                    shows = showRepository.getByLocationName("Pathe").ToList();
                    break;
            }
            return View(shows);
        }

        public ActionResult Activity(int id)
        {
            Show show = showRepository.getById(id);
            return View(show);
        }
        
       
    }
}