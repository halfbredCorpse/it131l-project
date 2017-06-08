namespace frm_LogIN
{
    partial class frm_DepositMoney
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Deposit = new System.Windows.Forms.Button();
            this.lbl_Pin = new System.Windows.Forms.Label();
            this.lbl_DepositMessage = new System.Windows.Forms.Label();
            this.txt_Pin = new System.Windows.Forms.TextBox();
            this.txt_DepositAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(152, 63);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(125, 23);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Deposit
            // 
            this.btn_Deposit.Location = new System.Drawing.Point(24, 63);
            this.btn_Deposit.MaximumSize = new System.Drawing.Size(122, 23);
            this.btn_Deposit.MinimumSize = new System.Drawing.Size(122, 23);
            this.btn_Deposit.Name = "btn_Deposit";
            this.btn_Deposit.Size = new System.Drawing.Size(122, 23);
            this.btn_Deposit.TabIndex = 10;
            this.btn_Deposit.Text = "Deposit";
            this.btn_Deposit.UseVisualStyleBackColor = true;
            this.btn_Deposit.Click += new System.EventHandler(this.btn_Deposit_Click);
            // 
            // lbl_Pin
            // 
            this.lbl_Pin.AutoSize = true;
            this.lbl_Pin.Location = new System.Drawing.Point(71, 41);
            this.lbl_Pin.Name = "lbl_Pin";
            this.lbl_Pin.Size = new System.Drawing.Size(56, 13);
            this.lbl_Pin.TabIndex = 9;
            this.lbl_Pin.Text = "Your PIN: ";
            // 
            // lbl_DepositMessage
            // 
            this.lbl_DepositMessage.AutoSize = true;
            this.lbl_DepositMessage.Location = new System.Drawing.Point(29, 15);
            this.lbl_DepositMessage.Name = "lbl_DepositMessage";
            this.lbl_DepositMessage.Size = new System.Drawing.Size(98, 13);
            this.lbl_DepositMessage.TabIndex = 8;
            this.lbl_DepositMessage.Text = "Amount to deposit: ";
            // 
            // txt_Pin
            // 
            this.txt_Pin.Location = new System.Drawing.Point(133, 38);
            this.txt_Pin.MaxLength = 6;
            this.txt_Pin.Name = "txt_Pin";
            this.txt_Pin.PasswordChar = '*';
            this.txt_Pin.Size = new System.Drawing.Size(144, 20);
            this.txt_Pin.TabIndex = 7;
            // 
            // txt_DepositAmount
            // 
            this.txt_DepositAmount.Location = new System.Drawing.Point(133, 12);
            this.txt_DepositAmount.Name = "txt_DepositAmount";
            this.txt_DepositAmount.Size = new System.Drawing.Size(144, 20);
            this.txt_DepositAmount.TabIndex = 6;
            this.txt_DepositAmount.Text = "0.00";
            this.txt_DepositAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frm_DepositMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 99);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Deposit);
            this.Controls.Add(this.lbl_Pin);
            this.Controls.Add(this.lbl_DepositMessage);
            this.Controls.Add(this.txt_Pin);
            this.Controls.Add(this.txt_DepositAmount);
            this.Name = "frm_DepositMoney";
            this.Text = "Banks Banking - Deposit Money";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_DepositMoney_FormClosing);
            this.Load += new System.EventHandler(this.frm_DepositMoney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Deposit;
        private System.Windows.Forms.Label lbl_Pin;
        private System.Windows.Forms.Label lbl_DepositMessage;
        private System.Windows.Forms.TextBox txt_Pin;
        private System.Windows.Forms.TextBox txt_DepositAmount;
    }
}