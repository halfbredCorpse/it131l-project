using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WritingDataToSQL
{
    public partial class Form3 : Form
    {
        public ListView lv = new ListView();
        ListViewItem lvi = new ListViewItem();

        public Form3()
        {
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            lv.Bounds = new Rectangle(new Point(0, 0), new Size(350, 300));
            lv.View = View.Details;
            lv.LabelEdit = false;
            lv.Columns.Add("ID",90);
            lv.Columns.Add("Name", 90);
            lv.Columns.Add("EID", 90);
            lv.Columns.Add("Gender", 90);

            this.Text="EmpTable";
            this.Controls.Add(lv);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            
            
        }
        public new void Update()
        {
            lv.BeginUpdate();

            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            SqlConnection con = new SqlConnection
             ("Data Source=ERIOLH;Initial Catalog=MyDatabase;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("select *from EmpTable", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            

            for (int row = 0; row < dt.Rows.Count; row++)
            {
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    if (col == 0)
                        lvi = new ListViewItem(dt.Rows[row][col].ToString());

                    else if (col > 0)
                    {
                        if (dt.Rows[row][col].ToString() == "")
                            lvi.SubItems.Add("NULL");
                        else
                            lvi.SubItems.Add(dt.Rows[row][col].ToString());
                    }
                }
                lv.Items.Add(lvi);
            }
            lv.EndUpdate();

        }
    }
}
