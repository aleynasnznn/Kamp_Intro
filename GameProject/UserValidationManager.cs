using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{   //like MERNIS
    class UserValidationManager : IUserValidService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "ALEYNA" && gamer.BirthDay == 1998 && gamer.Id == 1
                && gamer.NationalNumber == 123456)
                return true;
            else
                return false;

           
        }
    }
}
