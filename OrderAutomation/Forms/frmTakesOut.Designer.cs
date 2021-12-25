
namespace OrderAutomation
{
    partial class frmUrunCikar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunCikar));
            this.cmb_ItemTakesOut = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TakesOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_ItemTakesOut
            // 
            this.cmb_ItemTakesOut.BackColor = System.Drawing.Color.Beige;
            this.cmb_ItemTakesOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ItemTakesOut.FormattingEnabled = true;
            this.cmb_ItemTakesOut.Location = new System.Drawing.Point(277, 23);
            this.cmb_ItemTakesOut.Name = "cmb_ItemTakesOut";
            this.cmb_ItemTakesOut.Size = new System.Drawing.Size(145, 27);
            this.cmb_ItemTakesOut.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Silmek İstediğiniz Ürünü Seçiniz";
            // 
            // btn_TakesOut
            // 
            this.btn_TakesOut.BackColor = System.Drawing.Color.Beige;
            this.btn_TakesOut.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_TakesOut.Location = new System.Drawing.Point(44, 99);
            this.btn_TakesOut.Name = "btn_TakesOut";
            this.btn_TakesOut.Size = new System.Drawing.Size(369, 50);
            this.btn_TakesOut.TabIndex = 2;
            this.btn_TakesOut.Text = "Seçili Ürünü Sil";
            this.btn_TakesOut.UseVisualStyleBackColor = false;
            this.btn_TakesOut.Click += new System.EventHandler(this.btn_TakesOut_Click);
            // 
            // frmUrunCikar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(487, 171);
            this.Controls.Add(this.btn_TakesOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_ItemTakesOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUrunCikar";
            this.Text = "Ürün Çıkar";
            this.Load += new System.EventHandler(this.frmUrunCikar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_ItemTakesOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TakesOut;
    }
}