using System;
using System.Collections.Generic;
using System.Text;

namespace OrderAutomation
{
    class Credit : Payment
    {
        public decimal number { get; set; }
        public string type { get; set; }
        public DateTime expDate { get; set; }//SonKullanmaTarihi
        int confirm = 0;

        //public override decimal amount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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
