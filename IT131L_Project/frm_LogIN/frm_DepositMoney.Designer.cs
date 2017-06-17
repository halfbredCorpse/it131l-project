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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DepositMoney));
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Deposit = new System.Windows.Forms.Button();
            this.lbl_Pin = new System.Windows.Forms.Label();
            this.lbl_DepositMessage = new System.Windows.Forms.Label();
            this.txt_Pin = new System.Windows.Forms.TextBox();
            this.txt_DepositAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentDateAndTime = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(316, 276);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(125, 37);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "RETURN";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Deposit
            // 
            this.btn_Deposit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deposit.Location = new System.Drawing.Point(164, 276);
            this.btn_Deposit.MaximumSize = new System.Drawing.Size(122, 37);
            this.btn_Deposit.MinimumSize = new System.Drawing.Size(122, 37);
            this.btn_Deposit.Name = "btn_Deposit";
            this.btn_Deposit.Size = new System.Drawing.Size(122, 37);
            this.btn_Deposit.TabIndex = 10;
            this.btn_Deposit.Text = "DEPOSIT";
            this.btn_Deposit.UseVisualStyleBackColor = true;
            this.btn_Deposit.Click += new System.EventHandler(this.btn_Deposit_Click);
            // 
            // lbl_Pin
            // 
            this.lbl_Pin.AutoSize = true;
            this.lbl_Pin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pin.Location = new System.Drawing.Point(207, 215);
            this.lbl_Pin.Name = "lbl_Pin";
            this.lbl_Pin.Size = new System.Drawing.Size(77, 20);
            this.lbl_Pin.TabIndex = 9;
            this.lbl_Pin.Text = "Your PIN: ";
            // 
            // lbl_DepositMessage
            // 
            this.lbl_DepositMessage.AutoSize = true;
            this.lbl_DepositMessage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DepositMessage.Location = new System.Drawing.Point(117, 155);
            this.lbl_DepositMessage.Name = "lbl_DepositMessage";
            this.lbl_DepositMessage.Size = new System.Drawing.Size(151, 20);
            this.lbl_DepositMessage.TabIndex = 8;
            this.lbl_DepositMessage.Text = "Amount to deposit: ";
            // 
            // txt_Pin
            // 
            this.txt_Pin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pin.Location = new System.Drawing.Point(290, 212);
            this.txt_Pin.MaxLength = 6;
            this.txt_Pin.Name = "txt_Pin";
            this.txt_Pin.Size = new System.Drawing.Size(144, 26);
            this.txt_Pin.TabIndex = 7;
            this.txt_Pin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Pin.UseSystemPasswordChar = true;
            // 
            // txt_DepositAmount
            // 
            this.txt_DepositAmount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DepositAmount.Location = new System.Drawing.Point(290, 152);
            this.txt_DepositAmount.Name = "txt_DepositAmount";
            this.txt_DepositAmount.Size = new System.Drawing.Size(168, 26);
            this.txt_DepositAmount.TabIndex = 6;
            this.txt_DepositAmount.Text = "0.00";
            this.txt_DepositAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(175)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(116, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 44;
            this.label1.Text = "DEPOSIT";
            // 
            // lblCurrentDateAndTime
            // 
            this.lblCurrentDateAndTime.AutoSize = true;
            this.lblCurrentDateAndTime.BackColor = System.Drawing.Color.White;
            this.lblCurrentDateAndTime.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDateAndTime.Location = new System.Drawing.Point(400, 64);
            this.lblCurrentDateAndTime.Name = "lblCurrentDateAndTime";
            this.lblCurrentDateAndTime.Size = new System.Drawing.Size(41, 16);
            this.lblCurrentDateAndTime.TabIndex = 43;
            this.lblCurrentDateAndTime.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Green;
            this.pictureBox2.Location = new System.Drawing.Point(-6, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(596, 15);
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::frm_LogIN.Properties.Resources.Kiss_Miklos_BB_logo_20;
            this.pictureBox3.Location = new System.Drawing.Point(12, -4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(94, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 40;
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
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(596, 97);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.frm_DepositMoney_Load);
            // 
            // frm_DepositMoney
            // 
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
            this.Controls.Add(this.btn_Deposit);
            this.Controls.Add(this.lbl_Pin);
            this.Controls.Add(this.lbl_DepositMessage);
            this.Controls.Add(this.txt_Pin);
            this.Controls.Add(this.txt_DepositAmount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(605, 400);
            this.MinimumSize = new System.Drawing.Size(605, 400);
            this.Name = "frm_DepositMoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banks\' Banking - Deposit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_DepositMoney_FormClosing);
            this.Load += new System.EventHandler(this.frm_DepositMoney_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentDateAndTime;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}