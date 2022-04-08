using DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Repositories
{
    public class UserRepository
    {
        public List<User> users = new List<User>()
        {
            new User (1, "login", "email", "pass", "phone")
        };
    }
}
