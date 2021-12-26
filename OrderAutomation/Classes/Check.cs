
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderAutomation
{
    class Check:Payment
    {
        public string name { get; set; }
        public int bankID { get; set; }

        
        int confirm;
        public int authorized()
        {
            confirm = 1;
            return confirm;
        }

        public override void feePay(decimal price)
        {
            amount = price;
        }
    }
}
