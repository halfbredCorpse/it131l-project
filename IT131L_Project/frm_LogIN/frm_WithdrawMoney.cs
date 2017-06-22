using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;

namespace frm_LogIN
{
    public partial class frm_WithdrawMoney : Form
    {
        frm_MainMenu mainMenu;
        Account user;
        double withdrawAmount;
        int key;
        string path;

        SqlCommand cmd;
        SqlConnection connection;

        public frm_WithdrawMoney()
        {
            InitializeComponent();
        }

        public frm_WithdrawMoney(Account user, SqlConnection connection)
        {
            InitializeComponent();
            this.user = user;
            this.connection = connection;
        }

        private void frm_WithdrawMoney_Load(object sender, EventArgs e)
        {
            mainMenu = (frm_MainMenu)Application.OpenForms[1];
            lblCurrentDateAndTime.Text = String.Format("{0:f}", DateTime.Now);
        }

        private void frm_WithdrawMoney_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to cancel your withdrawal and return to Main Menu?",
                "Exiting...", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
                mainMenu.Show();
            else
                e.Cancel = true;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Withdraw_Click(object sender, EventArgs e)
        {
            int loginAttempts = 0;

            if (txt_Pin.Text == user.Pin.ToString())
            {
                if (withdrawAmount < 100 || withdrawAmount > 20000 || withdrawAmount > user.Balance)
                    MessageBox.Show("You have entered an invalid amount to withdraw. Please try again.", "Withdrawal Error");
                else if (withdrawAmount % 10 != 0 || (withdrawAmount % 100) / 10 != 0 || Math.Round(withdrawAmount - Math.Truncate(withdrawAmount), 2) != 0)
                    MessageBox.Show("Withdrawal Amount should be multiples of 100.", "Withdrawal Error");
                else if (MessageBox.Show("Withdraw PHP " + withdrawAmount.ToString("0.00") + "?", "Confirming Withdrawal",
                        MessageBoxButtons.YesNo) == DialogResult.No)
                    MessageBox.Show("Withdrawal cancelled.");
                else
                {
                    user.WithdrawMoney(withdrawAmount);

                    // deducting withdrawmoney to balance
                    connection.Open();
                    cmd = new SqlCommand
                        ("Update Bank_Account Set Balance = Balance -" + withdrawAmount + "where Account_Number = '"
                        + user.AccountNumber + "'", connection);
                    cmd.ExecuteNonQuery();

                    //Adding into transaction_history
                    //cmd = new SqlCommand
                    //    ("INSERT INTO Transaction_History (Transaction_Type,Amount,Date_Time,Account_Number) VALUES (@Transaction_Type,@Amount, @Date_Time, @Account_Number)", connection);
                    cmd.CommandText = "INSERT INTO Transaction_History (Transaction_Number,Transaction_Type,Amount,Date_Time,Account_Number) VALUES (NEXT VALUE FOR Transac_Number_Seq, @Transaction_Type,@Amount, @Date_Time, @Account_Number)";
                    cmd.Parameters.AddWithValue("@Transaction_Type", "Withdrawal");
                    cmd.Parameters.AddWithValue("@Amount", withdrawAmount);
                    DateTime date1 = DateTime.Now;
                    cmd.Parameters.AddWithValue("@Date_Time", date1);
                    cmd.Parameters.AddWithValue("@Account_Number", user.AccountNumber);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("You have successfully withdrawn PHP " + withdrawAmount.ToString("0.00") +
                        "!", "Successful Withdrawal");

                    DialogResult receiptBox = MessageBox.Show("Do you want to print a receipt?", "Print receipt?", MessageBoxButtons.YesNo);
                    if (receiptBox == DialogResult.Yes)
                    {
                        //RECEIPT
                        cmd = new SqlCommand("SELECT current_value FROM sys.sequences WHERE name = 'Transac_Number_Seq'", connection);
                        SqlDataReader reader = cmd.ExecuteReader();

                        path = @"..\Receipts";
                        if (!Directory.Exists(path))
                            Directory.CreateDirectory(path);

                        while (reader.Read())
                        {
                            string receipt = "Accout Number: " + user.AccountNumber + "\nTransaction Number: " +
                                reader["current_value"].ToString() + "\nTransaction Type: WITHDRAWAL\nAmount: PHP " +
                                Math.Round(withdrawAmount, 2) + "\nRemaining Balance: PHP " + Math.Round(user.Balance);

                            File.WriteAllText(Path.Combine(path, reader["current_value"].ToString() + ".txt"), receipt);
                        }

                        //END RECEIPT
                        MessageBox.Show("Your receipt has been successfully printed!");
                    }

                    connection.Close();
                    btn_Cancel.Select();   
                }
            }
            else
            {
                MessageBox.Show("Sorry. Your PIN is incorrect. Please try again.", "Incorrect PIN", MessageBoxButtons.OK);
                loginAttempts++;

                if (loginAttempts == 3)
                {
                    MessageBox.Show("You have exceeded the number of allowed attempts to enter your PIN. \nYour withdrawal will now be canceled.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
            }
                

            txt_WithdrawAmount.Text = "0.00";
            txt_Pin.Text = "";
            txt_WithdrawAmount.Select();
        }

        private void txt_WithdrawAmount_Leave(object sender, EventArgs e)
        {
            try
            {
                withdrawAmount = double.Parse(txt_WithdrawAmount.Text);
                txt_WithdrawAmount.Text = String.Format("{0:N2}", withdrawAmount);
            }
            catch
            { }
        }

        private void txt_WithdrawAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (key == 0)
                txt_WithdrawAmount.Text = "";
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (Regex.IsMatch(txt_WithdrawAmount.Text, @"\.\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            key = 1;
        }
    }
}
