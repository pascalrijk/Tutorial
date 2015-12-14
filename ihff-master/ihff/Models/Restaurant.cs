using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ihff.Models
{
    [Table("Restaurants")]
    public class Restaurant : Activity
    {

        public int Capacity { get; set; }

        public int LocationId { get; set; }
        public virtual Location Location { get; set; }

        //public Restaurant(String Name, String Description, String Type, float Price, int Capacity) : base(Name, Description, Type, Price)
        //{
        //    this.Capacity = Capacity;
        //}
    }
}