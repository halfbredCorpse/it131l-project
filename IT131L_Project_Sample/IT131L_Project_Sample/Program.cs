using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace IT131L_Project_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection
                ("Data Source=ERIOLH;Initial Catalog=Company1;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("select *from employees",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            for (int row = 0; row < dt.Rows.Count; row++)
            {
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    if (dt.Rows[row][col].ToString() == "" )
                        Console.WriteLine("NULL");
                    else
                    Console.WriteLine(dt.Rows[row][col].ToString());
                }
                Console.WriteLine();
            }
            Console.ReadKey();   
        }
    }
}
