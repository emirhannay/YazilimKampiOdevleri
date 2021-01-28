using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5_Work5_Alternative
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if(_userValidationService.Validate(gamer)== true)
            { 
                Console.WriteLine("Kayıt olundu..."); 
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız");
                Console.WriteLine("Kayıt başarısız...");
                
            }
            
        }

        public void Delete()
        {
          
            Console.WriteLine("Kayıt silindi...");
        }

        public void Update(Gamer gamer)
        {
            if(_userValidationService.Validate(gamer) == true)
            { Console.WriteLine("Kayıt güncellendi..."); }
            else
            { Console.WriteLine("Doğrulama başarısız ... kayıt başarısız..." ); }
            
        }
    }
}
