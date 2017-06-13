namespace frm_LogIN
{
    partial class frm_TransferFunds
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
            this.txt_TransferAmount = new System.Windows.Forms.TextBox();
            this.txt_ReceiverAccountNumber = new System.Windows.Forms.TextBox();
            this.txt_Pin = new System.Windows.Forms.TextBox();
            this.lbl_TransferLabel = new System.Windows.Forms.Label();
            this.lbl_ReceiverAccountNumber = new System.Windows.Forms.Label();
            this.lbl_Pin = new System.Windows.Forms.Label();
            this.btn_Transfer = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_TransferAmount
            // 
            this.txt_TransferAmount.Location = new System.Drawing.Point(172, 13);
            this.txt_TransferAmount.Name = "txt_TransferAmount";
            this.txt_TransferAmount.Size = new System.Drawing.Size(182, 20);
            this.txt_TransferAmount.TabIndex = 0;
            this.txt_TransferAmount.Text = "0.00";
            this.txt_TransferAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_ReceiverAccountNumber
            // 
            this.txt_ReceiverAccountNumber.Location = new System.Drawing.Point(172, 40);
            this.txt_ReceiverAccountNumber.Name = "txt_ReceiverAccountNumber";
            this.txt_ReceiverAccountNumber.Size = new System.Drawing.Size(182, 20);
            this.txt_ReceiverAccountNumber.TabIndex = 1;
            this.txt_ReceiverAccountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Pin
            // 
            this.txt_Pin.Location = new System.Drawing.Point(172, 66);
            this.txt_Pin.MaxLength = 6;
            this.txt_Pin.Name = "txt_Pin";
            this.txt_Pin.PasswordChar = '*';
            this.txt_Pin.Size = new System.Drawing.Size(106, 20);
            this.txt_Pin.TabIndex = 2;
            // 
            // lbl_TransferLabel
            // 
            this.lbl_TransferLabel.AutoSize = true;
            this.lbl_TransferLabel.Location = new System.Drawing.Point(67, 16);
            this.lbl_TransferLabel.Name = "lbl_TransferLabel";
            this.lbl_TransferLabel.Size = new System.Drawing.Size(99, 13);
            this.lbl_TransferLabel.TabIndex = 3;
            this.lbl_TransferLabel.Text = "Amount to transfer: ";
            // 
            // lbl_ReceiverAccountNumber
            // 
            this.lbl_ReceiverAccountNumber.AutoSize = true;
            this.lbl_ReceiverAccountNumber.Location = new System.Drawing.Point(20, 43);
            this.lbl_ReceiverAccountNumber.Name = "lbl_ReceiverAccountNumber";
            this.lbl_ReceiverAccountNumber.Size = new System.Drawing.Size(146, 13);
            this.lbl_ReceiverAccountNumber.TabIndex = 4;
            this.lbl_ReceiverAccountNumber.Text = "Receiver\'s Account Number: ";
            // 
            // lbl_Pin
            // 
            this.lbl_Pin.AutoSize = true;
            this.lbl_Pin.Location = new System.Drawing.Point(110, 69);
            this.lbl_Pin.Name = "lbl_Pin";
            this.lbl_Pin.Size = new System.Drawing.Size(56, 13);
            this.lbl_Pin.TabIndex = 5;
            this.lbl_Pin.Text = "Your PIN: ";
            // 
            // btn_Transfer
            // 
            this.btn_Transfer.Location = new System.Drawing.Point(70, 92);
            this.btn_Transfer.Name = "btn_Transfer";
            this.btn_Transfer.Size = new System.Drawing.Size(113, 23);
            this.btn_Transfer.TabIndex = 6;
            this.btn_Transfer.Text = "TRANSFER";
            this.btn_Transfer.UseVisualStyleBackColor = true;
            this.btn_Transfer.Click += new System.EventHandler(this.btn_Transfer_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(189, 92);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(113, 23);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frm_TransferFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 126);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Transfer);
            this.Controls.Add(this.lbl_Pin);
            this.Controls.Add(this.lbl_ReceiverAccountNumber);
            this.Controls.Add(this.lbl_TransferLabel);
            this.Controls.Add(this.txt_Pin);
            this.Controls.Add(this.txt_ReceiverAccountNumber);
            this.Controls.Add(this.txt_TransferAmount);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(382, 165);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(382, 165);
            this.Name = "frm_TransferFunds";
            this.Text = "Banks Banking - Transfer Funds";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_TransferFunds_FormClosing);
            this.Load += new System.EventHandler(this.frm_TransferFunds_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TransferAmount;
        private System.Windows.Forms.TextBox txt_ReceiverAccountNumber;
        private System.Windows.Forms.TextBox txt_Pin;
        private System.Windows.Forms.Label lbl_TransferLabel;
        private System.Windows.Forms.Label lbl_ReceiverAccountNumber;
        private System.Windows.Forms.Label lbl_Pin;
        private System.Windows.Forms.Button btn_Transfer;
        private System.Windows.Forms.Button btn_Cancel;
    }
}