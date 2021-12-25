
namespace OrderAutomation
{
    partial class frmPersonelControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelControlPanel));
            this.btn_updateProduct = new System.Windows.Forms.Button();
            this.btn_UrunCikar = new System.Windows.Forms.Button();
            this.btn_UrunEkle = new System.Windows.Forms.Button();
            this.btn_myOrders = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_updateProduct
            // 
            this.btn_updateProduct.BackColor = System.Drawing.Color.Beige;
            this.btn_updateProduct.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_updateProduct.Location = new System.Drawing.Point(66, 208);
            this.btn_updateProduct.Name = "btn_updateProduct";
            this.btn_updateProduct.Size = new System.Drawing.Size(197, 89);
            this.btn_updateProduct.TabIndex = 5;
            this.btn_updateProduct.Text = "Urun Guncelle";
            this.btn_updateProduct.UseVisualStyleBackColor = false;
            this.btn_updateProduct.Click += new System.EventHandler(this.btn_updateProduct_Click);
            // 
            // btn_UrunCikar
            // 
            this.btn_UrunCikar.BackColor = System.Drawing.Color.Beige;
            this.btn_UrunCikar.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_UrunCikar.Location = new System.Drawing.Point(551, 45);
            this.btn_UrunCikar.Name = "btn_UrunCikar";
            this.btn_UrunCikar.Size = new System.Drawing.Size(197, 89);
            this.btn_UrunCikar.TabIndex = 4;
            this.btn_UrunCikar.Text = "Urun Cikar";
            this.btn_UrunCikar.UseVisualStyleBackColor = false;
            this.btn_UrunCikar.Click += new System.EventHandler(this.btn_UrunCikar_Click);
            // 
            // btn_UrunEkle
            // 
            this.btn_UrunEkle.BackColor = System.Drawing.Color.Beige;
            this.btn_UrunEkle.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_UrunEkle.Location = new System.Drawing.Point(66, 45);
            this.btn_UrunEkle.Name = "btn_UrunEkle";
            this.btn_UrunEkle.Size = new System.Drawing.Size(197, 89);
            this.btn_UrunEkle.TabIndex = 3;
            this.btn_UrunEkle.Text = "Urun Ekle";
            this.btn_UrunEkle.UseVisualStyleBackColor = false;
            this.btn_UrunEkle.Click += new System.EventHandler(this.btn_UrunEkle_Click);
            // 
            // btn_myOrders
            // 
            this.btn_myOrders.BackColor = System.Drawing.Color.Beige;
            this.btn_myOrders.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_myOrders.Location = new System.Drawing.Point(551, 208);
            this.btn_myOrders.Name = "btn_myOrders";
            this.btn_myOrders.Size = new System.Drawing.Size(197, 89);
            this.btn_myOrders.TabIndex = 6;
            this.btn_myOrders.Text = "Verilen Siparişler";
            this.btn_myOrders.UseVisualStyleBackColor = false;
            this.btn_myOrders.Click += new System.EventHandler(this.btn_myOrders_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(312, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmPersonelControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(800, 349);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_myOrders);
            this.Controls.Add(this.btn_updateProduct);
            this.Controls.Add(this.btn_UrunCikar);
            this.Controls.Add(this.btn_UrunEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPersonelControlPanel";
            this.Text = "Kontrol Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_updateProduct;
        private System.Windows.Forms.Button btn_UrunCikar;
        private System.Windows.Forms.Button btn_UrunEkle;
        private System.Windows.Forms.Button btn_myOrders;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}