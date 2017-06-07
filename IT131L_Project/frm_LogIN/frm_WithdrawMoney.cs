using System;
using System.Windows.Forms;

namespace frm_LogIN
{
    public partial class frm_WithdrawMoney : Form
    {
        frm_MainMenu mainMenu;
        Account user;
        double withdrawAmount;

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
                mainMenu.Enabled = true;
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
