using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace GameProject
{
    class GamerManager :IGamerService
    {
         IUserValidationService _UserValidationManager;

         public GamerManager(IUserValidationService userValidationManager)
         {
             _UserValidationManager = userValidationManager;
         }

         public void add(Gamer gamer)
        {
            if (_UserValidationManager.Validate(gamer)==true)
            {
                Console.WriteLine("kayıt olundu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı güncellendi ");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("kullanıcı silindi");
        }
    }
}
