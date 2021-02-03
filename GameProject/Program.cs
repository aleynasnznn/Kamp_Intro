using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer {FirstName = "ALEYNA",
                                        BirthDay = 1998 ,
                                        Id =1,
                                        NationalNumber = 123456
            });

        }
    }
}
