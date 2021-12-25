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
    public partial class frmPayment : Form
    {
       
        string[] purchased;
        string[] ItemBilgileriTxt;
        frmLoginSuccessfull loginsuccessful;
        Check check;
        Credit credit;
        Cash cash ;



        public frmPayment()
        {
            InitializeComponent();
            loginsuccessful = new frmLoginSuccessfull();
            purchased = System.IO.File.ReadAllLines(Application.StartupPath + "\\Purchased.txt");
            ItemBilgileriTxt = File.ReadAllLines(Application.StartupPath + "\\ItemBilgileri.txt");
            check = new Check();
            credit = new Credit();
            cash = new Cash();
        }
        private void frmPayment_Load(object sender, EventArgs e)
        {
            cmb_chosePayment.Text = "Bir ödeme yöntemi Seçiniz";
            cmb_chosePayment.Items.Add("Nakit");
            cmb_chosePayment.Items.Add("Kredi Kartı");
            cmb_chosePayment.Items.Add("Çek");

            hideShow();

        }
        private void btn_ConfirmBuy_Click(object sender, EventArgs e)
        {
            if (cmb_chosePayment.Text == "Nakit" || cmb_chosePayment.Text == "Kredi Kartı" || cmb_chosePayment.Text == "Çek")
            {
                DialogResult result;
                if (cmb_chosePayment.Text == "Nakit")
                {
                    using (StreamWriter writer = new StreamWriter("Cash.txt", true))
                    {
                        writer.WriteLine(purchased[0]);
                        writer.WriteLine(purchased[1]);
                        writer.WriteLine(lbl_setCash.Text);
                    }
                    result = MessageBox.Show($"{purchased[0]} isimli üründen {purchased[1]} adet alıyorsunuz:{purchased[2]}TL.", "Nakit",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Nakit Ödeme Yaparak Başarıyla Satın Aldınız");
                        GotoPersonelPanelCash();
                    }
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("satın alamadınız.");
                    }
                    this.Close();
                }
                if (cmb_chosePayment.Text == "Kredi Kartı")
                {
                    if (credit.authorized() == 1)
                    {
                        using (StreamWriter writer = new StreamWriter("Credit.txt", true))
                        {
                            writer.WriteLine(purchased[0]);
                            writer.WriteLine(purchased[1]);
                            writer.WriteLine(lbl_setCash.Text);
                            writer.WriteLine(/*a*/txt_cardNumber.Text);
                            writer.WriteLine(/*b*/txt_CardType.Text);
                            writer.WriteLine(dateTimePicker1.Text);
                        }
                    }
                    result = MessageBox.Show($"{purchased[0]} isimli üründen {purchased[1]} adet alıyorsunuz:{purchased[2]}TL.", "Kredi Kartı",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Kredi Kartıyla Ödeme Yaparak Başarıyla Satın Aldınız");
                        GotoPersonelPanelCash();
                    }
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("satın alamadınız.");
                    }
                }
                if (cmb_chosePayment.Text == "Çek")
                {
                    if (credit.authorized() == 1)
                    {
                        using (StreamWriter writer = new StreamWriter("Check.txt", true))
                        {
                            writer.WriteLine(purchased[0]);
                            writer.WriteLine(purchased[1]);
                            writer.WriteLine(lbl_setCash.Text);
                            writer.WriteLine(/*a*/txt_bankName.Text);
                            writer.WriteLine(/*b*/txt_BankID.Text);
                        }
                    }
                    result = MessageBox.Show($"{purchased[0]} isimli üründen {purchased[1]} adet alıyorsunuz:{purchased[2]}TL.", "Çek",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Çek ile Ödeme Yaparak Başarıyla Satın Aldınız");
                        GotoPersonelPanelCash();
                    }
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("satın alamadınız.");
                    }
                }

            }
            else
            {
                MessageBox.Show("Lütfen Üstten Ödeme Yöntemi Seçiniz...");
            }
            this.Close();
        }
        private void cmb_chosePayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_chosePayment.SelectedIndex == 0)
            {
                PaymentMethodCash();
            }
            else if (cmb_chosePayment.SelectedIndex == 1)
            {
                PaymentMethodCredit();
            }
            else if (cmb_chosePayment.SelectedIndex == 2)
            {
                PaymentMethodCheck();
            }
        }
        private void hideShow()
        {
            txt_BankID.Hide();//
            txt_bankName.Hide();
            txt_cardNumber.Hide();
            txt_CardType.Hide();
            lbl_BankID.Hide();
            lbl_bankName.Hide();
            lbl_CardNumber.Hide();
            lbl_cardType.Hide();
            lbl_cash.Hide();
            lbl_setCash.Hide();
            lbl_expDate.Hide();
            dateTimePicker1.Hide();
        }
        private void PaymentMethodCash()
        {
            hideShow();
            lbl_cash.Show();
            lbl_setCash.Show();
            cash.feePay(Convert.ToDecimal(purchased[2]));
            lbl_setCash.Text = cash.amount.ToString();
        }
        private void PaymentMethodCredit()
        {
            if (credit.authorized() == 1)
            {
                hideShow();
                lbl_cash.Show();
                lbl_setCash.Show();
                txt_cardNumber.Show();
                txt_CardType.Show();
                lbl_cardType.Show();
                lbl_CardNumber.Show();
                lbl_expDate.Show();
                dateTimePicker1.Show();
                credit.feePay(Convert.ToDecimal(purchased[2]));
                lbl_setCash.Text = credit.amount.ToString();
            }
            else
            {
                MessageBox.Show("Banka onay vermedi");
            }
        }
        private void PaymentMethodCheck()
        {
            if (check.authorized() == 1)
            {
                hideShow();
                txt_bankName.Show();
                txt_BankID.Show();
                lbl_bankName.Show();
                lbl_BankID.Show();
                credit.feePay(Convert.ToDecimal(purchased[2]));
                lbl_setCash.Text = credit.amount.ToString();
            }
            else
            {
                MessageBox.Show("Banka Onay Vermedi");
            }
        }
        public void File_DeleteLine(int Line)
        {
            StringBuilder sb = new StringBuilder();
            //try
            //{
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
            //}
            //catch (Exception)
            //{

            //   // MessageBox.Show("Başarıyla alındı");
            //}


        }
        public void GotoPersonelPanelCash()
        {
            for (int i = 0; i < ItemBilgileriTxt.Length; i += 5)
            {
                if (ItemBilgileriTxt[i] == purchased[0])
                {
                    string oldItemName = ItemBilgileriTxt[i];
                    decimal oldItemPrice = Convert.ToDecimal(ItemBilgileriTxt[i + 1]);
                    int oldStockAmount = Convert.ToInt32(ItemBilgileriTxt[i + 2]);
                    decimal oldShippingWeight = Convert.ToDecimal(ItemBilgileriTxt[i + 3]);
                    decimal oldItemKDV = Convert.ToDecimal(ItemBilgileriTxt[i + 4]);
                    File_DeleteLine(i + 1);
                    File_DeleteLine(i + 1);
                    File_DeleteLine(i + 1);
                    File_DeleteLine(i + 1);
                    File_DeleteLine(i + 1);
                    using (StreamWriter writer = new StreamWriter("ItemBilgileri.txt", true))
                    {
                        writer.WriteLine(oldItemName);//D
                        writer.WriteLine(oldItemPrice);//D
                        writer.WriteLine(oldStockAmount - Convert.ToDecimal(purchased[1]));
                        writer.WriteLine(oldShippingWeight);
                        writer.WriteLine(oldItemKDV);
                    }
                }
                if (ItemBilgileriTxt[i] == purchased[0])
                {
                    if (Convert.ToInt32(ItemBilgileriTxt[i + 2]) - Convert.ToDecimal(purchased[1]) <= 0)
                    {
                        if (ItemBilgileriTxt[i] == purchased[0])
                        {
                            File_DeleteLine(ItemBilgileriTxt.Length-5);
                            File_DeleteLine(ItemBilgileriTxt.Length-5);
                            File_DeleteLine(ItemBilgileriTxt.Length-5);
                            File_DeleteLine(ItemBilgileriTxt.Length-5);
                            File_DeleteLine(ItemBilgileriTxt.Length - 5);
                        }
                        break;
                    }
                }
                
            }


        }
        

       
    }
}
