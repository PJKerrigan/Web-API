// System
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
// Custom
using ProductsApp.Models;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] _Products = new Product[]
        {
            new Product { 
                Id          = 1, 
                Name        = "Tomato Soup", 
                Category    = "Groceries",
                Price       = 1.00M
            },
            new Product 
            { 
                Id          = 2, 
                Name        = "Mushroom Soup", 
                Category    = "Groceries", 
                Price       = 1.3M
            },
            new Product
            {
                Id          = 3,
                Name        = "Hammer",
                Category    = "Hardware",
                Price       = 11.75M
            },
            new Product
            {
                Id          = 4,
                Name        = "Yo-Yo",
                Category    = "Toys",
                Price       = 1.99M
            }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return _Products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = _Products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}