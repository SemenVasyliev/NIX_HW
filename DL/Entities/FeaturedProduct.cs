using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Entities
{
    public class FeaturedProduct
    {
        public FeaturedProduct(int productId, int userId)
        {
            ProductId = productId;
            UserId = userId;
        }

        public int ProductId { get; set; }
        public int UserId { get; set; }
    }
}
