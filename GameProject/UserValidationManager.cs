﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==1985&&gamer.FirstName=="Sermin"&& gamer.LastName=="EH"&& gamer.IdentityNumber==124)
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
