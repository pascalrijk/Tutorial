using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ihff.Models;

namespace ihff.Repositories
{
    public class DBActivityRepository : IActivityRepository
    {

        private DBContext db = new DBContext();

        public IEnumerable<Activity> getAll()
        {
            return db.Activities;
        }

        public Activity getById(int Id)
        {
            return db.Activities.FirstOrDefault(a => a.Id == Id);
        }


        public IEnumerable<Activity> findByName(string Name)
        {
            var activity = from a in db.Activities where a.Name.Contains(Name) select a;
            return activity;
        }
        
    }
}