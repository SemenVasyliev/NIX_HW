using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Entities
{
    internal class Available
    {
        Product product;
        private bool IsAvailable(Product product)
        {
            if (product.Available == 1)
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
