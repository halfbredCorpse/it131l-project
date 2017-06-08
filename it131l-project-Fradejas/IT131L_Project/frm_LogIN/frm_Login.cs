using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace frm_LogIN
{
    public partial class frm_Login : Form
    {
        frm_MainMenu mainMenu;
        Account user;
        string accountNumber, pin;

        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_AccountNumber.Text))
            {
                MessageBox.Show("Please enter your Account Number.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_AccountNumber.Focus();
                return;
            }
            try
            {
                    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=TESTDB;Integrated Security=True"); // put Connection String
                    
                    string query = "SELECT * FROM Bank_Account where Account_Number = '" + txt_AccountNumber.Text.Trim() + "' AND PIN = '" + txt_Pin.Text.Trim() + "'";

                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                
                    if (dtbl.Rows.Count == 1)
                    {
                        MessageBox.Show("You have successfully logged in.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mainMenu = new frm_MainMenu(user);
                        mainMenu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Your Account Number or PIN is incorrect.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //txt_AccountNumber.Clear();
                    txt_Pin.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
