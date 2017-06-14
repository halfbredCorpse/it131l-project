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
        SqlConnection con;

        public frm_DepositMoney()
        {
            InitializeComponent();
        }

        public frm_DepositMoney(Account user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void frm_DepositMoney_Load(object sender, EventArgs e)
        {
            mainMenu = (frm_MainMenu)Application.OpenForms[1];
        }

        private void frm_DepositMoney_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to cancel your deposit?", 
                "Exiting", MessageBoxButtons.YesNo);

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
                        con = new SqlConnection
                        (@"Data Source=(local);Initial Catalog=Project;Integrated Security=True");
                        con.Open();
                        cmd = new SqlCommand
                            ("Update Bank_Account Set Balance = Balance +" + depositAmount + "where Account_Number = '" 
                            + user.AccountNumber + "'", con);
                        cmd.ExecuteNonQuery();

                        //Adding into transaction_history
                        con = new SqlConnection
                        (@"Data Source=(local);Initial Catalog=Project;Integrated Security=True");
                        con.Open();
                        cmd = new SqlCommand
                            ("INSERT INTO Transaction_History (Transaction_Type,Amount,Date_Time,Account_Number) VALUES (@Transaction_Type,@Amount, @Date_Time, @Account_Number)", con);
                        cmd.Parameters.AddWithValue("@Transaction_Type", "Deposit");
                        cmd.Parameters.AddWithValue("@Amount", depositAmount);
                        string date1 = DateTime.Today.ToString();
                        cmd.Parameters.AddWithValue("@Date_Time", date1);
                        cmd.Parameters.AddWithValue("@Account_Number", user.AccountNumber);
                        cmd.ExecuteNonQuery();
                        //

                        MessageBox.Show("You have successfully deposited PHP " + depositAmount.ToString("0.00") +
                            "!", "Successful Withdrawal");
                    }
                }
            }
            else
                MessageBox.Show("Sorry. Your PIN is incorrect. Please try again.", "Incorrect PIN", MessageBoxButtons.OK);

            txt_DepositAmount.Text = "0.00";
            txt_Pin.Text = "";
        }
    }
}
