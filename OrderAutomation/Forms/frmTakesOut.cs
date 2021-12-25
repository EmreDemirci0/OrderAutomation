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
    public partial class frmUrunCikar : Form
    {
        public string[] ItemBilgileriTxt { get; set; }
        public frmUrunCikar()
        {
            InitializeComponent();
            ItemBilgileriTxt = System.IO.File.ReadAllLines(Application.StartupPath + "\\ItemBilgileri.txt");
        } 
        private void frmUrunCikar_Load(object sender, EventArgs e)
        {   

            cmb_ItemTakesOut.Text = "Bir İtem adı Seç";
            cmb_ItemTakesOut.Items.Clear();
            for (int i = 0; i < ItemBilgileriTxt.Length; i += 5)
            {
                cmb_ItemTakesOut.Items.Add(ItemBilgileriTxt[i]);
            }
            if (cmb_ItemTakesOut.Items.Count==0)
            {
                this.Show();
                MessageBox.Show("Şuanda Silinecek Ürün Yok...");
                this.Close();
            }
       
        }
        private void btn_TakesOut_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ItemBilgileriTxt.Length; i++)
            {
                if (ItemBilgileriTxt[i] == cmb_ItemTakesOut.Text)
                {
                    File_DeleteLine(i + 1);
                    File_DeleteLine(i + 1);
                    File_DeleteLine(i + 1);
                    File_DeleteLine(i + 1);
                    File_DeleteLine(i + 1);
                    MessageBox.Show(ItemBilgileriTxt[i] + " isimli Ürün Silindi...");
                }
            }
            //   MessageBox.Show(cmb_ItemTakesOut.SelectedIndex.ToString());
            if (cmb_ItemTakesOut.SelectedIndex == -1)
            {
                MessageBox.Show("Silinecek Ürünü Seçiniz...");
            }
        }
        public void File_DeleteLine(int Line)
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

      
    }
}
