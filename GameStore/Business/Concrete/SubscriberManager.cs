using GameStore.Adapter.Abstract;
using GameStore.Adapter.Concrete;
using GameStore.Business.Abstract;
using GameStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Business.Concrete
{
    public class SubscriberManager : ISubscriberService
    {
        ISubscriberCheckService _subscriberCheckService;

        public SubscriberManager(ISubscriberCheckService subscriberCheckService)
        {
            _subscriberCheckService = subscriberCheckService;
        }

        public void Add(Subscriber subscriber)
        {
            if (_subscriberCheckService.Verification(subscriber)==true)
            {
                Console.WriteLine(subscriber.FirstName+" "+subscriber.LastName+" "+"kişisi için kullanıcı kaydı oluşturuldu!");
            }
            else
            {
                Console.WriteLine("kimlik bilgisi doğrulanamadı");
            }
        }

        public void Delete(Subscriber subscriber)
        {
            if (_subscriberCheckService.Verification(subscriber) == true)
            {
                Console.WriteLine(subscriber.FirstName + " " + subscriber.LastName + " " + "kişisi için kullanıcı kaydı silindi!");
            }
            else
            {
                Console.WriteLine("kimlik bilgisi doğrulanamadı");
            }
        }

        public void Update(Subscriber subscriber)
        {
            if (_subscriberCheckService.Verification(subscriber) == true)
            {
                Console.WriteLine(subscriber.FirstName + " " + subscriber.LastName + " " + "kişisi için kullanıcı kaydı güncellendi!");
            }
            else
            {
                Console.WriteLine("kimlik bilgisi doğrulanamadı");
            }
        }
    }
}
