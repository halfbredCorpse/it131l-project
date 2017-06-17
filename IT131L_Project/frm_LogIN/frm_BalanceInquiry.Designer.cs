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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BalanceInquiry));
            this.lst_TransactionHistory = new System.Windows.Forms.ListView();
            this.col_TransactionNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_TransactionType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_TransactionAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.lbl_BalanceLabel = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentDateAndTime = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_TransactionHistory
            // 
            this.lst_TransactionHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_TransactionNumber,
            this.col_TransactionType,
            this.col_TransactionAmount,
            this.col_Date});
            this.lst_TransactionHistory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_TransactionHistory.Location = new System.Drawing.Point(12, 111);
            this.lst_TransactionHistory.Name = "lst_TransactionHistory";
            this.lst_TransactionHistory.Size = new System.Drawing.Size(683, 252);
            this.lst_TransactionHistory.TabIndex = 4;
            this.lst_TransactionHistory.UseCompatibleStateImageBehavior = false;
            this.lst_TransactionHistory.View = System.Windows.Forms.View.Details;
            // 
            // col_TransactionNumber
            // 
            this.col_TransactionNumber.Text = "Transaction Number";
            this.col_TransactionNumber.Width = 164;
            // 
            // col_TransactionType
            // 
            this.col_TransactionType.Text = "Transaction Type";
            this.col_TransactionType.Width = 207;
            // 
            // col_TransactionAmount
            // 
            this.col_TransactionAmount.Text = "Amount";
            this.col_TransactionAmount.Width = 135;
            // 
            // col_Date
            // 
            this.col_Date.Text = "Date";
            this.col_Date.Width = 172;
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Balance.Location = new System.Drawing.Point(212, 366);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(48, 23);
            this.lbl_Balance.TabIndex = 7;
            this.lbl_Balance.Text = "0.00";
            // 
            // lbl_BalanceLabel
            // 
            this.lbl_BalanceLabel.AutoSize = true;
            this.lbl_BalanceLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BalanceLabel.Location = new System.Drawing.Point(8, 366);
            this.lbl_BalanceLabel.Name = "lbl_BalanceLabel";
            this.lbl_BalanceLabel.Size = new System.Drawing.Size(209, 23);
            this.lbl_BalanceLabel.TabIndex = 6;
            this.lbl_BalanceLabel.Text = "Current Balance: PHP ";
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.Location = new System.Drawing.Point(265, 400);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(170, 37);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(175)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(116, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "BALANCE INQUIRY";
            // 
            // lblCurrentDateAndTime
            // 
            this.lblCurrentDateAndTime.AutoSize = true;
            this.lblCurrentDateAndTime.BackColor = System.Drawing.Color.White;
            this.lblCurrentDateAndTime.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDateAndTime.Location = new System.Drawing.Point(511, 58);
            this.lblCurrentDateAndTime.Name = "lblCurrentDateAndTime";
            this.lblCurrentDateAndTime.Size = new System.Drawing.Size(41, 16);
            this.lblCurrentDateAndTime.TabIndex = 36;
            this.lblCurrentDateAndTime.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Green;
            this.pictureBox2.Location = new System.Drawing.Point(-6, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(710, 15);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::frm_LogIN.Properties.Resources.Kiss_Miklos_BB_logo_20;
            this.pictureBox3.Location = new System.Drawing.Point(12, -4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(94, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = global::frm_LogIN.Properties.Resources.Picture1;
            this.pictureBox4.Location = new System.Drawing.Point(94, -4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(322, 65);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 97);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // frm_BalanceInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCurrentDateAndTime);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lst_TransactionHistory);
            this.Controls.Add(this.lbl_Balance);
            this.Controls.Add(this.lbl_BalanceLabel);
            this.Controls.Add(this.btn_OK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(723, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(723, 500);
            this.Name = "frm_BalanceInquiry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banks\' Banking - Balance Inquiry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_BalanceInquiry_FormClosing);
            this.Load += new System.EventHandler(this.frm_BalanceInquiry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentDateAndTime;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}