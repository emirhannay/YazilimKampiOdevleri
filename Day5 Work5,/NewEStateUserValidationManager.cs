using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Work5_
{
    class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
