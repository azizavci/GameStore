using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Entities.Concrete
{
    public class Campaign
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public string CampaignInformation { get; set; }
        public double DiscountRate { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime DueDate { get; set; }

    }
}
