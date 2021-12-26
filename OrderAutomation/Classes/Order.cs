using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace OrderAutomation
{
    class Order
    {
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public List<OrderDetail> orderDetails= new List<OrderDetail>();
        string[] ItemTxt;
        public Order()
        {
           
            ItemTxt = File.ReadAllLines(Application.StartupPath + "\\ItemBilgileri.txt");

        }
   
        public void OrderDetailsAdd(OrderDetail o)
        {
            orderDetails.Add(o);
        }
        public decimal calcTax()
        {
            decimal vergitutari = 0;
            
            for (int i = 0; i < orderDetails.Count; i++)
            {
                vergitutari += orderDetails[i].calcSubTax();
            }
     
            
            return vergitutari;
               
        }
        public decimal calcTotal()//HESAPLIYOR
        {
            decimal toplamTutar = 0;
           
            for (int i = 0; i < orderDetails.Count; i++)
            {
    
                toplamTutar += orderDetails[i].calcSubTotal();

            }
   System.Windows.Forms.MessageBox.Show("order details count"+orderDetails.Count.ToString()+"toplamTutar:"+toplamTutar);
            return toplamTutar;
        }
       
        public decimal calcTotalWeight()
        {
            decimal toplamAgirlik=0;
           
            for (int i = 0; i < orderDetails.Count; i++)
            {
                toplamAgirlik += orderDetails[i].item.getWeight();

            }
            return toplamAgirlik;
        }
    }
}
