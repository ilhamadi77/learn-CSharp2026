using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutViewsExample.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products/Index
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int? id) 
        {

            var products = new[]
            {
                new {productId = 1, productName = "Iphone",cost = 8000000},
                 new {productId = 2, productName = "Samsung",cost = 7000000},
                  new {productId = 3, productName = "Xiomi",cost = 6000000}
            };
            if (id == null)
            {
                return Content("Please pass any product ID");
            }
            else
            {
                var nameProduct = "";
                foreach (var product in products)
                {
                    if (product.productId == id)
                    {
                        nameProduct = product.productName;
                    }
                }
            return Content(nameProduct);
            }

        }

        public ActionResult GetProductId(string productName)
        {
            var products = new[]
            {
                new {productId = 1, productName = "Iphone",cost = 8000000},
                new {productId = 2, productName = "Samsung",cost = 7000000},
                new {productId = 3, productName = "Xiomi",cost = 6000000}
            };

            if (productName == null)
            {
                return Content("Please pass any product Name");
            }
            else
            {
                var productdID = 0;
                foreach (var product in products)
                {
                    if (product.productName == productName)
                    {
                        productdID = product.productId;
                    }
                }
            return Content(productdID.ToString());
            }

        }
    }
}



