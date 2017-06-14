using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace frm_LogIN
{
    public partial class frm_TransferFunds : Form
    {
        frm_MainMenu mainMenu;
        Account user, receiver;
        double transferAmount;

        SqlCommand cmd;
        SqlConnection con;

        //Temporary variables to be replaced by SQL variables
        string r_lastName, r_firstName;
        double r_balance;
        int r_accountNumber = 987654, r_pin;
        List<Transaction_History> r_transactionHistory;

        public frm_TransferFunds()
        {
            InitializeComponent();
        }

        public frm_TransferFunds(Account user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_TransferFunds_Load(object sender, EventArgs e)
        {
            mainMenu = (frm_MainMenu)Application.OpenForms[1];
        }

        private void btn_Transfer_Click(object sender, EventArgs e)
        {
            // Check if Account reciever exists in database using txt_ReceiverAccountNumber
            // If no, then display 
            // MessageBox.Show("Sorry. Account #" + txt_ReceiverAccountNumber + "does not exist. Please try again.",
            //    "Invalid User");
            // Else instantiate and proceed with code
            receiver = new Account(r_lastName, r_firstName, r_balance, r_pin, r_accountNumber, r_transactionHistory);
            // And replace variables with corresponding SQL variables

            if (txt_Pin.Text == user.Pin.ToString())
            {
                transferAmount = double.Parse(txt_TransferAmount.Text);
                if (MessageBox.Show("Transfer PHP " + transferAmount.ToString("0.00") + " to Account #" +  "?", 
                    "Confirming Transfer",
                    MessageBoxButtons.YesNo) == DialogResult.No)
                    MessageBox.Show("Transfer cancelled.");
                else
                {
                    if (transferAmount <= 0 || transferAmount > user.Balance)
                        MessageBox.Show("Invalid transfer amount. Please enter a valid amount.", "Transfer Error");
                    else
                    {
                        user.TransferFunds(transferAmount, receiver);

                        //code for user
                        con = new SqlConnection
                        (@"Data Source=(local);Initial Catalog=Project;Integrated Security=True");
                        con.Open();
                        cmd = new SqlCommand
                            ("Update Bank_Account Set Balance = Balance -" + transferAmount + "where Account_Number = '"
                            + user.AccountNumber + "'", con);
                        cmd.ExecuteNonQuery();
                        
                        //code for receiver
                        con = new SqlConnection
                        (@"Data Source=(local);Initial Catalog=Project;Integrated Security=True");
                        con.Open();
                        cmd = new SqlCommand
                            ("Update Bank_Account Set Balance = Balance +" + transferAmount + "where Account_Number = '"
                            + txt_ReceiverAccountNumber.Text + "'", con);
                        cmd.ExecuteNonQuery();

                        //Adding into transaction_history
                        con = new SqlConnection
                        (@"Data Source=(local);Initial Catalog=Project;Integrated Security=True");
                        con.Open();
                        cmd = new SqlCommand
                            ("INSERT INTO Transaction_History (Transaction_Type,Amount,Date_Time,Account_Number) VALUES (@Transaction_Type,@Amount, @Date_Time, @Account_Number)", con);
                        cmd.Parameters.AddWithValue("@Transaction_Type", "Transfer Funds");
                        cmd.Parameters.AddWithValue("@Amount", transferAmount);
                        string date1 = DateTime.Today.ToString();
                        cmd.Parameters.AddWithValue("@Date_Time", date1);
                        cmd.Parameters.AddWithValue("@Account_Number", user.AccountNumber);
                        cmd.ExecuteNonQuery();

                        con = new SqlConnection
                        (@"Data Source=(local);Initial Catalog=Project;Integrated Security=True");
                        con.Open();
                        cmd = new SqlCommand
                            ("INSERT INTO Transaction_History (Transaction_Type,Amount,Date_Time,Account_Number) VALUES (@Transaction_Type,@Amount, @Date_Time, @Account_Number)", con);
                        cmd.Parameters.AddWithValue("@Transaction_Type", "Transfer Funds");
                        cmd.Parameters.AddWithValue("@Amount", transferAmount);
                        date1 = DateTime.Today.ToString();
                        cmd.Parameters.AddWithValue("@Date_Time", date1);
                        cmd.Parameters.AddWithValue("@Account_Number", txt_ReceiverAccountNumber.Text);
                        cmd.ExecuteNonQuery();



                        MessageBox.Show("You have successfully transferred PHP " + transferAmount.ToString("0.00") +
                            "!", "Successful Transfer");
                    }
                }
            }
            else
                MessageBox.Show("Sorry. Your PIN is incorrect. Please try again.", "Incorrect PIN");
        }

        private void frm_TransferFunds_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to cancel transfer of funds?", 
                "Exiting", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
                mainMenu.Show();
            else
                e.Cancel = true;
        }
    }
}
