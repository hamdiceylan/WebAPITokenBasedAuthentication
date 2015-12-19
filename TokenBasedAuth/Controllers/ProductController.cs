using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TokenBasedAuth.Controllers
{
    [Authorize]
    public class ProductController : ApiController
    {
        [HttpGet]
        public List<string> List()
        {
            List<string> products = new List<string>();

            products.Add("Product 1");
            products.Add("Product 2");
            products.Add("Product 3");
            products.Add("Product 4");
            products.Add("Product 5");

            return products;
        }
    }
}
