using ihff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ihff.Repositories
{
    public class DBRestaurantRepository : IRestaurantRepository
    {
        private DBContext db = new DBContext();
        public IEnumerable<Restaurant> getAll()
        {
            return db.Restaurants;
        }
    }
}