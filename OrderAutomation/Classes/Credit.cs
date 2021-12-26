using System;
using System.Collections.Generic;
using System.Text;

namespace OrderAutomation
{
    class Credit : Payment
    {
        public decimal number { get; set; }
        public string type { get; set; }
        public DateTime expDate { get; set; }
        int confirm = 0;

       
        public override void feePay(decimal price)
        {
            amount = price;    
        }
        public int authorized()
        {
            confirm = 1;
            return confirm;
        }

    }
}
