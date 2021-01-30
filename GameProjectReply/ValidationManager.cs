using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectReply
{
    class ValidationManager : IValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirtYear==1995 && gamer.FirstName=="Utku" && gamer.LastName=="Mutlu" && gamer.IdentityNumber==112)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
