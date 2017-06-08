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
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_Pin = new System.Windows.Forms.Label();
            this.txt_Pin = new System.Windows.Forms.TextBox();
            this.txt_AccountNumber = new System.Windows.Forms.TextBox();
            this.lbl_AccountNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Location = new System.Drawing.Point(111, 60);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(75, 23);
            this.btn_LogIn.TabIndex = 10;
            this.btn_LogIn.Text = "LOG IN";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(195, 60);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_Pin
            // 
            this.lbl_Pin.AutoSize = true;
            this.lbl_Pin.Location = new System.Drawing.Point(74, 36);
            this.lbl_Pin.Name = "lbl_Pin";
            this.lbl_Pin.Size = new System.Drawing.Size(31, 13);
            this.lbl_Pin.TabIndex = 9;
            this.lbl_Pin.Text = "PIN: ";
            // 
            // txt_Pin
            // 
            this.txt_Pin.Location = new System.Drawing.Point(111, 33);
            this.txt_Pin.MaxLength = 6;
            this.txt_Pin.Name = "txt_Pin";
            this.txt_Pin.PasswordChar = '*';
            this.txt_Pin.Size = new System.Drawing.Size(160, 20);
            this.txt_Pin.TabIndex = 8;
            // 
            // txt_AccountNumber
            // 
            this.txt_AccountNumber.Location = new System.Drawing.Point(111, 6);
            this.txt_AccountNumber.MaxLength = 8;
            this.txt_AccountNumber.Name = "txt_AccountNumber";
            this.txt_AccountNumber.Size = new System.Drawing.Size(160, 20);
            this.txt_AccountNumber.TabIndex = 7;
            // 
            // lbl_AccountNumber
            // 
            this.lbl_AccountNumber.AutoSize = true;
            this.lbl_AccountNumber.Location = new System.Drawing.Point(12, 9);
            this.lbl_AccountNumber.Name = "lbl_AccountNumber";
            this.lbl_AccountNumber.Size = new System.Drawing.Size(93, 13);
            this.lbl_AccountNumber.TabIndex = 6;
            this.lbl_AccountNumber.Text = "Account Number: ";
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 94);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lbl_Pin);
            this.Controls.Add(this.txt_Pin);
            this.Controls.Add(this.txt_AccountNumber);
            this.Controls.Add(this.lbl_AccountNumber);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 133);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 133);
            this.Name = "frm_Login";
            this.Text = "Banks Banking - Log In";
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
    }
}

