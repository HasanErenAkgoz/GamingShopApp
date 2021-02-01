using GamingShopApp.Abstract;
using GamingShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamingShopApp.Concrate
{
    class CampaignManager : ICampaignService
    {
        public void Add(CampaingEntity campaign)
        {
            Console.WriteLine(campaign.CampaignName + " : Added");
        }

        public void Delete(CampaingEntity campaign)
        {
            Console.WriteLine(campaign.CampaignName + " : Deleted");
        }

        public void Update(CampaingEntity campaign)
        {
            Console.WriteLine(campaign.CampaignName + " : Updated");
            
        }
    }
}
