using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
using System.Linq;
using System.Web;

namespace ihff.Models {
	
	[Table("Rooms")]	
	public class Room {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		
		// The name of the room e.g. Zaal 1
		public string Name { get; set; }
		
		// Where is this room located?
        public int LocationId { get; set; }
		public virtual Location Location { get; set; }

        public int Capacity { get; set; }
	}
	
}