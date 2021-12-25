using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OrderAutomation.Forms;

namespace OrderAutomation
{
    public partial class frmPersonelControlPanel : Form
    {
        public frmPersonelControlPanel()
        {
            InitializeComponent();
        }
        private void btn_UrunEkle_Click(object sender, EventArgs e)
        {
            frmLoginSuccessfulPersonel FfrmLoginSuccessfulPersonel = new frmLoginSuccessfulPersonel();
            FfrmLoginSuccessfulPersonel.ShowDialog();
        }
        private void btn_UrunCikar_Click(object sender, EventArgs e)
        {
            frmUrunCikar FfrmUrunCikar = new frmUrunCikar();
            FfrmUrunCikar.ShowDialog();
        }
        private void btn_updateProduct_Click(object sender, EventArgs e)
        {
            frmItemUpdate FfrmItemUpdate = new frmItemUpdate();
            FfrmItemUpdate.ShowDialog();
        }
        private void btn_myOrders_Click(object sender, EventArgs e)
        {
            frmOrders frmorders = new frmOrders();
            frmorders.ShowDialog();
        }
    }
}
