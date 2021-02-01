using GamingShopApp.Entity;

namespace GamingShopApp.Abstract
{
    public interface ICampaignService
    {
        void Add(CampaingEntity campaign);
        void Update(CampaingEntity campaign);
        void Delete(CampaingEntity campaign);
    }
}
