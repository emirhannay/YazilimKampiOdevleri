using Day_5_Work5_Alternative.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5_Work5_Alternative
{
    interface IOrderService
    {
        void Add(Order order);
        void Delete(Order order);
        void Update(Order order);

    }

}
