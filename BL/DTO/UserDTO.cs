using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTO
{
    internal class UserDTO
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string ConfirmPassword { get; set; }
        public string Adress { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
    }
}
