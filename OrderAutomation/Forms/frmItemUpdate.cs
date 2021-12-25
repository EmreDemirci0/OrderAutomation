using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace OrderAutomation.Forms
{
    public partial class frmItemUpdate : Form
    {
        private Order order { get; set; }
        public string[] ItemBilgileriTxt { get; set; }
        public frmItemUpdate()
        {
            InitializeComponent();
            ItemBilgileriTxt = System.IO.File.ReadAllLines(Application.StartupPath + "\\ItemBilgileri.txt");
            order = new Order();
        }
        private void frmItemUpdate_Load(object sender, EventArgs e)
        {
            cmb_itemUpdate.Text = "Bir İtem adı Seç";
            cmb_itemUpdate.Items.Clear();

            for (int i = 0; i < ItemBilgileriTxt.Length; i += 5)
            {
                cmb_itemUpdate.Items.Add(ItemBilgileriTxt[i]);
                VisibleTxtLabel(false);
            }
            if (cmb_itemUpdate.Items.Count==0)
            {
                this.Show();
                MessageBox.Show("Şuanda Hiç Ürün Yok.Lütfen Ürün Ekleyiniz...");
                this.Close();
            }

        }
        private void cmb_itemUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ItemBilgileriTxt.Length; i++)
            {
                //  MessageBox.Show("verilerial[i]:"+VerileriAl[i]);
                if (ItemBilgileriTxt[i] == cmb_itemUpdate.Text)
                {
                    txt_itemName.Text = ItemBilgileriTxt[i];
                    txt_itemPrice.Text = ItemBilgileriTxt[i + 1];
                    txt_stockAmount.Text = ItemBilgileriTxt[i + 2];
                    txt_shippingWeight.Text = ItemBilgileriTxt[i + 3];
                    txt_itemKdv.Text = ItemBilgileriTxt[i + 4];
                }
            }
            VisibleTxtLabel(true);
        }
        private void btn_updateItem_Click(object sender, EventArgs e)
        {
            if (cmb_itemUpdate.SelectedIndex==-1)
            {
                MessageBox.Show("Lütfen Ürün Seçiniz...");
            }
            else if (txt_itemName.Text == "" || txt_itemPrice.Text == "" || txt_shippingWeight.Text == "" || txt_stockAmount.Text == "" || txt_itemKdv.Text == "")
            {
                MessageBox.Show("Lütfen Boş olan Kısımları Dolduruuz");
            }
            else
            {
                for (int i = 0; i < ItemBilgileriTxt.Length; i++)
                {
                    if (ItemBilgileriTxt[i] == cmb_itemUpdate.Text)
                    {
                        File_DeleteLine(i + 1);
                        File_DeleteLine(i + 1);
                        File_DeleteLine(i + 1);
                        File_DeleteLine(i + 1);
                        File_DeleteLine(i + 1);
                    }
                }
                OrderDetail orderDetail = new OrderDetail();
                ordEkle(orderDetail, txt_itemName.Text, Convert.ToDecimal(txt_itemPrice.Text), Convert.ToInt32(txt_stockAmount.Text), Convert.ToDecimal(txt_shippingWeight.Text), Convert.ToDecimal(txt_itemKdv.Text));
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
                MessageBox.Show("Ürün Güncellendi...");
            }
        }
        private void VisibleTxtLabel(bool TF)
        {
            txt_itemKdv.Visible = TF;
            txt_itemName.Visible = TF;
            txt_itemPrice.Visible = TF;
            txt_stockAmount.Visible = TF;
            txt_shippingWeight.Visible = TF;
            label2.Visible = TF;
            label3.Visible = TF;
            label4.Visible = TF;
            label5.Visible = TF;
            label6.Visible = TF;

        }
        private void File_DeleteLine(int Line)
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader sr = new StreamReader(Application.StartupPath + "\\ItemBilgileri.txt"))
            {
                int Countup = 0;
                while (!sr.EndOfStream)
                {
                    Countup++;
                    if (Countup != Line)
                    {
                        using (StringWriter sw = new StringWriter(sb))
                        {
                            sw.WriteLine(sr.ReadLine());
                        }
                    }
                    else
                    {
                        sr.ReadLine();
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter(Application.StartupPath + "\\ItemBilgileri.txt"))
            {
                sw.Write(sb.ToString());
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
        private void txt_itemPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void txt_stockAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void txt_shippingWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void txt_itemKdv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
