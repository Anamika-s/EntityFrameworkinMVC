using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EFinMVC.Models
{
    [Table("Batch")]
    public class Batch
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Batch Code is must")]
         [StringLength(4, ErrorMessage ="Max characters are 4")]
         [MinLength(4, ErrorMessage ="Min 4 characters are needed")]
        public string BatchCode { get; set; }
        [Required(ErrorMessage ="Course Name is must")]

        public string Course { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage ="Start date is must")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage ="No of Students in batch is must")]
        [Range(10,15, ErrorMessage ="Students could be from 10 to 15")]
        public int Count { get; set; }

    }
}