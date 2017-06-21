using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace frm_LogIN
{
    public partial class frm_DepositMoney : Form
    {
        frm_MainMenu mainMenu;
        Account user;
        double depositAmount;

        SqlCommand cmd;
        SqlConnection connection;

        public frm_DepositMoney()
        {
            InitializeComponent();
        }

        public frm_DepositMoney(Account user, SqlConnection connection)
        {
            InitializeComponent();
            this.user = user;
            this.connection = connection;
        }

        private void frm_DepositMoney_Load(object sender, EventArgs e)
        {
            mainMenu = (frm_MainMenu)Application.OpenForms[1];
            lblCurrentDateAndTime.Text = String.Format("{0:f}", DateTime.Now);
        }

        private void frm_DepositMoney_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to cancel your deposit and return to Main Menu?",
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

        private void btn_Deposit_Click(object sender, EventArgs e)
        {
            int loginAttempts = 0;

            if (txt_Pin.Text == user.Pin.ToString())
            {
                depositAmount = double.Parse(txt_DepositAmount.Text);
                if (MessageBox.Show("Deposit PHP " + depositAmount.ToString("0.00") + "?", "Confirming Deposit",
                    MessageBoxButtons.YesNo) == DialogResult.No)
                    MessageBox.Show("Deposit cancelled.");
                else
                {
                    if (depositAmount <= 0)
                        MessageBox.Show("Invalid deposit amount. Please enter a valid amount.", "Deposit Error");
                    else
                    {
                        user.DepositMoney(depositAmount);

                        //Adding depositMoney to balance
                        connection.Open();
                        cmd = new SqlCommand
                            ("Update Bank_Account Set Balance = Balance +" + depositAmount + "where Account_Number = '" 
                            + user.AccountNumber + "'", connection);
                        cmd.ExecuteNonQuery();

                        //Adding into transaction_history
                        //cmd = new SqlCommand
                        //    ("INSERT INTO Transaction_History (Transaction_Type,Amount,Date_Time,Account_Number) VALUES (@Transaction_Type,@Amount, @Date_Time, @Account_Number)", connection);
                        cmd.CommandText = "INSERT INTO Transaction_History (Transaction_Number,Transaction_Type,Amount,Date_Time,Account_Number) VALUES (NEXT VALUE FOR Transac_Number_Seq, @Transaction_Type,@Amount, @Date_Time, @Account_Number)";
                        cmd.Parameters.AddWithValue("@Transaction_Type", "Deposit");
                        cmd.Parameters.AddWithValue("@Amount", depositAmount);
                        DateTime date1 = DateTime.Now;
                        cmd.Parameters.AddWithValue("@Date_Time", date1);
                        cmd.Parameters.AddWithValue("@Account_Number", user.AccountNumber);
                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("You have successfully deposited PHP " + depositAmount.ToString("0.00") +
                            "!", "Successful Withdrawal");
                        btn_Cancel.Select();
                    }
                }
            }
            else
            {
                MessageBox.Show("Sorry. Your PIN is incorrect. Please try again.", "Incorrect PIN", MessageBoxButtons.OK);
                loginAttempts++;

                if (loginAttempts == 3)
                {
                    MessageBox.Show("You have exceeded the number of allowed attempts to enter your PIN. \nYour deposit will now be canceled.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
            }
                

            txt_DepositAmount.Text = "0.00";
            txt_Pin.Text = "";
        }
    }
}
