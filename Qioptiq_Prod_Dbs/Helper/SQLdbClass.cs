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
using Microsoft.VisualBasic;


namespace Qioptiq_Prod_Dbs.Helper
{
    class SQLadaptClass
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        #region parameters
        private static int iD = 0; //loaded with the new row index new row
        private static DataSet ds = new DataSet();
        public static string DbServerName = null;
        public static string DbName = null;
        public static string DbTableName = null;
        public static string DbUsername = null;
        public static string DbPassword = null;
        private static string dataBaseName = null;
        #endregion
        //==========================================================================================//
        public string GetConnectionString()
        {
            string connectionString = "Server = " + DbServerName + ";" + //Data Source
                                        "Database = " + DbName + ";" + //Initial catalog  
                                        "Trusted_Connection = false" + ";" +//false: user name and PW
                                        "User Id = " + DbUsername + ";" +
                                        "Password = " + DbPassword;

            return connectionString;
        }
//==========================================================================================//
        public bool OpenSqlConnection()
        {
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
                //MessageBox.Show("Dtb Error " + e.ToString());
                MessageBox.Show("Dtb error\n Check string\n");
                return false;
            }
        }
//==========================================================================================//
        public bool DisplayData(string nameDb, DataGridView dtGrd)
        {//will display the highest entry number needs sync....

            con.Open();
            DataTable dt = new DataTable();

            cmd = new SqlCommand("select count(*) from " + nameDb, con);
            int TbRow = ((int)cmd.ExecuteScalar());

            string adapterString = "SELECT * FROM" + nameDb + "WHERE LaserId = (SELECT max(LaserId) FROM" + dataBaseName + ")";

            //adapt = new SqlDataAdapter(adapterString, con);

            try
            {
                //adapt.Fill(dt);
                dtGrd.DataSource = dt;
            }
            catch (Exception e) { MessageBox.Show("DB adaptor error" + e.ToString()); }

            con.Close();

            return true;
        }
//==========================================================================================//
        public DataSet FindTables()
            {
                adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                int i = 0;
                string sql = null;

                sql = "Select DISTINCT(name) FROM sys.Tables";


                try
                {
                   // connection.Open();
                    cmd = new SqlCommand(sql, con);
                    adapter.SelectCommand = cmd;
                    adapter.Fill(ds);
                    adapter.Dispose();
                    cmd.Dispose();
                    con.Close();

                    for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                    {
                        MessageBox.Show(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                    }
                }
                catch (Exception) { MessageBox.Show("Cannot find tables"); }

            return ds;
            }
//==========================================================================================//




    //=========================================================================================//
    //=========================================================================================//
}
}
