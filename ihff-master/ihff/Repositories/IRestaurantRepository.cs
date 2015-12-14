using ihff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ihff.Repositories
{
    interface IRestaurantRepository
    {
        IEnumerable<Restaurant> getAll();
    }
}
