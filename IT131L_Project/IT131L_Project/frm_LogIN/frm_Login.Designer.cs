namespace frm_LogIN
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_Pin = new System.Windows.Forms.Label();
            this.txt_Pin = new System.Windows.Forms.TextBox();
            this.txt_AccountNumber = new System.Windows.Forms.TextBox();
            this.lbl_AccountNumber = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogIn.ForeColor = System.Drawing.Color.Black;
            this.btn_LogIn.Location = new System.Drawing.Point(191, 273);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(75, 36);
            this.btn_LogIn.TabIndex = 10;
            this.btn_LogIn.Text = "LOG IN";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancel.Location = new System.Drawing.Point(285, 273);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(87, 36);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_Pin
            // 
            this.lbl_Pin.AutoSize = true;
            this.lbl_Pin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pin.Location = new System.Drawing.Point(198, 232);
            this.lbl_Pin.Name = "lbl_Pin";
            this.lbl_Pin.Size = new System.Drawing.Size(42, 20);
            this.lbl_Pin.TabIndex = 9;
            this.lbl_Pin.Text = "PIN: ";
            // 
            // txt_Pin
            // 
            this.txt_Pin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pin.Location = new System.Drawing.Point(246, 229);
            this.txt_Pin.MaxLength = 6;
            this.txt_Pin.Name = "txt_Pin";
            this.txt_Pin.Size = new System.Drawing.Size(171, 26);
            this.txt_Pin.TabIndex = 8;
            this.txt_Pin.UseSystemPasswordChar = true;
            this.txt_Pin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Pin_KeyDown);
            // 
            // txt_AccountNumber
            // 
            this.txt_AccountNumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AccountNumber.Location = new System.Drawing.Point(246, 186);
            this.txt_AccountNumber.MaxLength = 8;
            this.txt_AccountNumber.Name = "txt_AccountNumber";
            this.txt_AccountNumber.Size = new System.Drawing.Size(171, 26);
            this.txt_AccountNumber.TabIndex = 7;
            this.txt_AccountNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_AccountNumber_KeyDown);
            // 
            // lbl_AccountNumber
            // 
            this.lbl_AccountNumber.AutoSize = true;
            this.lbl_AccountNumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AccountNumber.Location = new System.Drawing.Point(97, 189);
            this.lbl_AccountNumber.Name = "lbl_AccountNumber";
            this.lbl_AccountNumber.Size = new System.Drawing.Size(143, 20);
            this.lbl_AccountNumber.TabIndex = 6;
            this.lbl_AccountNumber.Text = "Account Number: ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = global::frm_LogIN.Properties.Resources.Picture1;
            this.pictureBox4.Location = new System.Drawing.Point(94, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(437, 97);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Green;
            this.pictureBox2.Location = new System.Drawing.Point(-6, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(596, 15);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::frm_LogIN.Properties.Resources.Kiss_Miklos_BB_logo_20;
            this.pictureBox3.Location = new System.Drawing.Point(12, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(94, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(596, 97);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(175)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(218, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "ACCOUNT LOG IN";
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lbl_Pin);
            this.Controls.Add(this.txt_Pin);
            this.Controls.Add(this.txt_AccountNumber);
            this.Controls.Add(this.lbl_AccountNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(570, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(570, 400);
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banks\' Banking - Log In";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_Pin;
        protected internal System.Windows.Forms.TextBox txt_Pin;
        protected internal System.Windows.Forms.TextBox txt_AccountNumber;
        private System.Windows.Forms.Label lbl_AccountNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
    }
}

