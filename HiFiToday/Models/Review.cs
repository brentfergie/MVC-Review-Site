using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace HiFiToday.Models
{
    public class Review
    {

        [Key]
        public int ID { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        [DisplayName("Review")]
        public string Description { get; set; }


        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}