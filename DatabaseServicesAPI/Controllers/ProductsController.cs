using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DatabaseServicesAPI.Models;

namespace DatabaseServicesAPI.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Environment = "Non-Prod", Domain = "qcorpaa.aa.com"  },
            new Product { Id = 2, Environment = "Pre-Prod", Domain = "corpaa.aa.com" },
            new Product { Id = 3, Environment = "Prod", Domain = "corpaa.aa.com"  }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
