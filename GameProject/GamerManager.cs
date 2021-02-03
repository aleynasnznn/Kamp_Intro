using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidService userValidService;

        public GamerManager(IUserValidService userValidService)
        {
            this.userValidService = userValidService;
        }

        public void Add(Gamer gamer)
        {
            if(userValidService.Validate(gamer)==true)
            Console.WriteLine("Registered,you can continue");
            else
                Console.WriteLine("Failed");
        }

        public void Delete(Gamer gamer)
        {
            if (userValidService.Validate(gamer) == true)
                Console.WriteLine("Your registration has been deleted");
            else
                Console.WriteLine("Failed");
            
        }

        public void Update(Gamer gamer)
        {
            if (userValidService.Validate(gamer) == true)
                Console.WriteLine("Your profile has been updated");
            else
                Console.WriteLine("Failed");

            
        }
    }
}
