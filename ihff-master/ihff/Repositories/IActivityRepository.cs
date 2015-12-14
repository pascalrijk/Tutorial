using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ihff.Models;

namespace ihff.Repositories
{
    interface IActivityRepository
    {
        // Return a collection of all activities
        IEnumerable<Activity> getAll();

        // Get an activity by its Id
        Activity getById(int Id);

        // Find an activity by its name
        IEnumerable<Activity> findByName(string Name);

    }
}
