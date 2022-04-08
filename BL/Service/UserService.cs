using BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL.Repositories;

namespace BL.Service
{
    public class UserService : IUserService
    {
        UserRepository userRep = new UserRepository();
        public void PhoneChange(string newPhone, int userId)
        {
            foreach (var user in userRep.users)
            {
                if (user.UserId == userId)
                {
                    user.Phone = newPhone;
                }
            }
        }
    }
}
