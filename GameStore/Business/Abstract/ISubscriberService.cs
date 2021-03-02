using GameStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Business.Abstract
{
    public interface ISubscriberService
    {
        //CRUD
        void Add(Subscriber subscriber);
        void Delete(Subscriber subscriber);
        void Update(Subscriber subscriber);
    
    }
}
