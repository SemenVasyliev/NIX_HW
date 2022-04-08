using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Минимальное кол-во символов 5, максимальное 20")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [EmailAddress(ErrorMessage = "Введён некоректный адрес")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Compare("Password", ErrorMessage = "Пароли не соответствует друг другу")]
        public string ConfirmPass { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Phone]
        public string Phone { get; set; }

        public void UserInfo ()
        {
            Console.WriteLine($"Логин: {Login}, Эл. Адрес: {Email}, Пароль: {Password}, Телефон: {Phone}");
        }

        List<Order> orders;

        public User(int userId, string login, string email, string password, string phone)
        {
            UserId = userId;
            Login = login;
            Email = email;
            Password = password;
            Phone = phone;
        }
    }
}
