using GameStore.Business.Abstract;
using GameStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Business.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Sales(Subscriber subscriber, Game game)
        {
            Console.WriteLine("ÜRÜN FİYATI : " + game.Price);
            Console.WriteLine(subscriber.FirstName
                + " " + subscriber.LastName.ToUpper() + " isimli kullanıcı " + game.GameName + " ürününü satın aldı!");

            Console.WriteLine("----------------------------------------------------------");
        }

        public void SalesWithCampaign(Subscriber subscriber, Game game, Campaign campaign)
        {
            double gamePrice = game.Price - ((game.Price * campaign.DiscountRate) / 100);

            Console.WriteLine("İNDİRİMLİ ÜRÜN FİYATI : " + gamePrice);

            Console.WriteLine(subscriber.FirstName
                + " " + subscriber.LastName.ToUpper() + " isimli kullanıcı "
                + game.GameName + " ürününü " + campaign.CampaignName + " kampanyası dahilinde"
                + " %" + campaign.DiscountRate + " oranında indirimli aldı!");

            Console.WriteLine("----------------------------------------------------------");
        }
    }
}
