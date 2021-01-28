using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5_Work5_Alternative
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "EMİRHAN" && gamer.LastName == "AY" && gamer.TcNo == 1234567890 && gamer.BirthOfYear == "2001")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
