using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Computer"},
                new Category{CategoryId=2,CategoryName="Phone"},
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Dell Laptop",QuantityPerUnit="32 GB RAM",UnitPrice=10000,UnitInStock=5},
                new Product{ProductId=2,CategoryId=1,ProductName="Asus Laptop",QuantityPerUnit="16 GB RAM",UnitPrice=10000,UnitInStock=3},
                new Product{ProductId=3,CategoryId=1,ProductName="Hp Laptop",QuantityPerUnit="8 GB RAM",UnitPrice=6000,UnitInStock=2},
                new Product{ProductId=4,CategoryId=2,ProductName="Samsung Phone",QuantityPerUnit="4 GB RAM",UnitPrice=5000,UnitInStock=15},
                new Product{ProductId=5,CategoryId=2,ProductName="Apple Phone",QuantityPerUnit="4 GB RAM",UnitPrice=8000,UnitInStock=0},
            };



            //products = GetProductsLinq(products);
            foreach (var item in products)
            {
                Console.WriteLine(item.ProductName);
            }

            //AnyMethod(products);

            //FindMethod(products);

            //FindAllMethod(products);

            //AscDesc(products);

            //ClassicLinqTest(products);

            var result=from p in products
                       join c in categories
                       on p.CategoryId equals c.CategoryId
            select new ProductDto { ProductId = p.ProductId, CategoryName=c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };
            foreach (var productDto in result)
            {
                Console.WriteLine("{0}---{1}",productDto.ProductName,productDto.CategoryName);
            }
        }

        private static void ClassicLinqTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 6000
                         orderby p.UnitPrice descending, p.ProductName ascending
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            foreach (var p in result)
            {
                Console.WriteLine(p.ProductName);
            }
        }



        // Difference between LINQ and standard algorithm..

        static List<Product> GetProductsStandard(List<Product> products)
        {
            List<Product> filtredProduct = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000&& product.UnitInStock>3)
                {
                    filtredProduct.Add(product);
                }
            }
            return filtredProduct;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            //where=foreach
            return products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3).ToList();
        }

        static void AnyMethod(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Asus Laptop");
            Console.WriteLine(result); //return bool
        }

        private static void FindMethod(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName);
        }

        private static void FindAllMethod(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top"));
            Console.WriteLine(result);
        }

        private static void AscDesc(List<Product> products)
        {   
            //SingleLineQuery
            var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice).ThenBy(p => p.ProductName);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName); //same as FindAll method
            }
        }

    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }

    }

    class ProductDto //DataTransferObject
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
