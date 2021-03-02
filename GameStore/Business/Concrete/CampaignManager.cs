using GameStore.Business.Abstract;
using GameStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Business.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("KAMPANYA ID : "+campaign.Id);
            Console.WriteLine("KAMPANYA ADI : "+campaign.CampaignName);
            Console.WriteLine("KAMPANYA BİLGİSİ : "+ campaign.CampaignInformation);
            Console.WriteLine("İNDİRİM MİKTARI : %"+campaign.DiscountRate);
            Console.WriteLine("BAŞLANGIÇ TARİHİ : "+campaign.StartingDate);
            Console.WriteLine("BİTİŞ TARİHİ : "+campaign.DueDate);

            Console.WriteLine("KAMPANYA BİLGİSİ BAŞARIYLA EKLENDİ!");
            Console.WriteLine("----------------------------------------------------------");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("KAMPANYA ID : " + campaign.Id);
            Console.WriteLine("KAMPANYA ADI : " + campaign.CampaignName);
            Console.WriteLine("KAMPANYA BİLGİSİ : " + campaign.CampaignInformation);
            Console.WriteLine("İNDİRİM MİKTARI : %" + campaign.DiscountRate);
            Console.WriteLine("BAŞLANGIÇ TARİHİ : " + campaign.StartingDate);
            Console.WriteLine("BİTİŞ TARİHİ : " + campaign.DueDate);

            Console.WriteLine("KAMPANYA BİLGİSİ BAŞARIYLA SİLİNDİ!");
            Console.WriteLine("----------------------------------------------------------");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("KAMPANYA ID : " + campaign.Id);
            Console.WriteLine("KAMPANYA ADI : " + campaign.CampaignName);
            Console.WriteLine("KAMPANYA BİLGİSİ : " + campaign.CampaignInformation);
            Console.WriteLine("İNDİRİM MİKTARI : %" + campaign.DiscountRate);
            Console.WriteLine("BAŞLANGIÇ TARİHİ : " + campaign.StartingDate);
            Console.WriteLine("BİTİŞ TARİHİ : " + campaign.DueDate);

            Console.WriteLine("KAMPANYA BİLGİSİ BAŞARIYLA GÜNCELLENDİ!");
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}
