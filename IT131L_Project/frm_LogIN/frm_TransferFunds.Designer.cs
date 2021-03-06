﻿namespace frm_LogIN
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TransferFunds));
            this.txt_TransferAmount = new System.Windows.Forms.TextBox();
            this.txt_ReceiverAccountNumber = new System.Windows.Forms.TextBox();
            this.txt_Pin = new System.Windows.Forms.TextBox();
            this.lbl_TransferLabel = new System.Windows.Forms.Label();
            this.lbl_ReceiverAccountNumber = new System.Windows.Forms.Label();
            this.lbl_Pin = new System.Windows.Forms.Label();
            this.btn_Transfer = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lblCurrentDateAndTime = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TransferAmount
            // 
            this.txt_TransferAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TransferAmount.Location = new System.Drawing.Point(287, 163);
            this.txt_TransferAmount.Name = "txt_TransferAmount";
            this.txt_TransferAmount.Size = new System.Drawing.Size(182, 23);
            this.txt_TransferAmount.TabIndex = 0;
            this.txt_TransferAmount.Text = "0.00";
            this.txt_TransferAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_TransferAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_TransferAmount_KeyDown);
            this.txt_TransferAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TransferAmount_KeyPress);
            this.txt_TransferAmount.Leave += new System.EventHandler(this.txt_TransferAmount_Leave);
            // 
            // txt_ReceiverAccountNumber
            // 
            this.txt_ReceiverAccountNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ReceiverAccountNumber.Location = new System.Drawing.Point(287, 190);
            this.txt_ReceiverAccountNumber.MaxLength = 8;
            this.txt_ReceiverAccountNumber.Name = "txt_ReceiverAccountNumber";
            this.txt_ReceiverAccountNumber.Size = new System.Drawing.Size(182, 23);
            this.txt_ReceiverAccountNumber.TabIndex = 1;
            this.txt_ReceiverAccountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_ReceiverAccountNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ReceiverAccountNumber_KeyPress);
            // 
            // txt_Pin
            // 
            this.txt_Pin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pin.Location = new System.Drawing.Point(287, 242);
            this.txt_Pin.MaxLength = 6;
            this.txt_Pin.Name = "txt_Pin";
            this.txt_Pin.Size = new System.Drawing.Size(106, 23);
            this.txt_Pin.TabIndex = 2;
            this.txt_Pin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Pin.UseSystemPasswordChar = true;
            this.txt_Pin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Pin_KeyPress);
            // 
            // lbl_TransferLabel
            // 
            this.lbl_TransferLabel.AutoSize = true;
            this.lbl_TransferLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TransferLabel.Location = new System.Drawing.Point(144, 166);
            this.lbl_TransferLabel.Name = "lbl_TransferLabel";
            this.lbl_TransferLabel.Size = new System.Drawing.Size(137, 17);
            this.lbl_TransferLabel.TabIndex = 3;
            this.lbl_TransferLabel.Text = "Amount to transfer: ";
            // 
            // lbl_ReceiverAccountNumber
            // 
            this.lbl_ReceiverAccountNumber.AutoSize = true;
            this.lbl_ReceiverAccountNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReceiverAccountNumber.Location = new System.Drawing.Point(87, 193);
            this.lbl_ReceiverAccountNumber.Name = "lbl_ReceiverAccountNumber";
            this.lbl_ReceiverAccountNumber.Size = new System.Drawing.Size(194, 17);
            this.lbl_ReceiverAccountNumber.TabIndex = 4;
            this.lbl_ReceiverAccountNumber.Text = "Receiver\'s Account Number: ";
            // 
            // lbl_Pin
            // 
            this.lbl_Pin.AutoSize = true;
            this.lbl_Pin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pin.Location = new System.Drawing.Point(212, 245);
            this.lbl_Pin.Name = "lbl_Pin";
            this.lbl_Pin.Size = new System.Drawing.Size(69, 17);
            this.lbl_Pin.TabIndex = 5;
            this.lbl_Pin.Text = "Your PIN: ";
            // 
            // btn_Transfer
            // 
            this.btn_Transfer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Transfer.Location = new System.Drawing.Point(161, 288);
            this.btn_Transfer.Name = "btn_Transfer";
            this.btn_Transfer.Size = new System.Drawing.Size(113, 37);
            this.btn_Transfer.TabIndex = 6;
            this.btn_Transfer.Text = "TRANSFER";
            this.btn_Transfer.UseVisualStyleBackColor = true;
            this.btn_Transfer.Click += new System.EventHandler(this.btn_Transfer_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(305, 288);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(113, 37);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "RETURN";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lblCurrentDateAndTime
            // 
            this.lblCurrentDateAndTime.AutoSize = true;
            this.lblCurrentDateAndTime.BackColor = System.Drawing.Color.White;
            this.lblCurrentDateAndTime.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDateAndTime.Location = new System.Drawing.Point(372, 64);
            this.lblCurrentDateAndTime.Name = "lblCurrentDateAndTime";
            this.lblCurrentDateAndTime.Size = new System.Drawing.Size(41, 16);
            this.lblCurrentDateAndTime.TabIndex = 29;
            this.lblCurrentDateAndTime.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Green;
            this.pictureBox2.Location = new System.Drawing.Point(-6, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(604, 15);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::frm_LogIN.Properties.Resources.Kiss_Miklos_BB_logo_20;
            this.pictureBox3.Location = new System.Drawing.Point(12, -4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(94, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
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
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 97);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.frm_TransferFunds_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(175)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(116, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "TRANSFER FUNDS";
            // 
            // frm_TransferFunds
            // 
            this.AcceptButton = this.btn_Transfer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCurrentDateAndTime);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Transfer);
            this.Controls.Add(this.lbl_Pin);
            this.Controls.Add(this.lbl_ReceiverAccountNumber);
            this.Controls.Add(this.lbl_TransferLabel);
            this.Controls.Add(this.txt_Pin);
            this.Controls.Add(this.txt_ReceiverAccountNumber);
            this.Controls.Add(this.txt_TransferAmount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(605, 400);
            this.MinimumSize = new System.Drawing.Size(605, 400);
            this.Name = "frm_TransferFunds";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banks\' Banking - Transfer Funds";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_TransferFunds_FormClosing);
            this.Load += new System.EventHandler(this.frm_TransferFunds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label lblCurrentDateAndTime;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}