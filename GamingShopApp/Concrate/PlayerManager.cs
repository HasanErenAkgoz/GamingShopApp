using GamingShopApp.Abstract;
using GamingShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamingShopApp.Concrate
{
    class PlayerManager : IPlayerService
    {
        IUserValidationService _userValidationService;

        public PlayerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(PlayerEntity player)
        {
            if (_userValidationService.Validate(player) == true)
            {
                Console.WriteLine("Added");
            }
            else
            {
                Console.WriteLine("Verification failed");
            }
        }

        public void Delete(PlayerEntity player)
        {
            Console.WriteLine("Registration Deleted");
        }

        public void Update(PlayerEntity player)
        {
            Console.WriteLine("Registry Updated");
        }
    }
}
