using ihff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ihff.Repositories
{

    public class DBShowRepository : IShowRepository
    {
        private DBContext db = new DBContext();
        public IEnumerable<Show> getAll()
        {
            return db.Shows;
        }
        public Show getById(int Id)
        {
            return db.Shows.FirstOrDefault(a => a.Id == Id);
        }
        public IEnumerable<Show> getByDay(DayOfWeek day)
        {
            IEnumerable<Show> shows = db.Shows;
            return shows.Where(x => x.Day == day);
        }
        public IEnumerable<Show> getByLocationName(string location)
        {
            IEnumerable<Show> shows = db.Shows;
            return shows.Where(x => x.Location.Name == location);
        }
    }
}
