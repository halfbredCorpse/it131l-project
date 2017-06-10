using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WritingDataToSQL
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        
        // SqlDataAdapter da;
        Form2 frm2 = new Form2();
        Form3 frm3 = new Form3();
        Form4 frm4 = new Form4();
       

        public Form1()
        {
            InitializeComponent();
            frm2.Show();
            frm3.Show();
           
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            frm2.Update();
            frm3.Update();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con = new SqlConnection
                (@"Data Source=ERIOLH;Initial Catalog=MyDatabase;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand
                ("INSERT INTO EmpTable (Name,Eid,Gender) VALUES (@Name, @Eid, @Gender)", con);
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Eid", textBox1.Text);
            cmd.Parameters.AddWithValue("@Gender", comboBox1.SelectedItem.ToString());
            cmd.ExecuteNonQuery();



            MessageBox.Show
            ("You have inputted:\nName: " +
           textBox2.Text +
           "\nEid: " +
           textBox1.Text +
           "\nGender: " +
           comboBox1.SelectedItem.ToString());

            textBox1.ResetText();
            textBox2.ResetText();
            comboBox1.ResetText();


            frm3.Update();

        }
    }
}
