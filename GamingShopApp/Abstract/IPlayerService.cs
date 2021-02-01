using GamingShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamingShopApp.Abstract
{
    interface IPlayerService
    {
        void Add(PlayerEntity player);
        void Update(PlayerEntity player);
        void Delete(PlayerEntity player);
    }
}
