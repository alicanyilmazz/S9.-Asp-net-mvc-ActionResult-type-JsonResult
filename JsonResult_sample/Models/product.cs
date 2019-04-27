using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonResult_sample.Models
{
    public class product
    {
        public int product_ID { get; set; }
        public string product_name { get; set; }
        public decimal product_price { get; set; }
        public string product_explanation { get; set; }
    }
}