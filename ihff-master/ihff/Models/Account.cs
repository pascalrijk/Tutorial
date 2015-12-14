using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ihff.Models
{
    public class Account
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required(ErrorMessage = "An E-mail address is required!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        public string Password { get; set; }

        public Account(int id, string name, string emailAddress, string password)
        {
            this.Id = id;
            this.Name = name;
            this.Email = emailAddress;
            this.Password = password;
        }
    }
}