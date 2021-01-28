using Day_5_Work5_Alternative.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5_Work5_Alternative
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
        void ApplyDiscount(Campaign campaign, Order order);
        
    }
}
