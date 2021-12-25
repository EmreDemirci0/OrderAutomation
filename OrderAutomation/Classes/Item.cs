using System;
using System.Collections.Generic;
using System.Text;

namespace OrderAutomation
{
    class Item
    {
        
        
        public decimal shippingWeight { get; set; }//kargo ağırlığı
        public string description { get; set; }//açıklama
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
        public decimal getWeight()//ağırlık al
        {  
            return shippingWeight/**ItemKdv*/;
        }
        public decimal getPriceForQuantity()//Adet için fiyatr al
        {
            //price = 10;//tanesi 10tl
            return /*quantitiy**/ItemPrice;
        }
        
    }
}
