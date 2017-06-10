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
    public partial class Form2 : Form
    {
        ListViewItem list;
        public Form2()
        {
            InitializeComponent();
        }
        public new void Update()// display the database
        {

            SqlConnection con = new SqlConnection
              ("Data Source=ERIOLH;Initial Catalog=Company1;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("select *from Employees", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            listView1.BeginUpdate();
            
            for (int row = 0; row < dt.Rows.Count; row++)
            {
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    if (col == 0)
                    list = new ListViewItem(dt.Rows[row][col].ToString());

                    else if (col > 0)
                    {
                        if (dt.Rows[row][col].ToString() == "")
                            list.SubItems.Add("NULL");
                        else
                        list.SubItems.Add(dt.Rows[row][col].ToString());
                    }                    
                }
                listView1.Items.Add(list);
            }     
            listView1.EndUpdate();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}






/*// console app version

ListViewItem list = new ListViewItem();
    list.Text = prof.IDNum1;
    list.SubItems.Add(prof.Lname);
    list.SubItems.Add(prof.Fname);
    list.SubItems.Add(Convert.ToString(prof.Absences));
    list.SubItems.Add(Convert.ToString(prof.Lates));
    list.SubItems.Add(Convert.ToString(prof.Leaves));
    listView1.Items.Add(list); 

     for (int row = 0; row<dt.Rows.Count; row++)
     {
         for (int col = 0; col<dt.Columns.Count; col++)
         {
             if (dt.Rows[row][col].ToString() == "" )
                 Console.WriteLine("NULL");
             else
             Console.WriteLine(dt.Rows[row][col].ToString());
         }
         Console.WriteLine();
     }
     Console.ReadKey();*/
