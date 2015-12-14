using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ihff.Models
{
    [Table("Movies")]
    public class Movie : Activity
    {
        public int Year { get; set; }
        public int Runtime { get; set; } // minutes or seconds?
        public string Trailer { get; set; }

        public virtual ICollection<Show> Shows {get;set;}

        /*public Movie(String Name, String Description, String Type, float Price, int Runtime) : base(Name, Description, Type, Price)
        {
            this.Runtime = Runtime;
            this.Shows = new Collection<Show>();
        }*/
    }
}