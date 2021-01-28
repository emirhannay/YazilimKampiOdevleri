using Day_5_Work5_Alternative.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5_Work5_Alternative.Entities
{
    interface IProductService
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
