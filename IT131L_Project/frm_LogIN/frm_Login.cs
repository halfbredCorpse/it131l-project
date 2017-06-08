<<<<<<< HEAD
﻿using System;
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
        SqlConnection con;
        string query;
        SqlDataAdapter sda;
        DataTable dtbl;
        DataRow[] selected;

        public frm_Login()
        {
            InitializeComponent();
        }

        private void Login()
        {
             if (string.IsNullOrEmpty(txt_AccountNumber.Text))
            {
                MessageBox.Show("Please enter your Account Number.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_AccountNumber.Focus();
                return;
            }
            try
            {
                accountNumber = txt_AccountNumber.Text.Trim();
                pin = txt_Pin.Text.Trim();

                con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True"); // put Connection String
                query = "SELECT * FROM Bank_Account where Account_Number = '" + accountNumber + "' AND PIN = '" + pin + "'";
                sda = new SqlDataAdapter(query, con);
                dtbl = new DataTable();
                sda.Fill(dtbl);
                selected = dtbl.Select();

                if (dtbl.Rows.Count == 1)
                {
                    foreach (DataRow row in selected)
                        user = new Account(row["Last_Name"].ToString(), row["First_Name"].ToString(), double.Parse(row["Balance"].ToString()), int.Parse(row["PIN"].ToString()), int.Parse(row["Account_Number"].ToString()), new List<Transaction_History>());

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

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void txt_AccountNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                Login();
        }

        private void txt_Pin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Login();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace frm_LogIN
{
    public partial class frm_Login : Form
    {
        frm_MainMenu mainMenu;
        Account user;
        string accountNumber, pin;

        //Temporary Variables to be replaced with SQL variables
        string temp_accountNumber = "12345678";
        string temp_pin = "123456";
        List<Transaction_History> transactionHistory;

        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            accountNumber = txt_AccountNumber.Text;
            pin = txt_Pin.Text;

            if (accountNumber != temp_accountNumber)
                MessageBox.Show("Account does not exist. Please try again.", "Invalid user");
            else if (pin != temp_pin)
                MessageBox.Show("PIN and Account Number do not match. Please try again.", "Invalid PIN");
            else
            {
                // Search for User in Database using txt_AccountNumber
                // If User doesn't exist in Database, display this message
                // MessageBox.Show("Sorry. Account #" + txt_ReceiverAccountNumber + "does not exist. Please try again.",
                //    "Invalid User");
                // Else instantiate user as follows
                user = new Account("Aguas", "Nathanael", 12345678.90, 123456, 12345678, transactionHistory);
                //And replace credentails with SQL Variables
                mainMenu = new frm_MainMenu(user);
                mainMenu.Show();
            }

            txt_AccountNumber.Text = "";
            txt_Pin.Text = "";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
>>>>>>> master
