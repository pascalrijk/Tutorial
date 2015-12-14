using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ihff.Models
{
    [Table("Shows")]
    public class Show
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ActivityId { get; set; }
        public virtual Activity Activity { get; set; }

        public int LocationId { get; set; }
        public virtual Location Location { get; set; }

        [Column("Day")]
        public DayOfWeek Day { get; set; }

        [Column("Start")]
        public TimeSpan Start { get; set; }

        [Column("End")]
        public TimeSpan End { get; set; }

        public int RoomId { get; set; }
        public virtual Room Room { get; set; }

    
    }
}