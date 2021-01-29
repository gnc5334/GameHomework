using GameHomework.Abstract;
using GameHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            if ( user.BirthYear>0 && user.FirstName.Length>0 && user.LastName.Length>0 && user.IdentitiyNumber>0)
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
