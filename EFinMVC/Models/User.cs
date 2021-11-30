using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EFinMVC.Models
{
    public class User
    {
       
        public int Id { get; set; }
        [Required(ErrorMessage ="Username is must")]
        public string UserName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [NotMapped]
        [Compare("Password", ErrorMessage ="Password do not match")]
        public string ComparePassword { get; set; }
    }
}