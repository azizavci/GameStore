using GameStore.Adapter.Concrete;
using GameStore.Business.Concrete;
using GameStore.Entities.Concrete;
using System;

namespace GameStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //NEW SUBSCRIBER
            Subscriber subscriber1 = new Subscriber
            {
                Id = 1,
                NationalityId = "46444942568",
                FirstName = "AZİZ",
                LastName = "AVCI",
                DateOfBirth = new DateTime(1994, 10, 10)
            };

            //NEW GAME
            Game game1 = new Game
            {
                Id = 1,
                GameName = "GOD OF WAR",
                GameKind = "EPIC",
                Price = 340
            };

            //NEW CAMPAIGN
            Campaign campaign1 = new Campaign
            {
                Id=1,
                CampaignName="BAHAR İNDİRİMİ",
                CampaignInformation="BAHAR AYLARI İÇİN KAÇINILMAZ FIRSATLAR",
                DiscountRate=35,
                StartingDate=new DateTime(2021,04,05),
                DueDate=new DateTime(2021,05,05)
            };

            SubscriberMernisAdapter mernisAdapter = new SubscriberMernisAdapter();


            //CRUD for SUBSCRIBER
            SubscriberManager subscriberManager = new SubscriberManager(mernisAdapter);
            subscriberManager.Add(subscriber1);
            subscriberManager.Delete(subscriber1);
            subscriberManager.Update(subscriber1);

            //CRUD for CAMPAIGN
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign1);
            campaignManager.Update(campaign1);

            //CRUD for GAME
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Delete(game1);
            gameManager.Update(game1);

            //OPERATIONS for SALES
            SalesManager salesManager = new SalesManager();
            salesManager.Sales(subscriber1,game1);
            salesManager.SalesWithCampaign(subscriber1,game1,campaign1);





            Console.ReadLine();
        }
    }
}
