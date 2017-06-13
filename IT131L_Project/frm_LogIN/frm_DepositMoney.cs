using System;
using System.Windows.Forms;

namespace frm_LogIN
{
    public partial class frm_DepositMoney : Form
    {
        frm_MainMenu mainMenu;
        Account user;
        double depositAmount;

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
