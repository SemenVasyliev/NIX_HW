using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Entities
{
    internal class Category
    {
        List<Product> products { get; set; }

        private string CategoryName { get; set; }

        internal double Size { get; set; }

        private string Color { get; set; }

      
    }
}
