using System;
using System.Collections.Generic;
using System.Text;

namespace OrderAutomation
{
    class OrderDetail
    {   //BUNLARI METOTLARA ENTEGRE ETTTTTT
        public decimal quantity { get; set; }//kaç tane var
        public decimal taxStatus { get; set; }//vergi oranı
        public decimal tax { get; set; }
        public Item item { get; set; }

        
        public OrderDetail()
        {
            item = new Item();
            quantity = 0;
            taxStatus = 0;
            tax = 0;
            //System.Windows.Forms.MessageBox.Show("item.getpricequntity"+item.getPriceForQuantity()+"item.ıtemprice");
            //System.Windows.Forms.MessageBox.Show("item.getweight"+item.getWeight());
            //System.Windows.Forms.MessageBox.Show("item.kdv/100:"+item.ItemKdv/100);
        }
        public decimal calcSubTax()//HESAPLIYO
        {
            tax = item.getPriceForQuantity(/*item.UrunMiktari*/) * item.getWeight() /** quantity */* (item.ItemKdv / 100);
            return tax;
        }
        public decimal calcSubTotal()//HESAPLIYO
        {//Tane*Kg=ücreti
            decimal payable = 0;
             payable = (item.getPriceForQuantity(/*item.UrunMiktari*/)/* * quantity*/* item.getWeight());
           

           
             // System.Windows.Forms.MessageBox.Show("payable:"+payable+"tax:"+tax);
          //  payable -= tax;
            return payable-calcSubTax();//%10 vergi
        }
        public decimal calcWeight() //HESAPLIYO
        { 

            return item.getWeight();
        }
    }
}
