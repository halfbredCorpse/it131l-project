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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MainMenu));
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_DepositMoney = new System.Windows.Forms.Button();
            this.btn_TransferFunds = new System.Windows.Forms.Button();
            this.btn_WitdhrawMoney = new System.Windows.Forms.Button();
            this.btn_BalanceInquiry = new System.Windows.Forms.Button();
            this.lblCurrentDateAndTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.Location = new System.Drawing.Point(176, 312);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(260, 37);
            this.btn_LogOut.TabIndex = 4;
            this.btn_LogOut.Text = "LOG OUT";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
<<<<<<< HEAD
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
=======
            this.lbl_Welcome.BackColor = System.Drawing.Color.White;
            this.lbl_Welcome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.Location = new System.Drawing.Point(116, 53);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(84, 18);
            this.lbl_Welcome.TabIndex = 0;
            this.lbl_Welcome.Text = "Welcome,";
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.BackColor = System.Drawing.Color.White;
            this.lbl_FullName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FullName.Location = new System.Drawing.Point(197, 51);
>>>>>>> refs/remotes/origin/master
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(193, 22);
            this.lbl_FullName.TabIndex = 6;
            this.lbl_FullName.Text = "LASTNAME, FIRSTNAME M.I.";
<<<<<<< HEAD
            this.lbl_FullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
=======
            this.lbl_FullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Green;
            this.pictureBox2.Location = new System.Drawing.Point(-6, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(596, 15);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::frm_LogIN.Properties.Resources.Kiss_Miklos_BB_logo_20;
            this.pictureBox3.Location = new System.Drawing.Point(12, -4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(94, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
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
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(596, 97);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btn_DepositMoney
            // 
            this.btn_DepositMoney.BackgroundImage = global::frm_LogIN.Properties.Resources.deposit;
            this.btn_DepositMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DepositMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DepositMoney.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DepositMoney.Location = new System.Drawing.Point(153, 132);
            this.btn_DepositMoney.Name = "btn_DepositMoney";
            this.btn_DepositMoney.Size = new System.Drawing.Size(138, 130);
            this.btn_DepositMoney.TabIndex = 1;
            this.btn_DepositMoney.Text = "DEPOSIT MONEY";
            this.btn_DepositMoney.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_DepositMoney.UseVisualStyleBackColor = true;
            this.btn_DepositMoney.Click += new System.EventHandler(this.btn_DepositMoney_Click);
            // 
            // btn_TransferFunds
            // 
            this.btn_TransferFunds.BackgroundImage = global::frm_LogIN.Properties.Resources.transfer;
            this.btn_TransferFunds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TransferFunds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TransferFunds.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TransferFunds.Location = new System.Drawing.Point(442, 132);
            this.btn_TransferFunds.Name = "btn_TransferFunds";
            this.btn_TransferFunds.Size = new System.Drawing.Size(138, 130);
            this.btn_TransferFunds.TabIndex = 3;
            this.btn_TransferFunds.Text = "TRANSFER FUNDS";
            this.btn_TransferFunds.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_TransferFunds.UseVisualStyleBackColor = true;
            this.btn_TransferFunds.Click += new System.EventHandler(this.btn_TransferFunds_Click);
            // 
            // btn_WitdhrawMoney
            // 
            this.btn_WitdhrawMoney.BackgroundImage = global::frm_LogIN.Properties.Resources.withdraw;
            this.btn_WitdhrawMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_WitdhrawMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WitdhrawMoney.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WitdhrawMoney.Location = new System.Drawing.Point(8, 132);
            this.btn_WitdhrawMoney.Name = "btn_WitdhrawMoney";
            this.btn_WitdhrawMoney.Size = new System.Drawing.Size(138, 130);
            this.btn_WitdhrawMoney.TabIndex = 0;
            this.btn_WitdhrawMoney.Text = "WITHDRAW MONEY";
            this.btn_WitdhrawMoney.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_WitdhrawMoney.UseVisualStyleBackColor = true;
            this.btn_WitdhrawMoney.Click += new System.EventHandler(this.btn_WitdhrawMoney_Click);
            // 
            // btn_BalanceInquiry
            // 
            this.btn_BalanceInquiry.BackgroundImage = global::frm_LogIN.Properties.Resources.balance;
            this.btn_BalanceInquiry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BalanceInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BalanceInquiry.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BalanceInquiry.Location = new System.Drawing.Point(298, 132);
            this.btn_BalanceInquiry.Name = "btn_BalanceInquiry";
            this.btn_BalanceInquiry.Size = new System.Drawing.Size(138, 130);
            this.btn_BalanceInquiry.TabIndex = 2;
            this.btn_BalanceInquiry.Text = "BALANCE INQUIRY";
            this.btn_BalanceInquiry.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_BalanceInquiry.UseVisualStyleBackColor = true;
            this.btn_BalanceInquiry.Click += new System.EventHandler(this.btn_BalanceInquiry_Click);
            // 
            // lblCurrentDateAndTime
            // 
            this.lblCurrentDateAndTime.AutoSize = true;
            this.lblCurrentDateAndTime.BackColor = System.Drawing.Color.White;
            this.lblCurrentDateAndTime.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDateAndTime.Location = new System.Drawing.Point(400, 64);
            this.lblCurrentDateAndTime.Name = "lblCurrentDateAndTime";
            this.lblCurrentDateAndTime.Size = new System.Drawing.Size(41, 16);
            this.lblCurrentDateAndTime.TabIndex = 21;
            this.lblCurrentDateAndTime.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.frm_MainMenu_Load);
>>>>>>> refs/remotes/origin/master
            // 
            // frm_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(284, 216);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.lbl_FullName);
=======
            this.ClientSize = new System.Drawing.Size(589, 361);
            this.Controls.Add(this.lblCurrentDateAndTime);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_FullName);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
>>>>>>> refs/remotes/origin/master
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_DepositMoney);
            this.Controls.Add(this.btn_TransferFunds);
            this.Controls.Add(this.btn_WitdhrawMoney);
            this.Controls.Add(this.btn_BalanceInquiry);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(605, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(605, 400);
            this.Name = "frm_MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banks\' Banking - Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.frm_MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCurrentDateAndTime;
        private System.Windows.Forms.Timer timer1;
    }
}