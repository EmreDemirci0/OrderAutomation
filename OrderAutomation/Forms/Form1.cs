using OrderAutomation.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using

namespace OrderAutomation
{
    public partial class frmIdPw : Form
    {
        string[] IdPw { get; set; }
        string Id { get; set; }
        string Pw { get; set; }
        public frmIdPw()
        {
            InitializeComponent();
         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                
                Id = (IdPw[0]);
                Pw = (IdPw[1]);
                if (textBox1.Text == Id && textBox2.Text == Pw)
                {
                    MessageBox.Show("Giris basarılı:Musteri");
                    GirisBasariliMusteri();
                }
                else
                {
                    MessageBox.Show("Yanlış girdiniz:müşteri");
                }
            }
            if (radioButton2.Checked)
            {
               
                Id = (IdPw[2]);
                Pw = (IdPw[3]);
                if (textBox1.Text == Id && textBox2.Text == Pw)
                {
                    MessageBox.Show("Giris basarılı:personel");
                    GirisBasariliPersonel();
                }
                else
                {
                    MessageBox.Show("Yanlış girdiniz");
                }
            }
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
            

            IdPw = System.IO.File.ReadAllLines(Application.StartupPath + "\\IdPw.txt");
            radioButton1.Checked = true;

           
        }
        private void frmIdPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void GirisBasariliMusteri()
        {
            frmLoginSuccessfull FfrmLoginSuccessful = new frmLoginSuccessfull();
            FfrmLoginSuccessful.ShowDialog();
        }
        private void GirisBasariliPersonel()
        {
            frmPersonelControlPanel frmpersonelControlPanel = new frmPersonelControlPanel();
            frmpersonelControlPanel.ShowDialog();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

       
    }
}
