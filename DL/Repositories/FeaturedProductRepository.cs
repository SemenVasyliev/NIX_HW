using DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Repositories
{
    public class FeaturedProductRepository
    {
        public List<FeaturedProduct> featuredProducts = new List<FeaturedProduct>()
        {
            new FeaturedProduct(1, 2),
            new FeaturedProduct(2, 3)
        };
    }
}
