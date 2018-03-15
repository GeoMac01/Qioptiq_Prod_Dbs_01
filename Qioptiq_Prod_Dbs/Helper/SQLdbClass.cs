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


namespace Qioptiq_Prod_Dbs
{
    class SQLadaptClass
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int iD = 0; //loaded with the new row index new row
        public static string DbServerName = string.Empty;
        public static string DbName = string.Empty;
        public static string DbTableName = string.Empty;
        public static string DbUsername = string.Empty;
        public static string DbPassword = string.Empty;
        private static string dataBaseName = string.Empty;

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
                OpenSqlConnection();
                con = new SqlConnection(GetConnectionString());
                MessageBox.Show("ServerVersion: " + con.ServerVersion + "  State: " + con.State);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Dtb Error " + e.ToString());
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

            adapt = new SqlDataAdapter(adapterString, con);

            try
            {
                adapt.Fill(dt);
                dtGrd.DataSource = dt;
            }
            catch (Exception e) { MessageBox.Show("DB adaptor error" + e.ToString()); }

            con.Close();

            return true;
        }
//==========================================================================================//



        //=========================================================================================//
        //=========================================================================================//
    }
}
