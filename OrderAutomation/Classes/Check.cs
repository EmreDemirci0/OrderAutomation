
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderAutomation
{
    class Check:Payment//Çek
    {
        public string name { get; set; }
        public int bankID { get; set; }

        //public override decimal amount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public override decimal amount
        //{
        //    get
        //    {
        //        return 1;
        //    }
        //    set
        //    {

        //    }
        //}
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
