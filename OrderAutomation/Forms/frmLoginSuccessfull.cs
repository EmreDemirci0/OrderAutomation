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
    public partial class frmLoginSuccessfull : Form
    {

        public string[] ItemBilgileriTxt { get; set; }
        public frmLoginSuccessfull()
        {
            InitializeComponent();
            ItemBilgileriTxt = System.IO.File.ReadAllLines(Application.StartupPath + "\\ItemBilgileri.txt");
        }
        private void frmLoginSuccessfull_Load(object sender, EventArgs e)
        {
            //if (lst_showItem.Items.Count==0)
            //{
            //    this.Show();
            //    MessageBox.Show("Şuan Ürün Yok");
            //    this.Close();
            //}
            this.AcceptButton = btn_buy;
            cmb_stockAmount.Enabled = false;
            cmb_chooseItem.Text = "Bir item adı seç";
            cmb_chooseItem.Items.Clear();
            for (int i = 0; i < ItemBilgileriTxt.Length; i += 5)
            {
                cmb_chooseItem.Items.Add(ItemBilgileriTxt[i]);
            }
            LstBoxUrunlerDoldur();
          
        }

        private void cmb_stockAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stokadedi = Convert.ToInt32(cmb_stockAmount.Text);
            decimal vergi = Convert.ToDecimal(label9.Text);
            decimal tekilfiyat = Convert.ToDecimal(label7.Text);
            label11.Text = ((tekilfiyat + vergi) * stokadedi).ToString();
        }
        private void cmb_chooseItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_stockAmount.Enabled = true;
            cmb_stockAmount.Items.Clear();
            string b = cmb_chooseItem.SelectedItem.ToString();
            for (int i = 0; i < ItemBilgileriTxt.Length; i++)
            {
                if (ItemBilgileriTxt[i] == b)
                {
                    label7.Text = ItemBilgileriTxt[i + 1].ToString();
                    decimal taxPrice = Convert.ToDecimal(ItemBilgileriTxt[i + 1]) * (Convert.ToDecimal(ItemBilgileriTxt[i + 4])) / 100;
                    label9.Text = taxPrice.ToString();
                }
            }
            ComboBoxStockAmount();
        }
        private void btn_buy_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("Purchased.txt"))
            {
                writer.WriteLine(cmb_chooseItem.Text);
                writer.WriteLine(cmb_stockAmount.Text);
                writer.WriteLine(label11.Text);
            }
            if (label7.Text != "________" && label9.Text != "________" && label11.Text != "________")
            {
                buyItem();
            }
            else
            {
                MessageBox.Show("lütfen gereken comboboxları doldurunuz yerleri doldurunuz");
            }
        }
        private void buyItem()
        {
            DialogResult result;
            result = MessageBox.Show("Borcunuz:" + label11.Text, "Ödeme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmPayment ffrmPayment = new frmPayment();
                ffrmPayment.ShowDialog();
                ItemBilgileriTxt = System.IO.File.ReadAllLines(Application.StartupPath + "\\ItemBilgileri.txt");
                lst_showItem.Items.Clear();
                cmb_stockAmount.Items.Clear();
                LstBoxUrunlerDoldur();
                ComboBoxStockAmount();

            }
            else
            {
                MessageBox.Show("Almamayı Seçtiniz.");

            }
        }
        public void LstBoxUrunlerDoldur()
        {
            for (int i = 0; i < ItemBilgileriTxt.Length; i += 5)
            {
                lst_showItem.Items.Add($"{ItemBilgileriTxt[i]}\t\t{ItemBilgileriTxt[i + 1]}TL\t\t{ItemBilgileriTxt[i + 2]}");
            }
        }
        public void ComboBoxStockAmount()
        {
            int a = 0;
            for (int i = 0; i < ItemBilgileriTxt.Length; i += 5)
            {
                if (cmb_chooseItem.Text == ItemBilgileriTxt[i])
                {
                    a = Convert.ToInt32(ItemBilgileriTxt[i + 2]);
                    for (int j = 1; j <= a; j++)
                    {
                        cmb_stockAmount.Items.Add(j);
                    }
                }
            }
        }


    }
}

