using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace frm_LogIN
{
    public partial class frm_BalanceInquiry : Form
    {
        frm_MainMenu mainMenu;
        Account user;
        SqlConnection connection;

        public frm_BalanceInquiry()
        {
            InitializeComponent();
        }

        public frm_BalanceInquiry(Account user, SqlConnection connection)
        {
            InitializeComponent();
            this.user = user;
            this.connection = connection;
        }

        private void frm_BalanceInquiry_Load(object sender, EventArgs e)
        {
            mainMenu = (frm_MainMenu)Application.OpenForms[1];
            lblCurrentDate.Text = System.DateTime.Now.ToString("D");

            // Display all of the contents of Transaction_History for current user
            try
            {
                ListViewItem lvi = new ListViewItem();
                lst_TransactionHistory.Items.Clear();
                lst_TransactionHistory.BeginUpdate();

                SqlDataAdapter sda = new SqlDataAdapter
                    ("select *from Transaction_History where Account_Number = '" + user.AccountNumber + "'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    for (int col = 0; col < dt.Columns.Count; col++)
                    {
                        if (col > 0)
                        {
                            if (dt.Rows[row][col].ToString() == "")
                                lvi.SubItems.Add("NULL");

                            else
                                lvi.SubItems.Add(dt.Rows[row][col].ToString());
                        }
                        else
                            lvi = new ListViewItem(dt.Rows[row][col].ToString());

                    }
                    lst_TransactionHistory.Items.Add(lvi);
                }
                lst_TransactionHistory.EndUpdate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            



            lbl_Balance.Text = user.Balance.ToString("0.00");
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_BalanceInquiry_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainMenu.Show();
        }
    }
}
