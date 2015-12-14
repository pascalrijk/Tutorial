using ihff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ihff.Repositories
{
    interface IShowRepository
    {
        IEnumerable<Show> getAll();
        Show getById(int id);
        IEnumerable<Show> getByDay(DayOfWeek day);
        IEnumerable<Show> getByLocationName(string location);
    }
}
