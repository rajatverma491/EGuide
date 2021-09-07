using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AffilateMarketingWeb.Models;

namespace AffilateMarketingWeb.ViewModel
{
    public class AllClassViewModel
    {
        public Product Product { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public Category Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
       
    }
}