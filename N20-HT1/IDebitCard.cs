﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N20_HT1
{
    internal interface IDebitCard
    {
        public string CardNumber { get; set; }
        public string BankName { get; init; }
        public double Balance { get; set; }
    }
}
