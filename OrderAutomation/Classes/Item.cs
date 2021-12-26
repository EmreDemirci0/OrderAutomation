using System;
using System.Collections.Generic;
using System.Text;

namespace OrderAutomation
{
    class Item
    {
        
        
        public decimal shippingWeight { get; set; }
        public string description { get; set; }
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal ItemKdv { get; set; }
        public int UrunMiktari { get; set; }
        public int StokMiktari { get; set; }
        
        public Item()
        {
            shippingWeight = 0;
            description = "";
            ItemName = "";
            ItemPrice = 0;
            ItemKdv = 0;
            StokMiktari = 0;
        }
        public decimal getWeight()
        {  
            return shippingWeight;
        }
        public decimal getPriceForQuantity()
        {
            
            return ItemPrice;
        }
        
    }
}
