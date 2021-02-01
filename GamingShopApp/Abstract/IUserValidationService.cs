using GamingShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamingShopApp.Abstract
{
    interface IUserValidationService
    {
        bool Validate(PlayerEntity player);

    }
}
