using GamingShopApp.Abstract;
using GamingShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamingShopApp.Concrate
{
    class SellGameManager : ISellGameManager
    {
        private CampaignManager _campaignManager;

        public SellGameManager(CampaignManager campaignManager)
        {
            _campaignManager = campaignManager;
        }
        public void Sell(GameEntity game, PlayerEntity player)
        {
            Console.WriteLine(game.GameName + " : " + "Sold to " + player.FirstName);
        }
    }
}
