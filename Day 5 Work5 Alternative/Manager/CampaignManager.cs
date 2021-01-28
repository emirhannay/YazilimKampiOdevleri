using Day_5_Work5_Alternative.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5_Work5_Alternative.Manager
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign added...");
        }

        public void ApplyDiscount(Campaign campaign ,Order order)
        {
            Console.WriteLine(campaign.Name + " algılandı..." );
            Console.WriteLine(campaign.Name +" "+ order.Id+ " numaralı siparişinize uygulandı.");
            
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign deleted...");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign updated...");
        }
    }
}
