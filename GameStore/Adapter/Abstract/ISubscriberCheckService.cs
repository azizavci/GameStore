using GameStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Adapter.Abstract
{
    public interface ISubscriberCheckService
    {
        bool Verification(Subscriber subscriber);
    }
}
