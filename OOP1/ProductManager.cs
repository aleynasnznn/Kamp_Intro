using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine("Added to cart" + product.ProductName);
        }
        public void Update(Product product)
        {
            Console.WriteLine("Updated product is :" + product.ProductName);
        }
        


    }
}
