using Day_5_Work5_Alternative.Concrete;
using Day_5_Work5_Alternative.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5_Work5_Alternative.Manager
{
    class ProductManager : IProductService
    {
        public void Add(Product product)
        {
            Console.WriteLine("Product eklendi...");
        }

        public void Delete(Product product)
        {
            Console.WriteLine("Product silindi...");
        }

        public void Update(Product product)
        {
            Console.WriteLine("Product güncellendi...");
        }
    }
}
