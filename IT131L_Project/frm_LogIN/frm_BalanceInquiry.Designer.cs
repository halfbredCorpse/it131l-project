namespace frm_LogIN
{
    partial class frm_BalanceInquiry
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
            this.lst_TransactionHistory = new System.Windows.Forms.ListView();
            this.col_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_TransactionNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_TransactionType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_TransactionAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.lbl_BalanceLabel = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_TransactionHistory
            // 
            this.lst_TransactionHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_TransactionNumber,
            this.col_TransactionType,
            this.col_TransactionAmount,
            this.col_Date});
            this.lst_TransactionHistory.Location = new System.Drawing.Point(16, 15);
            this.lst_TransactionHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lst_TransactionHistory.Name = "lst_TransactionHistory";
            this.lst_TransactionHistory.Size = new System.Drawing.Size(831, 272);
            this.lst_TransactionHistory.TabIndex = 4;
            this.lst_TransactionHistory.UseCompatibleStateImageBehavior = false;
            this.lst_TransactionHistory.View = System.Windows.Forms.View.Details;
            // 
            // col_Date
            // 
            this.col_Date.Text = "Date";
            this.col_Date.Width = 101;
            // 
            // col_TransactionNumber
            // 
            this.col_TransactionNumber.Text = "Transaction Number";
            this.col_TransactionNumber.Width = 170;
            // 
            // col_TransactionType
            // 
            this.col_TransactionType.Text = "Transaction Type";
            this.col_TransactionType.Width = 195;
            // 
            // col_TransactionAmount
            // 
            this.col_TransactionAmount.Text = "Amount";
            this.col_TransactionAmount.Width = 148;
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Balance.Location = new System.Drawing.Point(271, 292);
            this.lbl_Balance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(54, 25);
            this.lbl_Balance.TabIndex = 7;
            this.lbl_Balance.Text = "0.00";
            // 
            // lbl_BalanceLabel
            // 
            this.lbl_BalanceLabel.AutoSize = true;
            this.lbl_BalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BalanceLabel.Location = new System.Drawing.Point(11, 292);
            this.lbl_BalanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BalanceLabel.Name = "lbl_BalanceLabel";
            this.lbl_BalanceLabel.Size = new System.Drawing.Size(230, 25);
            this.lbl_BalanceLabel.TabIndex = 6;
            this.lbl_BalanceLabel.Text = "Current Balance: PHP ";
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(313, 320);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(227, 28);
            this.btn_OK.TabIndex = 5;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // frm_BalanceInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 351);
            this.Controls.Add(this.lst_TransactionHistory);
            this.Controls.Add(this.lbl_Balance);
            this.Controls.Add(this.lbl_BalanceLabel);
            this.Controls.Add(this.btn_OK);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(879, 398);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(879, 398);
            this.Name = "frm_BalanceInquiry";
            this.Text = "Banks Banking - Balance Inquiry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_BalanceInquiry_FormClosing);
            this.Load += new System.EventHandler(this.frm_BalanceInquiry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lst_TransactionHistory;
        protected internal System.Windows.Forms.ColumnHeader col_Date;
        private System.Windows.Forms.ColumnHeader col_TransactionNumber;
        protected internal System.Windows.Forms.ColumnHeader col_TransactionType;
        private System.Windows.Forms.ColumnHeader col_TransactionAmount;
        private System.Windows.Forms.Label lbl_Balance;
        private System.Windows.Forms.Label lbl_BalanceLabel;
        private System.Windows.Forms.Button btn_OK;
    }
}