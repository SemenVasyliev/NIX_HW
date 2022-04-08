using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Entities
{
    public class Product
    {
        public Product(int available, string name, int productId, string desc, decimal price)
        {
            Available = available;
            Name = name;
            ProductId = productId;
            Desc = desc;
            Price = price;
        }

        [Range (0,1)]
        public int Available { get; set; }
        public string Name { get; set; }
        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 50)]
        public string Desc { get; set; }

        public decimal Price { get; set; }

    }
}
