using System;
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
