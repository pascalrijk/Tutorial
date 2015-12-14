using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ihff.Models
{
    [Table("Specials")]
    public class Special : Activity
    {
        public int SpeakerId { get; set; }
        public Speaker Speaker { get; set; }

        //public int ShowId { get; set; }
        //public Show Show { get; set; }

    }
}