using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AffilateMarketingWeb.Models
{
    public class Product
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Discription { get; set; }
        public double Price { get; set; }
        public string ImagePath  { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }



    }
}