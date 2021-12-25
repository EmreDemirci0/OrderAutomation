using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace OrderAutomation
{
    public partial class frmLoginSuccessfulPersonel : Form
    {
        Order order { get; set; }
        string[] ItemBilgileriTxt;
        public frmLoginSuccessfulPersonel()
        {
            InitializeComponent();
            ItemBilgileriTxt = System.IO.File.ReadAllLines(Application.StartupPath + "\\ItemBilgileri.txt");
            order = new Order();
        }
        private void frmLoginSuccessfulPersonel_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Lütfen Boş olan Kısımları Dolduruuz");
            }
            else
            {
                OrderDetail orderDetail = new OrderDetail();
                ordEkle(orderDetail, textBox1.Text, Convert.ToDecimal(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox5.Text));
                order.OrderDetailsAdd(orderDetail);

                using (StreamWriter writer = new StreamWriter("ItemBilgileri.txt", true))
                {
                    for (int i = order.orderDetails.Count - 1; i < order.orderDetails.Count; i++)
                    {
                        writer.WriteLine(order.orderDetails[i].item.ItemName);//D
                        writer.WriteLine(order.orderDetails[i].item.ItemPrice);//D
                        writer.WriteLine(order.orderDetails[i].item.StokMiktari);
                        writer.WriteLine(order.orderDetails[i].item.getWeight());
                        writer.WriteLine(order.orderDetails[i].item.ItemKdv);

                    }

                }
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear();

            }
            MessageBox.Show("Ürün Eklendi");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ItemBilgileriTxt = File.ReadAllLines(Application.StartupPath+"\\ItemBilgileri.txt");

            for (int i = 0; i < ItemBilgileriTxt.Length; i += 5)
            {
                listBox1.Items.Add($"{ItemBilgileriTxt[i]}\t{ItemBilgileriTxt[i + 1]}\t{ItemBilgileriTxt[i + 2]}\t{ItemBilgileriTxt[i + 3]}\t{ItemBilgileriTxt[i + 4]}");
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void ordEkle(OrderDetail o, string ItemName, decimal ItemPrice, int StokMiktari, decimal shippingWeight, decimal ItemKdv)
        {
            o.item.ItemName = ItemName;
            o.item.ItemPrice = ItemPrice;
            o.item.StokMiktari = StokMiktari;
            o.item.shippingWeight = shippingWeight;
            o.item.ItemKdv = ItemKdv;
            o.item.description = $"{ItemName} Ürününün fiyatı {ItemPrice}TL'dir.{StokMiktari} Adet stok vardır.Ürün{shippingWeight} gram'dır.%{ItemKdv} Vergi alınır. ";
        }
    }
}
