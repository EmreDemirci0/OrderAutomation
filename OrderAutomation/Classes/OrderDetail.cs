using System;
using System.Collections.Generic;
using System.Text;

namespace OrderAutomation
{
    class OrderDetail
    {   
        public decimal quantity { get; set; }
        public decimal taxStatus { get; set; }
        public decimal tax { get; set; }
        public Item item { get; set; }

        
        public OrderDetail()
        {
            item = new Item();
            quantity = 0;
            taxStatus = 0;
            tax = 0;
           
        }
        public decimal calcSubTax()
        {
            tax = item.getPriceForQuantity() * item.getWeight() * (item.ItemKdv / 100);
            return tax;
        }
        public decimal calcSubTotal()
        {
            decimal payable = 0;
             payable = (item.getPriceForQuantity()* item.getWeight());
           

           
          
            return payable-calcSubTax();
        }
        public decimal calcWeight() 
        { 

            return item.getWeight();
        }
    }
}
