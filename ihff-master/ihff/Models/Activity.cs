using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
using System.Linq;
using System.Web;

namespace ihff.Models
{
    /**
     * This is the base model from which all other Activities will extend
     */
    [Table("Activities")]
    public abstract class Activity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Column("Description")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Column("Image")]
        public string Image { get; set; }

        [Column("Price")]
        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        // Determines the type of activity e.g. Movie, Restaurant or Special
        // This type is used for the Factory to instantiate the right type
        // of activity class
        [Column("Type")]
        [Display(Name = "Activity type")]
        public string Type { get; set; }

        //public Activity(String Name, String Description, String Type, float Price)
        //{
        //    this.Name = Name;
        //    this.Description = Description;
        //    this.Type = Type;
        //    this.Price = Price;
        //}
    }
}