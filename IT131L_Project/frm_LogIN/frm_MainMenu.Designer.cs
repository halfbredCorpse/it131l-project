namespace frm_LogIN
{
    partial class frm_MainMenu
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
            this.btn_BalanceInquiry = new System.Windows.Forms.Button();
            this.btn_WitdhrawMoney = new System.Windows.Forms.Button();
            this.btn_TransferFunds = new System.Windows.Forms.Button();
            this.btn_DepositMoney = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_BalanceInquiry
            // 
            this.btn_BalanceInquiry.Location = new System.Drawing.Point(12, 40);
            this.btn_BalanceInquiry.Name = "btn_BalanceInquiry";
            this.btn_BalanceInquiry.Size = new System.Drawing.Size(260, 23);
            this.btn_BalanceInquiry.TabIndex = 0;
            this.btn_BalanceInquiry.Text = "BALANCE INQUIRY";
            this.btn_BalanceInquiry.UseVisualStyleBackColor = true;
            this.btn_BalanceInquiry.Click += new System.EventHandler(this.btn_BalanceInquiry_Click);
            // 
            // btn_WitdhrawMoney
            // 
            this.btn_WitdhrawMoney.Location = new System.Drawing.Point(12, 69);
            this.btn_WitdhrawMoney.Name = "btn_WitdhrawMoney";
            this.btn_WitdhrawMoney.Size = new System.Drawing.Size(260, 23);
            this.btn_WitdhrawMoney.TabIndex = 1;
            this.btn_WitdhrawMoney.Text = "WITHDRAW MONEY";
            this.btn_WitdhrawMoney.UseVisualStyleBackColor = true;
            this.btn_WitdhrawMoney.Click += new System.EventHandler(this.btn_WitdhrawMoney_Click);
            // 
            // btn_TransferFunds
            // 
            this.btn_TransferFunds.Location = new System.Drawing.Point(12, 98);
            this.btn_TransferFunds.Name = "btn_TransferFunds";
            this.btn_TransferFunds.Size = new System.Drawing.Size(260, 23);
            this.btn_TransferFunds.TabIndex = 2;
            this.btn_TransferFunds.Text = "TRANSFER FUNDS";
            this.btn_TransferFunds.UseVisualStyleBackColor = true;
            this.btn_TransferFunds.Click += new System.EventHandler(this.btn_TransferFunds_Click);
            // 
            // btn_DepositMoney
            // 
            this.btn_DepositMoney.Location = new System.Drawing.Point(12, 127);
            this.btn_DepositMoney.Name = "btn_DepositMoney";
            this.btn_DepositMoney.Size = new System.Drawing.Size(260, 23);
            this.btn_DepositMoney.TabIndex = 3;
            this.btn_DepositMoney.Text = "DEPOSIT MONEY";
            this.btn_DepositMoney.UseVisualStyleBackColor = true;
            this.btn_DepositMoney.Click += new System.EventHandler(this.btn_DepositMoney_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Location = new System.Drawing.Point(12, 185);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(260, 23);
            this.btn_LogOut.TabIndex = 4;
            this.btn_LogOut.Text = "LOG OUT";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Location = new System.Drawing.Point(115, 6);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(52, 13);
            this.lbl_Welcome.TabIndex = 5;
            this.lbl_Welcome.Text = "Welcome";
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FullName.Location = new System.Drawing.Point(47, 19);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(193, 22);
            this.lbl_FullName.TabIndex = 6;
            this.lbl_FullName.Text = "LASTNAME, FIRSTNAME M.I.";
            this.lbl_FullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 216);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.lbl_FullName);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_DepositMoney);
            this.Controls.Add(this.btn_TransferFunds);
            this.Controls.Add(this.btn_WitdhrawMoney);
            this.Controls.Add(this.btn_BalanceInquiry);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banks Banking - Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.frm_MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BalanceInquiry;
        private System.Windows.Forms.Button btn_WitdhrawMoney;
        private System.Windows.Forms.Button btn_TransferFunds;
        private System.Windows.Forms.Button btn_DepositMoney;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Label lbl_FullName;
    }
}