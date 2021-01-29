using GameHomework.Concrete;
using GameHomework.Entities;
using System;

namespace GameHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            // oyunlar
            Game game1 = new Game();
            game1.Id = 1;
            game1.GameName = "SEGA PC Football Manager 2021";
            game1.GameCategori = "Spor";
            game1.GamePrice = 249;
            game1.GameType = "PC Consol";
            game1.GameEAN = "5055277040483";
        
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(new Game { Id = 2, GameName = "ACTIVISION Call Of Duty Siyah OPS 4", GameCategori = "Spor", GamePrice = 299, GameType = "Oyun CD", GameEAN = "5030917257261" });


            //Kampanya Ekleme

            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.CampaignName = "Yılbaşı Kampanyası";
            campaign1.CampaignPercentDiscount = 40;
            campaign1.StartDate = new DateTime(2020, 12, 15);
            campaign1.EndDate = new DateTime(2021, 01, 01);

            Console.WriteLine("\n");

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(new Campaign
            {
                Id = 2,
                CampaignName = "14 Şubat Kampanyası",
                CampaignPercentDiscount = 25,
                StartDate = new DateTime(2021, 02, 08),
                EndDate = new DateTime(2021, 02, 15)
            });


            // oyuncu ekleme
            User gamer1 = new User();
            gamer1.Id = 1;
            gamer1.FirstName = "Ezgi";
            gamer1.LastName = "Mola";
            gamer1.BirthYear = 1980;
            gamer1.IdentitiyNumber = 45367557888521;

            GamerUserManager gamerManager = new GamerUserManager(new NewEStateUserValidationManager());
            gamerManager.Add(gamer1);
            gamerManager.Add(new User { Id = 2, FirstName = "Berkan", LastName = "Karabulut", BirthYear = 1987, IdentitiyNumber = 453675571908307 });

          
            // kayıt başarılı ise oyun satın al.
            if (gamerManager.kayitBasariliMi) {

                gamerManager.List();

                Console.WriteLine("\n SATILAN OYUNLAR ");
                OrderManager orderManager = new OrderManager();
                orderManager.Order(gamer1, game1, campaign1);
            }

          
            Console.Read();
        }
    }
}
