using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Memo { get; set; }
    }

    public static class ProductHelper
    {
        public static List<Product> Products => new List<Product>
        {
            new Product { ID=1, Name="Product01", Price=100, Memo="Product01"},
            new Product { ID=2, Name="Product02", Price=200, Memo="Product02"},
            new Product { ID=3, Name="Product03", Price=300, Memo="Product03"},
            new Product { ID=4, Name="Product04", Price=400, Memo="Product04"},
        };
    }
}