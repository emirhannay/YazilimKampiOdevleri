using Day_5_Work5_Alternative.Concrete;
using Day_5_Work5_Alternative.Manager;
using System;

namespace Day_5_Work5_Alternative
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer()
            {
                BirthOfYear = "2002",
                Id = 1,
                FirstName = "EMİRHAN",
                LastName = "AY",
                TcNo = 1234567890,
            };

            Product product1 = new Product()
            {
                Id = 1,
                Name = "Dying Light",
                Price = 50,

            };
            Product product2 = new Product()
            {
                Id = 2,
                Name = "DayZ",
                Price = 30,
            };
            Order order1 = new Order()
            {
                Id = 1,
                OrderPrice = 50,
                ProductId = 1,
            };
            Campaign campaign1 = new Campaign()
            {
                Name = "Yılbaşı indirimi",
                Id = 1,
                DiscountRate = 10

            };

            OrderManager orderManager = new OrderManager();
            ProductManager productManager = new ProductManager();
            CampaignManager campaignManager = new CampaignManager();
            orderManager.Add(order1);
            orderManager.Delete(order1);
            orderManager.Update(order1);
            productManager.Update(product1);
            productManager.Add(product2);
            productManager.Delete(product1);
            campaignManager.Add(campaign1);
            campaignManager.ApplyDiscount(campaign1,order1);
            campaignManager.Delete(campaign1);

            Console.ReadLine();
            

            /*
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1);
            gamerManager.Delete();
            gamerManager.Update(gamer1);

            UserValidationManager userValidationManager = new UserValidationManager();
            userValidationManager.Validate(gamer1);
            */
        }
               
                
    }
}
