using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ihff.Models
{
    [Table("Wishlists")]
    public class Wishlist
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Code { get; set; }

        // The e-mail address to which this list bound
        [Display(Name = "E-mail address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        // Items currently in the wishlist
        public virtual ICollection<WishlistItem> Items { get; set; }

    }
}