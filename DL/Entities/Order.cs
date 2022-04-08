using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Entities
{
    internal class Order
    {
        [Key]
        private Guid OrderId { get; set; }

        [Required]
        private decimal Price { get; set; }

        public DateTime Date { get; set; }

        User User;

        List<Product> products;

        public void OrderCreate (Guid UserId)
        {
            Console.WriteLine(UserId.ToString(), Date, Price, products, OrderId);
        }
    }
}
