using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1_DZ3.Models;

namespace WebApplication1_DZ3.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> products = new List<Product>();
            
            for(int i = 1; i <= 10; i++)
            {
                products.Add(new Product() 
                { 
                    id = i
                   ,name = $"Product {i}"
                   ,price = (i + 1) * 10
                   ,createdDate = GetDate() 
                });
            }

            return View(products);
        }
        public static string GetDate()
        {
            return DateTime.Now.ToString();
        }
        
        public ActionResult ProductTable()
        {
            return Index();
        }
        public ActionResult ProductList()
        {
            return Index();
        }
    }


}