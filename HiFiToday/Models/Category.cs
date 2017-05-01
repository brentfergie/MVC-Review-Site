using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;


namespace HiFiToday.Models
{
    public class Category
    {   //Properties for category section.  Foreign key to reviews

        public int ID { get; set; }
        [DisplayName("Category")]
        public string Name { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}