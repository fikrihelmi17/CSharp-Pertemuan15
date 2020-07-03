using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient; //For SQL Server
using MySql.Data.MySqlClient; //for MySQL

namespace prjAkademik
{
    class koneksiDB
    {
        //public SqlConnection conn = null;
        public MySqlConnection conn = null;
        public string connStr;

        public void koneksi()
        {
            connStr = "Server=localhost; Database=sakila; Uid=root; Pwd=''";

            try
            {
                //conn = new SqlConnection(connStr);
                conn = new MySqlConnection(connStr);
                conn.Open();
                MessageBox.Show("Connection open");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection" + ex.ToString());
            }
        }
    }
}
