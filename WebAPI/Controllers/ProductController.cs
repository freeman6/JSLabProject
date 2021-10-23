using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WebAPI.Models;
using System.Web.Http.Cors;

namespace WebAPI.Controllers
{
    [EnableCors(origins:"*", headers:"*", methods: "*")]
    public class ProductController : ApiController
    {
        public List<Product> products = ProductHelper.Products;

        // GET api/values
        public IEnumerable<Product> Get()
        {
            return products;
        }

        // GET api/values/5
        public Product Get(int id)
        {
            return products.FirstOrDefault(x=>x.ID==id);
        }

        // POST api/values
        public Product Post([FromBody] Product item)
        {
            var result = new Product();
            if (products.Any(x => x.ID == item.ID))
                result = products.FirstOrDefault(x=>x.ID == item.ID);

            return result;
        }

        // DELETE api/values/5
        public List<Product> Delete(int id)
        {
            if (products.Any(x => x.ID == id))
            {
                var result = products.FirstOrDefault(x => x.ID == id);
                products.Remove(result);
            }
            return products;
        }

        // DELETE api/values
        public List<Product> Delete([FromBody]Product item)
        {
            if (products.Any(x => x.ID == item.ID))
            {
                var result = products.FirstOrDefault(x => x.ID == item.ID);
                products.Remove(products.FirstOrDefault(x => x.ID == item.ID));
            }
            return products;
        }
    }
}
