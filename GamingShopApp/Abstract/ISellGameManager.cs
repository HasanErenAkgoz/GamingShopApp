using GamingShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamingShopApp.Abstract
{
    interface ISellGameManager
    {
        void Sell (GameEntity game, PlayerEntity player);

    }
}
