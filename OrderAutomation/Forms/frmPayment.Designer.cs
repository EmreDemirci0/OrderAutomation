
namespace OrderAutomation.Forms
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.cmb_chosePayment = new System.Windows.Forms.ComboBox();
            this.txt_bankName = new System.Windows.Forms.TextBox();
            this.txt_BankID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_bankName = new System.Windows.Forms.Label();
            this.lbl_BankID = new System.Windows.Forms.Label();
            this.txt_cardNumber = new System.Windows.Forms.TextBox();
            this.txt_CardType = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_CardNumber = new System.Windows.Forms.Label();
            this.lbl_cardType = new System.Windows.Forms.Label();
            this.lbl_expDate = new System.Windows.Forms.Label();
            this.lbl_cash = new System.Windows.Forms.Label();
            this.lbl_setCash = new System.Windows.Forms.Label();
            this.btn_ConfirmBuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_chosePayment
            // 
            this.cmb_chosePayment.BackColor = System.Drawing.Color.Beige;
            this.cmb_chosePayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_chosePayment.FormattingEnabled = true;
            this.cmb_chosePayment.Location = new System.Drawing.Point(301, 65);
            this.cmb_chosePayment.Name = "cmb_chosePayment";
            this.cmb_chosePayment.Size = new System.Drawing.Size(145, 27);
            this.cmb_chosePayment.TabIndex = 0;
            this.cmb_chosePayment.SelectedIndexChanged += new System.EventHandler(this.cmb_chosePayment_SelectedIndexChanged);
            // 
            // txt_bankName
            // 
            this.txt_bankName.Location = new System.Drawing.Point(249, 195);
            this.txt_bankName.Name = "txt_bankName";
            this.txt_bankName.Size = new System.Drawing.Size(120, 26);
            this.txt_bankName.TabIndex = 1;
            // 
            // txt_BankID
            // 
            this.txt_BankID.Location = new System.Drawing.Point(249, 247);
            this.txt_BankID.Name = "txt_BankID";
            this.txt_BankID.Size = new System.Drawing.Size(120, 26);
            this.txt_BankID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ödeme Yöntemi Seç";
            // 
            // lbl_bankName
            // 
            this.lbl_bankName.AutoSize = true;
            this.lbl_bankName.Location = new System.Drawing.Point(122, 196);
            this.lbl_bankName.Name = "lbl_bankName";
            this.lbl_bankName.Size = new System.Drawing.Size(76, 20);
            this.lbl_bankName.TabIndex = 4;
            this.lbl_bankName.Text = "Banka Adı";
            // 
            // lbl_BankID
            // 
            this.lbl_BankID.AutoSize = true;
            this.lbl_BankID.Location = new System.Drawing.Point(122, 247);
            this.lbl_BankID.Name = "lbl_BankID";
            this.lbl_BankID.Size = new System.Drawing.Size(103, 20);
            this.lbl_BankID.TabIndex = 4;
            this.lbl_BankID.Text = "Kart Numarası";
            // 
            // txt_cardNumber
            // 
            this.txt_cardNumber.Location = new System.Drawing.Point(231, 170);
            this.txt_cardNumber.Name = "txt_cardNumber";
            this.txt_cardNumber.Size = new System.Drawing.Size(120, 26);
            this.txt_cardNumber.TabIndex = 5;
            // 
            // txt_CardType
            // 
            this.txt_CardType.Location = new System.Drawing.Point(231, 221);
            this.txt_CardType.Name = "txt_CardType";
            this.txt_CardType.Size = new System.Drawing.Size(120, 26);
            this.txt_CardType.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(231, 277);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 26);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2025, 12, 22, 1, 45, 0, 0);
            // 
            // lbl_CardNumber
            // 
            this.lbl_CardNumber.AutoSize = true;
            this.lbl_CardNumber.Location = new System.Drawing.Point(107, 170);
            this.lbl_CardNumber.Name = "lbl_CardNumber";
            this.lbl_CardNumber.Size = new System.Drawing.Size(103, 20);
            this.lbl_CardNumber.TabIndex = 8;
            this.lbl_CardNumber.Text = "Kart Numarası";
            // 
            // lbl_cardType
            // 
            this.lbl_cardType.AutoSize = true;
            this.lbl_cardType.Location = new System.Drawing.Point(127, 227);
            this.lbl_cardType.Name = "lbl_cardType";
            this.lbl_cardType.Size = new System.Drawing.Size(65, 20);
            this.lbl_cardType.TabIndex = 9;
            this.lbl_cardType.Text = "Kart Tipi";
            // 
            // lbl_expDate
            // 
            this.lbl_expDate.AutoSize = true;
            this.lbl_expDate.Location = new System.Drawing.Point(127, 277);
            this.lbl_expDate.Name = "lbl_expDate";
            this.lbl_expDate.Size = new System.Drawing.Size(34, 20);
            this.lbl_expDate.TabIndex = 10;
            this.lbl_expDate.Text = "SKT";
            // 
            // lbl_cash
            // 
            this.lbl_cash.AutoSize = true;
            this.lbl_cash.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cash.Location = new System.Drawing.Point(206, 113);
            this.lbl_cash.Name = "lbl_cash";
            this.lbl_cash.Size = new System.Drawing.Size(87, 32);
            this.lbl_cash.TabIndex = 11;
            this.lbl_cash.Text = "Tutar :";
            // 
            // lbl_setCash
            // 
            this.lbl_setCash.AutoSize = true;
            this.lbl_setCash.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_setCash.Location = new System.Drawing.Point(299, 113);
            this.lbl_setCash.Name = "lbl_setCash";
            this.lbl_setCash.Size = new System.Drawing.Size(94, 32);
            this.lbl_setCash.TabIndex = 12;
            this.lbl_setCash.Text = "________";
            // 
            // btn_ConfirmBuy
            // 
            this.btn_ConfirmBuy.BackColor = System.Drawing.Color.Beige;
            this.btn_ConfirmBuy.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_ConfirmBuy.Location = new System.Drawing.Point(135, 321);
            this.btn_ConfirmBuy.Name = "btn_ConfirmBuy";
            this.btn_ConfirmBuy.Size = new System.Drawing.Size(336, 65);
            this.btn_ConfirmBuy.TabIndex = 13;
            this.btn_ConfirmBuy.Text = "Satın Al";
            this.btn_ConfirmBuy.UseVisualStyleBackColor = false;
            this.btn_ConfirmBuy.Click += new System.EventHandler(this.btn_ConfirmBuy_Click);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.btn_ConfirmBuy);
            this.Controls.Add(this.lbl_setCash);
            this.Controls.Add(this.lbl_cash);
            this.Controls.Add(this.lbl_expDate);
            this.Controls.Add(this.lbl_cardType);
            this.Controls.Add(this.lbl_CardNumber);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_CardType);
            this.Controls.Add(this.txt_cardNumber);
            this.Controls.Add(this.lbl_BankID);
            this.Controls.Add(this.lbl_bankName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_BankID);
            this.Controls.Add(this.txt_bankName);
            this.Controls.Add(this.cmb_chosePayment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPayment";
            this.Text = "Ödeme";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_chosePayment;
        private System.Windows.Forms.TextBox txt_bankName;
        private System.Windows.Forms.TextBox txt_BankID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_bankName;
        private System.Windows.Forms.Label lbl_BankID;
        private System.Windows.Forms.TextBox txt_cardNumber;
        private System.Windows.Forms.TextBox txt_CardType;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_CardNumber;
        private System.Windows.Forms.Label lbl_cardType;
        private System.Windows.Forms.Label lbl_expDate;
        private System.Windows.Forms.Label lbl_cash;
        private System.Windows.Forms.Label lbl_setCash;
        private System.Windows.Forms.Button btn_ConfirmBuy;
    }
}