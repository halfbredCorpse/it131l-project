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
        SqlConnection con;

        public frm_WithdrawMoney()
        {
            InitializeComponent();
        }

        public frm_WithdrawMoney(Account user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void frm_WithdrawMoney_Load(object sender, EventArgs e)
        {
            mainMenu = (frm_MainMenu)Application.OpenForms[1];
        }

        private void frm_WithdrawMoney_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to cancel your withdrawal?", "Exiting", MessageBoxButtons.YesNo);

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
                        con = new SqlConnection
                        (@"Data Source=(local);Initial Catalog=Project;Integrated Security=True");
                        con.Open();
                        cmd = new SqlCommand
                            ("Update Bank_Account Set Balance = Balance -" + withdrawAmount + "where Account_Number = '"
                            + user.AccountNumber + "'", con);
                        cmd.ExecuteNonQuery();

                        //Adding into transaction_history
                        con = new SqlConnection
                        (@"Data Source=(local);Initial Catalog=Project;Integrated Security=True");
                        con.Open();
                        cmd = new SqlCommand
                            ("INSERT INTO Transaction_History (Transaction_Type,Amount,Date_Time,Account_Number) VALUES (@Transaction_Type,@Amount, @Date_Time, @Account_Number)", con);
                        cmd.Parameters.AddWithValue("@Transaction_Type", "Withdrawal");
                        cmd.Parameters.AddWithValue("@Amount", withdrawAmount);
                        string date1 = DateTime.Today.ToString();
                        cmd.Parameters.AddWithValue("@Date_Time", date1);
                        cmd.Parameters.AddWithValue("@Account_Number", user.AccountNumber);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("You have successfully withdrawn PHP " + withdrawAmount.ToString("0.00") +
                            "!", "Successful Withdrawal");
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
