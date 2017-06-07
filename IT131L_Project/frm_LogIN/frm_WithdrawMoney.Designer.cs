namespace frm_LogIN
{
    partial class frm_WithdrawMoney
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
            this.txt_WithdrawAmount = new System.Windows.Forms.TextBox();
            this.txt_Pin = new System.Windows.Forms.TextBox();
            this.lbl_WithdrawMessage = new System.Windows.Forms.Label();
            this.lbl_Pin = new System.Windows.Forms.Label();
            this.btn_Withdraw = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_WithdrawAmount
            // 
            this.txt_WithdrawAmount.Location = new System.Drawing.Point(141, 12);
            this.txt_WithdrawAmount.Name = "txt_WithdrawAmount";
            this.txt_WithdrawAmount.Size = new System.Drawing.Size(144, 20);
            this.txt_WithdrawAmount.TabIndex = 0;
            this.txt_WithdrawAmount.Text = "0.00";
            this.txt_WithdrawAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Pin
            // 
            this.txt_Pin.Location = new System.Drawing.Point(141, 38);
            this.txt_Pin.MaxLength = 6;
            this.txt_Pin.Name = "txt_Pin";
            this.txt_Pin.PasswordChar = '*';
            this.txt_Pin.Size = new System.Drawing.Size(144, 20);
            this.txt_Pin.TabIndex = 1;
            // 
            // lbl_WithdrawMessage
            // 
            this.lbl_WithdrawMessage.AutoSize = true;
            this.lbl_WithdrawMessage.Location = new System.Drawing.Point(29, 15);
            this.lbl_WithdrawMessage.Name = "lbl_WithdrawMessage";
            this.lbl_WithdrawMessage.Size = new System.Drawing.Size(106, 13);
            this.lbl_WithdrawMessage.TabIndex = 2;
            this.lbl_WithdrawMessage.Text = "Amount to withdraw: ";
            // 
            // lbl_Pin
            // 
            this.lbl_Pin.AutoSize = true;
            this.lbl_Pin.Location = new System.Drawing.Point(79, 41);
            this.lbl_Pin.Name = "lbl_Pin";
            this.lbl_Pin.Size = new System.Drawing.Size(56, 13);
            this.lbl_Pin.TabIndex = 3;
            this.lbl_Pin.Text = "Your PIN: ";
            // 
            // btn_Withdraw
            // 
            this.btn_Withdraw.Location = new System.Drawing.Point(32, 63);
            this.btn_Withdraw.Name = "btn_Withdraw";
            this.btn_Withdraw.Size = new System.Drawing.Size(122, 23);
            this.btn_Withdraw.TabIndex = 4;
            this.btn_Withdraw.Text = "Withdraw";
            this.btn_Withdraw.UseVisualStyleBackColor = true;
            this.btn_Withdraw.Click += new System.EventHandler(this.btn_Withdraw_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(160, 63);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(125, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frm_WithdrawMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 98);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Withdraw);
            this.Controls.Add(this.lbl_Pin);
            this.Controls.Add(this.lbl_WithdrawMessage);
            this.Controls.Add(this.txt_Pin);
            this.Controls.Add(this.txt_WithdrawAmount);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(333, 137);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(333, 137);
            this.Name = "frm_WithdrawMoney";
            this.Text = "Banks Banking - Withdraw Money";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_WithdrawMoney_FormClosing);
            this.Load += new System.EventHandler(this.frm_WithdrawMoney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_WithdrawAmount;
        private System.Windows.Forms.TextBox txt_Pin;
        private System.Windows.Forms.Label lbl_WithdrawMessage;
        private System.Windows.Forms.Label lbl_Pin;
        private System.Windows.Forms.Button btn_Withdraw;
        private System.Windows.Forms.Button btn_Cancel;
    }
}