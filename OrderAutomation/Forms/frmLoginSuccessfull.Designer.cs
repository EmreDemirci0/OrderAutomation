
namespace OrderAutomation.Forms
{
    partial class frmLoginSuccessfull
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginSuccessfull));
            this.cmb_chooseItem = new System.Windows.Forms.ComboBox();
            this.lst_showItem = new System.Windows.Forms.ListBox();
            this.cmb_stockAmount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_buy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_chooseItem
            // 
            this.cmb_chooseItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_chooseItem.FormattingEnabled = true;
            this.cmb_chooseItem.Location = new System.Drawing.Point(798, 42);
            this.cmb_chooseItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_chooseItem.Name = "cmb_chooseItem";
            this.cmb_chooseItem.Size = new System.Drawing.Size(234, 38);
            this.cmb_chooseItem.TabIndex = 0;
            this.cmb_chooseItem.SelectedIndexChanged += new System.EventHandler(this.cmb_chooseItem_SelectedIndexChanged);
            // 
            // lst_showItem
            // 
            this.lst_showItem.BackColor = System.Drawing.Color.PapayaWhip;
            this.lst_showItem.FormattingEnabled = true;
            this.lst_showItem.ItemHeight = 30;
            this.lst_showItem.Location = new System.Drawing.Point(37, 79);
            this.lst_showItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_showItem.Name = "lst_showItem";
            this.lst_showItem.Size = new System.Drawing.Size(501, 514);
            this.lst_showItem.TabIndex = 1;
            // 
            // cmb_stockAmount
            // 
            this.cmb_stockAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_stockAmount.FormattingEnabled = true;
            this.cmb_stockAmount.Location = new System.Drawing.Point(798, 116);
            this.cmb_stockAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_stockAmount.Name = "cmb_stockAmount";
            this.cmb_stockAmount.Size = new System.Drawing.Size(234, 38);
            this.cmb_stockAmount.TabIndex = 2;
            this.cmb_stockAmount.SelectedIndexChanged += new System.EventHandler(this.cmb_stockAmount_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stok Miktarı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ürün Seçiniz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(578, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Stok Adedi Seçiniz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(614, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tekil Fiyat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(798, 224);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 31);
            this.label7.TabIndex = 9;
            this.label7.Text = "________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(614, 272);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 31);
            this.label8.TabIndex = 10;
            this.label8.Text = "Vergi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(798, 272);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 31);
            this.label9.TabIndex = 11;
            this.label9.Text = "________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(614, 317);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 31);
            this.label10.TabIndex = 12;
            this.label10.Text = "Toplam Fiyat";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(798, 317);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 31);
            this.label11.TabIndex = 13;
            this.label11.Text = "________";
            // 
            // btn_buy
            // 
            this.btn_buy.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_buy.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_buy.Location = new System.Drawing.Point(599, 406);
            this.btn_buy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(278, 58);
            this.btn_buy.TabIndex = 14;
            this.btn_buy.Text = "Satın Al";
            this.btn_buy.UseVisualStyleBackColor = false;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // frmLoginSuccessfull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1300, 711);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_stockAmount);
            this.Controls.Add(this.lst_showItem);
            this.Controls.Add(this.cmb_chooseItem);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLoginSuccessfull";
            this.Text = "Ürün Al";
            this.Load += new System.EventHandler(this.frmLoginSuccessfull_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lst_showItem;
        private System.Windows.Forms.ComboBox cmb_stockAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_buy;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox cmb_chooseItem;
    }
}