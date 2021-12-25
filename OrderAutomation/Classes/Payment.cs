using System;
using System.Collections.Generic;
using System.Text;

namespace OrderAutomation
{
    abstract class Payment
    {
        public decimal  amount { get; set; }
        public abstract void feePay(decimal tutar);

    }
}
