using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1_DZ3.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string createdDate { get; set; }
    }
}