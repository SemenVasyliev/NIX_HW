﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Entities
{
    internal class Trashbox
    {
        List<Product> featuredProducts { get; set; }
        public Guid UserId { get; set; }


    }
}
