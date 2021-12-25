using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrderAutomation.Forms
{
    public partial class frmOrders : Form
    {
        public string[] CashTxt { get; set; }
        public string[] CreditTxt { get; set; }
        public string[] CheckTxt { get; set; }
        Customer customer;
        public frmOrders()
        {
            InitializeComponent();
            CashTxt = System.IO.File.ReadAllLines(Application.StartupPath + "\\Cash.txt");
            CreditTxt = System.IO.File.ReadAllLines(Application.StartupPath + "\\Credit.txt");
            CheckTxt = System.IO.File.ReadAllLines(Application.StartupPath + "\\Check.txt");
            customer = new Customer();
        }
        private void frmOrders_Load(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
        }
        private void btn_orderList_Click(object sender, EventArgs e)
        {
            lst_orderList.Items.Clear();
            decimal CashTotal = 0;
            decimal CreditTotal = 0;
            decimal CheckTotal = 0;
            if (CashTxt.Length == 0 && CreditTxt.Length == 0 && CheckTxt.Length == 0)
            {
                //MessageBox.Show("hiç ürün alınmadı:(");
                lst_orderList.Items.Add("hiç ürün alınmadı:(");
            }
            else
            {
                lst_orderList.Items.Add(customer.FirstName + " aşağıdaki Ürünleri Aldı. Adresi: " + customer.Adress);
                for (int i = 0; i < CashTxt.Length; i += 3)
                {
                    lst_orderList.Items.Add($"Nakit:{CashTxt[i]} İsimli Üründen {CashTxt[i + 1]} Adet {CashTxt[i + 2]}TL Karşılığında Alındı");
                    CashTotal += Convert.ToDecimal(CashTxt[i + 2]);
                }
                for (int i = 0; i < CreditTxt.Length; i += 6)
                {
                    lst_orderList.Items.Add($"Kart:{CreditTxt[i]} isimli üründen {CreditTxt[i + 1]} Adet  {CreditTxt[i + 2]}TL Karşılığında" +
                        $"Kart Numarası {CreditTxt[i + 3]} olan SKT {CreditTxt[i + 5]} olan {CreditTxt[i + 4]} kartından çekildi");
                    CreditTotal += Convert.ToDecimal(CreditTxt[i + 2]);
                }
                for (int i = 0; i < CheckTxt.Length; i += 5)
                {
                    lst_orderList.Items.Add($"Çek:{CheckTxt[i]} isimli üründen {CheckTxt[i + 1]} Adet Aldınız {CheckTxt[i + 2]}TL tutu karşılığında banka Adı:{CheckTxt[i + 3]} olan Kart Numarası {CheckTxt[i + 4]} olan karttan çekildi");
                    CheckTotal += Convert.ToDecimal(CheckTxt[i + 2]);
                }
                label2.Text = CashTotal.ToString();
                label4.Text = CreditTotal.ToString();
                label6.Text = CheckTotal.ToString();
                label8.Text = (CashTotal + CreditTotal + CheckTotal).ToString();
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
            }
        }
    }
}
