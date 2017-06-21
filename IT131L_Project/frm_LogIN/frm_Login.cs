using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;

namespace frm_LogIN
{
    public partial class frm_Login : Form
    {
        frm_MainMenu mainMenu;
        Account user;
        string accountNumber, pin;
        SqlConnection connection;
        string query;
        SqlDataAdapter sda;
        SqlCommand cmd;
        DataTable dtbl;
        DataRow[] selected;
        int loginAttempts;

        public frm_Login()
        {
            InitializeComponent();
        }

        private void Login()
        {

            if (string.IsNullOrEmpty(txt_AccountNumber.Text))
            {
                MessageBox.Show("Please enter your Account Number.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_AccountNumber.Focus();
                return;
            }
            try
            {
                accountNumber = txt_AccountNumber.Text;
                pin = txt_Pin.Text;

                connection = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=Project;Integrated Security=True");
                query = "SELECT * FROM Bank_Account where Account_Number = '" + accountNumber + "' AND PIN = '" + pin + "'";
                sda = new SqlDataAdapter(query, connection);
                dtbl = new DataTable();
                sda.Fill(dtbl);
                selected = dtbl.Select();

                if (dtbl.Rows.Count == 1)
                {
                    foreach (DataRow row in selected)
                        user = new Account(row["Last_Name"].ToString(), row["First_Name"].ToString(), double.Parse(row["Balance"].ToString()), row["PIN"].ToString(), int.Parse(row["Account_Number"].ToString()), new List<Transaction_History>());

                    MessageBox.Show("You have successfully logged in.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mainMenu = new frm_MainMenu(user, connection);
                    mainMenu.Show();
                }
                else
                {
                    loginAttempts++;
                    MessageBox.Show("Your Account Number or PIN is incorrect.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_AccountNumber.Select();

                    if (loginAttempts == 3)
                    {
                        MessageBox.Show("You have exceeded the number of allowed login attempts. \nPlease try again later.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                }

                txt_AccountNumber.Clear();
                txt_Pin.Clear();

                dtbl.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
           
            Login();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            // NOTE: QUERIES.sql is in C:\Users\<User>\Documents\GitHub\it131l-project\IT131L_Project\frm_LogIN\bin\Debug
            connection = new SqlConnection("Server=.\\SQLEXPRESS;Trusted_Connection=yes;Database=master");
            // Checks if database exists
            using (connection)
            {
                using (cmd = new SqlCommand("SELECT database_id FROM sys.databases WHERE name = 'Project'", connection))
                {
                    try
                    {
                        connection.Open();
                        if (cmd.ExecuteScalar() == null)
                        {
                            query = "CREATE DATABASE Project";
                            cmd.CommandText = query;
                            cmd.ExecuteNonQuery();

                            connection.Close();

                            connection.ConnectionString = "Data Source=.\\SQLExpress;Initial Catalog=Project;Integrated Security=True";

                            string script = File.ReadAllText(Path.GetDirectoryName(Application.ExecutablePath) + "\\QUERIES.sql");
                            IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

                            connection.Open();
                            foreach (string commandString in commandStrings)
                            {
                                if (commandString.Trim() != "")
                                {
                                    using (SqlCommand command = new SqlCommand(commandString, connection))
                                    {
                                        command.ExecuteNonQuery();
                                    }
                                }
                            }
                            connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
