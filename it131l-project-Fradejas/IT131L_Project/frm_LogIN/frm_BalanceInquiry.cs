using System;
using System.Windows.Forms;

namespace frm_LogIN
{
    public partial class frm_BalanceInquiry : Form
    {
        frm_MainMenu mainMenu;
        Account user;

        public frm_BalanceInquiry()
        {
            InitializeComponent();
        }

        public frm_BalanceInquiry(Account user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void frm_BalanceInquiry_Load(object sender, EventArgs e)
        {
            mainMenu = (frm_MainMenu)Application.OpenForms[1];

            // Display all of the contents of Transaction_History for current user
            lbl_Balance.Text = user.Balance.ToString("0.00");
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_BalanceInquiry_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainMenu.Enabled = true;
        }
    }
}
