using System;
using System.Collections.Generic;
using System.Text;

namespace OrderAutomation
{
    class Cash:Payment
    {
       // public decimal cashTendered { get; set; }//ne kadarlık nakşit
        //public override decimal amount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        

        public override void feePay(decimal price)
        {
            amount = price;
        }
    }
}
