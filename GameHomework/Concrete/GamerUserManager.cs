using GameHomework.Abstract;
using GameHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework
{
    public class GamerUserManager : BaseUserManager
    {
        List<User> gamerList = new List<User>();
        IUserValidationService _userValidationService;
        public bool kayitBasariliMi = false;

        public GamerUserManager(IUserValidationService userValidationService)
        {
            this._userValidationService = userValidationService;
        }

        public override void Add(User gamer)
        {
  
            if (_userValidationService.Validate(gamer))
            {
                gamerList.Add(gamer);
                Console.WriteLine(gamer.FirstName + " kayıt oldu");
                kayitBasariliMi = true;
            }
            else { 
                Console.WriteLine("\n Doğrulama başarısız.Geçersiz kimlik no. ");
                kayitBasariliMi = false;
            }

        }


        public override void List()
        {
            Console.WriteLine("");
            Console.WriteLine(" ------ OYUNCU LİSTESi ------ ");
            foreach (var gamerItem in gamerList)
                Console.WriteLine(gamerItem.FirstName + " " + gamerItem.LastName);

        }

    }
}
