using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace WebApplication1_DZ3.Models
{
    public static class ActionLink
    {
        public static string currentLink { get; set; }
        public static string[] nameLink = { "Index", "ProductList", "ProductTable" }; // массив названий представлений
    }
}

