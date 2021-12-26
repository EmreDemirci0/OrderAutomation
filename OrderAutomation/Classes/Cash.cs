using System;
using System.Collections.Generic;
using System.Text;

namespace OrderAutomation
{
    class Cash:Payment
    {
      
        public override void feePay(decimal price)
        {
            amount = price;
        }
    }
}
