using GameStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Business.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}
