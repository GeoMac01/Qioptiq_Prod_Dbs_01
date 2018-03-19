using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using System.IO.Ports;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

/**SQL Class attempt...**/
/**16/03/2018 V01**/

namespace Qioptiq_Prod_Dbs.Helper
{
    class SQLadaptClass
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        #region parameters
        //private static int iD = 0; //loaded with the new row index new row
        private static DataSet ds = new DataSet();
        public static string DbServerName = null;
        public static string DbName = null;
        public static string DbTableName = null;
        public static string DbUsername = null;
        public static string DbPassword = null;
        //private static string dataBaseName = null;
        #endregion
        //==========================================================================================//
        public string GetConnectionString()
        {
            /**Buildup the database path string**/
            string connectionString =   "Server = " + DbServerName + ";" + //Data Source
                                        "Database = " + DbName + ";" + //Initial catalog  
                                        "Trusted_Connection = false" + ";" +//false: user name and PW
                                        "User Id = " + DbUsername + ";" +
                                        "Password = " + DbPassword;
            return connectionString;
        }
        //==========================================================================================//
        public bool OpenSqlConnection()
        {
            /**Check if database connected**/
            try
            {
                con = new SqlConnection(GetConnectionString());
                con.Open();
                MessageBox.Show("ServerVersion: " + con.ServerVersion + "  State: " + con.State);
                con.Close();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Dtb error\n Check string\n");
                return false;
            }
        }
        //==========================================================================================//
        public DataTable FillTable(string nameTbl) { 
            
            DataTable dt = new DataTable();
            string adapterString = "SELECT * FROM " + nameTbl;
            //string adapterString = "SELECT * FROM " + nameTbl + " WHERE LaserId = (SELECT max(LaserId) FROM " + nameTbl + ")";

            try {
                con.Open();
                adapter = new SqlDataAdapter(adapterString, con);
                adapter.Fill(dt); }

            catch (Exception) {
                MessageBox.Show("DB adaptor error");
                dt.Clear();
            }

            con.Close();
            return dt;
        }
        //==========================================================================================//
        public DataSet FindTables()
            {
                /**Find the list of tables in the database for the combobox to chose from**/
                adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();

                string sql = "Select DISTINCT(name) FROM sys.Tables";

                try {
                    con.Open();
                    cmd = new SqlCommand(sql, con);
                    adapter.SelectCommand = cmd;
                    adapter.Fill(ds);
                    adapter.Dispose();
                    cmd.Dispose();
                    con.Close();
                 }
                catch (Exception) { MessageBox.Show("Cannot find tables"); }

            return ds;
            }
        //==========================================================================================//
        public DataView FindTxtInCol(string nameTbl, string express)
        {          
            DataTable tableIn = FillTable(nameTbl);//open and load table in db
            DataView view = new DataView(tableIn);
          
            DataRow[] foundRows;
            foundRows = tableIn.Select(express);

            // Print column 0 of each returned row.
            for (int i = 0; i < foundRows.Length; i++)
            {
                Debug.WriteLine(foundRows[i][0]);

            }
            return view;           
        }

        //=========================================================================================//
        //=========================================================================================//
    }
}
