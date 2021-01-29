using GameHomework.Abstract;
using GameHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Concrete
{
    public class OrderManager : IOrderService
    {
        public void Order(User gamer,Game game,Campaign campaign)
        {
            double price = game.GamePrice - game.GamePrice * (campaign.CampaignPercentDiscount / 100);
            Console.WriteLine(gamer.FirstName +" " + gamer.LastName +" "+ game.GameName + " oyununu satın aldı. \n" +
                "İndrimli Oyun Fiyatı: " + price.ToString("n2") +"TL \n"+
                "Uygulanan Kampanya İndirimi: %" +campaign.CampaignPercentDiscount );
        }

    }
}
