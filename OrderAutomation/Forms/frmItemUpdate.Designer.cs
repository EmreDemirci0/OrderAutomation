
namespace OrderAutomation.Forms
{
    partial class frmItemUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemUpdate));
            this.cmb_itemUpdate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.txt_itemPrice = new System.Windows.Forms.TextBox();
            this.txt_stockAmount = new System.Windows.Forms.TextBox();
            this.txt_shippingWeight = new System.Windows.Forms.TextBox();
            this.txt_itemKdv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_updateItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_itemUpdate
            // 
            this.cmb_itemUpdate.BackColor = System.Drawing.Color.Beige;
            this.cmb_itemUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_itemUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmb_itemUpdate.FormattingEnabled = true;
            this.cmb_itemUpdate.Location = new System.Drawing.Point(533, 90);
            this.cmb_itemUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_itemUpdate.Name = "cmb_itemUpdate";
            this.cmb_itemUpdate.Size = new System.Drawing.Size(164, 29);
            this.cmb_itemUpdate.TabIndex = 0;
            this.cmb_itemUpdate.SelectedIndexChanged += new System.EventHandler(this.cmb_itemUpdate_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lütfen Güncellemek İstediğiniz ürünü giriniz";
            // 
            // txt_itemName
            // 
            this.txt_itemName.Location = new System.Drawing.Point(388, 158);
            this.txt_itemName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(164, 33);
            this.txt_itemName.TabIndex = 2;
            // 
            // txt_itemPrice
            // 
            this.txt_itemPrice.Location = new System.Drawing.Point(388, 221);
            this.txt_itemPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txt_itemPrice.Name = "txt_itemPrice";
            this.txt_itemPrice.Size = new System.Drawing.Size(164, 33);
            this.txt_itemPrice.TabIndex = 2;
            this.txt_itemPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_itemPrice_KeyPress);
            // 
            // txt_stockAmount
            // 
            this.txt_stockAmount.Location = new System.Drawing.Point(388, 281);
            this.txt_stockAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_stockAmount.Name = "txt_stockAmount";
            this.txt_stockAmount.Size = new System.Drawing.Size(164, 33);
            this.txt_stockAmount.TabIndex = 2;
            this.txt_stockAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stockAmount_KeyPress);
            // 
            // txt_shippingWeight
            // 
            this.txt_shippingWeight.Location = new System.Drawing.Point(388, 345);
            this.txt_shippingWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txt_shippingWeight.Name = "txt_shippingWeight";
            this.txt_shippingWeight.Size = new System.Drawing.Size(164, 33);
            this.txt_shippingWeight.TabIndex = 2;
            this.txt_shippingWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_shippingWeight_KeyPress);
            // 
            // txt_itemKdv
            // 
            this.txt_itemKdv.Location = new System.Drawing.Point(388, 408);
            this.txt_itemKdv.Margin = new System.Windows.Forms.Padding(4);
            this.txt_itemKdv.Name = "txt_itemKdv";
            this.txt_itemKdv.Size = new System.Drawing.Size(164, 33);
            this.txt_itemKdv.TabIndex = 2;
            this.txt_itemKdv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_itemKdv_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ürün Ücreti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stok Miktarı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 352);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kargo Ağırlığı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 416);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ürün KDV";
            // 
            // btn_updateItem
            // 
            this.btn_updateItem.BackColor = System.Drawing.Color.Beige;
            this.btn_updateItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_updateItem.Location = new System.Drawing.Point(208, 477);
            this.btn_updateItem.Name = "btn_updateItem";
            this.btn_updateItem.Size = new System.Drawing.Size(344, 51);
            this.btn_updateItem.TabIndex = 4;
            this.btn_updateItem.Text = "Ürünü Güncelle";
            this.btn_updateItem.UseVisualStyleBackColor = false;
            this.btn_updateItem.Click += new System.EventHandler(this.btn_updateItem_Click);
            // 
            // frmItemUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(731, 592);
            this.Controls.Add(this.btn_updateItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_stockAmount);
            this.Controls.Add(this.txt_itemKdv);
            this.Controls.Add(this.txt_shippingWeight);
            this.Controls.Add(this.txt_itemPrice);
            this.Controls.Add(this.txt_itemName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_itemUpdate);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmItemUpdate";
            this.Text = "Ürünleri Güncelle";
            this.Load += new System.EventHandler(this.frmItemUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_itemUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_itemName;
        private System.Windows.Forms.TextBox txt_itemPrice;
        private System.Windows.Forms.TextBox txt_stockAmount;
        private System.Windows.Forms.TextBox txt_shippingWeight;
        private System.Windows.Forms.TextBox txt_itemKdv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_updateItem;
    }
}