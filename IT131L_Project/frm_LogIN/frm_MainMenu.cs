using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace frm_LogIN
{
    public partial class frm_MainMenu : Form
    {
        frm_Login logIn;
        frm_BalanceInquiry balanceInquiry;
        frm_WithdrawMoney withdrawMoney;
        frm_TransferFunds transferFunds;
        frm_DepositMoney depositMoney;
        Account user;
        SqlConnection connection;

        public frm_MainMenu()
        {
            InitializeComponent();
        }

        public frm_MainMenu(Account user, SqlConnection connection)
        {
            InitializeComponent();
            this.user = user;
            this.connection = connection;
        }
    
        private void frm_MainMenu_Load(object sender, EventArgs e)
        {
            logIn = (frm_Login)Application.OpenForms[0];
            logIn.Hide();

            lbl_FullName.Text = (user.Last_Name + ", " + user.First_Name).ToUpper();
        }

        private void btn_BalanceInquiry_Click(object sender, EventArgs e)
        {
            balanceInquiry = new frm_BalanceInquiry(user, connection);
            balanceInquiry.Show();
            Hide();
        }

        private void btn_WitdhrawMoney_Click(object sender, EventArgs e)
        {
            withdrawMoney = new frm_WithdrawMoney(user, connection);
            withdrawMoney.Show();
            Hide();
        }
        
        private void btn_TransferFunds_Click(object sender, EventArgs e)
        {
            transferFunds = new frm_TransferFunds(user,connection);
            transferFunds.Show();
            Hide();
        }

        private void btn_DepositMoney_Click(object sender, EventArgs e)
        {
            depositMoney = new frm_DepositMoney(user,connection);
            depositMoney.Show();
            Hide();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to log out?", "Logging out", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
                logIn.Show();
            else
                e.Cancel = true;
        }
    }
}
