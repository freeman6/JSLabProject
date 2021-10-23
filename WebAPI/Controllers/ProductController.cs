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
        public static List<Product> products = ProductHelper.Products;

        // GET api/values
        public List<Product> Get()
        {
            return products;
        }

        // GET api/values/5
        public Product Get(int id)
        {
            return products.FirstOrDefault(x=>x.ID==id);
        }

        // POST api/values
        public List<Product> Post([FromBody] Product product)
        {
            if (products.Any(x => x.ID == product.ID))
            {
                var Item = products.FirstOrDefault(x => x.ID == product.ID);
                Item.Name = product.Name;
                Item.Price = product.Price;
                Item.Memo = product.Memo;
            }
            else
            {
                products.Add(product);
            }

            return products;
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
                products.Remove(result);
            }
            return products;
        }
    }
}
