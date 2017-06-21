using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace frm_LogIN
{
    public partial class frm_WithdrawMoney : Form
    {
        frm_MainMenu mainMenu;
        Account user;
        double withdrawAmount;

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
            if (txt_Pin.Text == user.Pin.ToString())
            {
                withdrawAmount = double.Parse(txt_WithdrawAmount.Text);
                if (MessageBox.Show("Withdraw PHP " + withdrawAmount.ToString("0.00") + "?", "Confirming Withdrawal",
                    MessageBoxButtons.YesNo) == DialogResult.No)
                    MessageBox.Show("Withdrawal cancelled.");
                else
                {
                    if (withdrawAmount < 0 || withdrawAmount > user.Balance)
                        MessageBox.Show("You have entered an invalid amount to withdraw. Please try again.", "Withdrawal Error");
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

                        connection.Close();

                        MessageBox.Show("You have successfully withdrawn PHP " + withdrawAmount.ToString("0.00") +
                            "!", "Successful Withdrawal");
                        btn_Cancel.Select();
                    }
                }
            }
            else
                MessageBox.Show("Sorry. Your PIN is incorrect. Please try again.", "Incorrect PIN", MessageBoxButtons.OK);

            txt_WithdrawAmount.Text = "0.00";
            txt_Pin.Text = "";
        }
    }
}
