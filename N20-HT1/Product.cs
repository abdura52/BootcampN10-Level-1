﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N20_HT1
{
    internal class Product
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public Product(string name, int price) => (Name, Price) = (name, price);
        //test test
    }
}
