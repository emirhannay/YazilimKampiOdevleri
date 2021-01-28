using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5_Work5_Alternative
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete();
    }
}
