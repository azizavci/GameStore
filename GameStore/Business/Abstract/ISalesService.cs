using GameStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Business.Abstract
{
    public interface ISalesService
    {
        void Sales(Subscriber subscriber, Game game);
        void SalesWithCampaign(Subscriber subscriber, Game game, Campaign campaign);

    }
}
