using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace frm_LogIN
{
    public partial class frm_TransferFunds : Form
    {
        frm_MainMenu mainMenu;
        Account user, receiver;
        double transferAmount;
        int key; //checks the number of times the key is pressed 

        SqlCommand cmd;
        SqlConnection connection;

        //Temporary variables to be replaced by SQL variables
        string r_lastName, r_firstName, r_pin;
        double r_balance;
        int r_accountNumber;
        List<Transaction_History> r_transactionHistory;

        public frm_TransferFunds()
        {
            InitializeComponent();
        }

        public frm_TransferFunds(Account user, SqlConnection connection)
        {
            InitializeComponent();
            this.user = user;
            this.connection = connection;

            key = 0;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_TransferFunds_Load(object sender, EventArgs e)
        {
            mainMenu = (frm_MainMenu)Application.OpenForms[1];
            lblCurrentDateAndTime.Text = String.Format("{0:f}", DateTime.Now);
        }

        private void txt_TransferAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (key == 0)
                txt_TransferAmount.Text = "";
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if(Regex.IsMatch(txt_TransferAmount.Text, @"\.\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            key = 1;
        }

        private void txt_TransferAmount_Leave(object sender, EventArgs e)
        {
            try
            {
                transferAmount = double.Parse(txt_TransferAmount.Text);
                txt_TransferAmount.Text = String.Format("{0:N2}", transferAmount);
            }
            catch
            { }
        }

        private void txt_ReceiverAccountNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Pin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_TransferAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                e.Handled = true;
            }
        }

        private void btn_Transfer_Click(object sender, EventArgs e)
        {
            int loginAttempts = 0;

            if (txt_Pin.Text == user.Pin.ToString())
            {
                try
                {
                    transferAmount = double.Parse(txt_TransferAmount.Text);
                    if (transferAmount <= 0 || transferAmount > user.Balance)
                        MessageBox.Show("Invalid transfer amount. Please enter a valid amount.", "Transfer Error");
                    else
                    {
                        connection.Open();

                        cmd = new SqlCommand("SELECT *" +
                               " FROM Bank_Account" +
                               " WHERE Account_Number = '" + txt_ReceiverAccountNumber.Text + "'", connection);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            TransferValidAmount(reader);
                        }

                        connection.Close();
                    }
                }
                catch
                {
                  
                }
            }
            else
            {
                MessageBox.Show("Sorry. Your PIN is incorrect. Please try again.", "Incorrect PIN");
                loginAttempts++;

                if (loginAttempts == 3)
                {
                    MessageBox.Show("You have exceeded the number of allowed attempts to enter your PIN. \nYour transfer will now be canceled.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
            }
        }

        private void frm_TransferFunds_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to cancel transfer of funds and return to Main Menu?", 
                "Exiting...", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
                mainMenu.Show();
            else
            {
                e.Cancel = true;
                key = 0;

                txt_Pin.Text = "";
                txt_ReceiverAccountNumber.Text = "";
                txt_TransferAmount.Text = "0.00";
                key = 0;

                txt_TransferAmount.Select();
            }
        }

        // An extension of btnTransfer 
        public void TransferValidAmount(SqlDataReader reader)
        {
            // Check if Account reciever exists in database using txt_ReceiverAccountNumber
            if (reader.HasRows)
            {
                if (MessageBox.Show("Transfer PHP " + transferAmount.ToString("0.00") + " to Account No. " + txt_ReceiverAccountNumber.Text + "?", "Confirming Transfer", MessageBoxButtons.YesNo) == DialogResult.No)
                    MessageBox.Show("Transfer cancelled.");
                else
                {
                    while (reader.Read())
                    {
                        r_lastName = reader["Last_Name"].ToString();
                        r_firstName = reader["First_Name"].ToString();
                        r_balance = double.Parse(reader["Balance"].ToString());
                        r_pin = reader["PIN"].ToString();
                        r_accountNumber = int.Parse(reader["Account_Number"].ToString());
                        r_transactionHistory = new List<Transaction_History>();
                        receiver = new Account(r_lastName, r_firstName, r_balance, r_pin, r_accountNumber, r_transactionHistory);
                    }

                    reader.Close();

                    user.TransferFunds(transferAmount, receiver);

                    //code for user
                    //cmd = new SqlCommand
                    //    ("Update Bank_Account Set Balance = Balance -" + transferAmount + "where Account_Number = '"
                    //    + user.AccountNumber + "'", connection);
                    cmd.CommandText = "Update Bank_Account Set Balance = Balance -" + transferAmount + "where Account_Number = '"
                        + user.AccountNumber + "'";
                    cmd.ExecuteNonQuery();

                    //code for receiver
                    //cmd = new SqlCommand
                    //    ("Update Bank_Account Set Balance = Balance +" + transferAmount + "where Account_Number = '"
                    //    + txt_ReceiverAccountNumber.Text + "'", connection);
                    cmd.CommandText = "Update Bank_Account Set Balance = Balance +" + transferAmount + "where Account_Number = '"
                        + txt_ReceiverAccountNumber.Text + "'";
                    cmd.ExecuteNonQuery();

                    //Adding into transaction_history - Current user
                    //cmd = new SqlCommand
                    //    ("INSERT INTO Transaction_History (Transaction_Type,Amount,Date_Time,Account_Number) VALUES (@Transaction_Type,@Amount, @Date_Time, @Account_Number)", connection);
                    cmd.CommandText = "INSERT INTO Transaction_History (Transaction_Number,Transaction_Type,Amount,Date_Time,Account_Number) VALUES (NEXT VALUE FOR Transac_Number_Seq, @Transaction_Type,@Amount, @Date_Time, @Account_Number)";
                    cmd.Parameters.AddWithValue("@Transaction_Type", "Transferred to " + txt_ReceiverAccountNumber.Text);
                    cmd.Parameters.AddWithValue("@Amount", transferAmount);
                    cmd.Parameters.AddWithValue("@Date_Time", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Account_Number", user.AccountNumber);
                    cmd.ExecuteNonQuery();

                    //Receiver
                    //cmd = new SqlCommand
                    //    ("INSERT INTO Transaction_History (Transaction_Type,Amount,Date_Time,Account_Number) VALUES (@Transaction_Type,@Amount, @Date_Time, @Account_Number)", connection);
                    cmd.CommandText = "INSERT INTO Transaction_History (Transaction_Number,Transaction_Type,Amount,Date_Time,Account_Number) VALUES (NEXT VALUE FOR Transac_Number_Seq,@Transaction_Type,@Amount, @Date_Time, @Account_Number)";
                    cmd.Parameters["@Transaction_Type"].Value = "Received from " + user.AccountNumber;
                    cmd.Parameters["@Amount"].Value = transferAmount;
                    cmd.Parameters["@Date_Time"].Value = DateTime.Now;
                    cmd.Parameters["@Account_Number"].Value = txt_ReceiverAccountNumber.Text;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("You have successfully transferred PHP " + transferAmount.ToString("0.00") +
                        "!", "Successful Transfer");
                    btn_Cancel.Select();
                }
            }
            // If no Account user
            else
            {
                MessageBox.Show("Sorry, the acccount #" + txt_ReceiverAccountNumber.Text + " does not exist. Please try again.",
                   "Invalid User");
            }
        }
    }
}
