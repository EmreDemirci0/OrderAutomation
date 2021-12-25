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
            //orderDetails = new List<OrderDetail>();
            ItemTxt = File.ReadAllLines(Application.StartupPath + "\\ItemBilgileri.txt");

        }
   
        public void OrderDetailsAdd(OrderDetail o)
        {
            orderDetails.Add(o);
        }
        public decimal calcTax()//HESAPLIYO
        {
            decimal vergitutari = 0;
            
            for (int i = 0; i < orderDetails.Count; i++)
            {
                vergitutari += orderDetails[i].calcSubTax();
            }
        //    System.Windows.Forms.MessageBox.Show("orderdetails[0].tax"+orderDetails[0].tax);
            
            return vergitutari;
               
        }
        public decimal calcTotal()//HESAPLIYOR
        {
            decimal toplamTutar = 0;
            //foreach (OrderDetail a in orderDetails)
            //{
            //    toplamTutar += a.calcSubTotal();
            //}
            for (int i = 0; i < orderDetails.Count; i++)
            {
    
                toplamTutar += orderDetails[i].calcSubTotal();

            }
   System.Windows.Forms.MessageBox.Show("order details count"+orderDetails.Count.ToString()+"toplamTutar:"+toplamTutar);
            return toplamTutar;
        }
        //public string SiparisListele()
        //{
        //    string Metin = "";
        //    //foreach (OrderDetail a in orderDetails)
        //    //{
        //    //    Metin += "adi" + a.item.ItemName + "price:" + a.item.ItemPrice;
        //    //}
        //    for (int i = 0; i < orderDetails.Count; i++)
        //    {
        //        Metin += "adı: " + orderDetails[i].item.ItemName + " price: " + orderDetails[i].item.ItemPrice+" \n";     
        //    }
            
        //    return Metin;
            
        //}
        public decimal calcTotalWeight()//HESAPLIYO
        {
            decimal toplamAgirlik=0;
            //foreach (OrderDetail a in orderDetails)
            //{
            //    toplamAgirlik += a.item.getWeight();
            //}
            for (int i = 0; i < orderDetails.Count; i++)
            {
                toplamAgirlik += orderDetails[i].item.getWeight();

            }
            return toplamAgirlik;
        }
    }
}
