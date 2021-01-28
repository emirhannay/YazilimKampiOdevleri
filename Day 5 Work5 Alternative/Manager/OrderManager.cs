using Day_5_Work5_Alternative.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5_Work5_Alternative
{
    class OrderManager : IOrderService
    {
  

        public void Add(Order order)
        {
            Console.WriteLine("Siparişiniz alındı...");
        }

       
        public void Delete(Order order)
        {
            Console.WriteLine("Siparişiniz silindi...");
        }

        public void Update(Order order)
        {
            Console.WriteLine("Siparişiniz güncellendi...");
        }
    }
}
