using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Reflection;

namespace SVGH.Database
{
    class database_helper
    {
        private static string con_str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Database\\database.mdb; Persist Security Info=False;";
        private static OleDbConnection con = new OleDbConnection(con_str);
        public static OleDbCommand cmd;
        public static OleDbDataAdapter da;

        public database_helper()
        {
            openCon();
        }
        public static void DisConnection()
        {
            con.Close();
        }
        public static void openCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không kết nối được database error: " + ex.ToString());
                }
            }
        }
        public static DataTable GetDataTable(string sql)
        {
            openCon();
            cmd = new OleDbCommand(sql, con);
            da = new OleDbDataAdapter(cmd);
            DataTable db = new DataTable();
            try
            {
                da.AcceptChangesDuringFill = true;
                da.Fill(db);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.ToString());
            }
            return db;
        }
        public static bool ExcuteSQL(string sql)
        {
            openCon();
            cmd = new OleDbCommand(sql, con);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.ToString());
                return false;
            }
        }

        internal static bool ExcuteSQL1(string sql)
        {
            openCon();
            cmd = new OleDbCommand(sql, con);
            cmd.ExecuteNonQuery();
            return true;
        }

        public static int AExcuteSQL(string sql)
        {
            openCon();
            cmd = new OleDbCommand(sql, con);
            return (int)cmd.ExecuteScalar();
        }
    }
}
