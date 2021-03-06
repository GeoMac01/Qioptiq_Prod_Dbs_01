﻿using System;
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
using System.IO;//use with file and stream

/**SQL Class attempt...**/
/**20/03/2018 V01**/

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
        public DataSet FindTables()
        {
            /**Find the list of tables in the database for the combobox to chose from**/
            adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();

            string sql = "Select DISTINCT(name) FROM sys.Tables";

            try
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
                adapter.Dispose();
                cmd.Dispose(); }
            catch (Exception) { MessageBox.Show("Cannot find tables"); }

            con.Close();

            return ds;
        }
        //==========================================================================================//
        public DataTable FillTable(string nameTbl, string colToOrder) {

            string adapterString = null;
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                adapterString = "SELECT * FROM " + nameTbl;
                adapter = new SqlDataAdapter(adapterString, con);
                dt.Clear();
                adapter.Fill(dt);
                adapter.Dispose();
                cmd.Dispose();

                if (dt.Columns.Contains(colToOrder))  {
                    adapterString = "SELECT * FROM " + nameTbl + " ORDER BY " + colToOrder;
                    adapter = new SqlDataAdapter(adapterString, con);
                    dt.Clear();
                    adapter.Fill(dt);
                    adapter.Dispose();
                    cmd.Dispose();
                }
                con.Close();
            }
            catch (Exception) { MessageBox.Show("DB adaptor error"); }

            con.Close();
            return dt;
        }
        //=========================================================================================//
        public DataTable FindTxtInCol2(string tableToLook, string theString)
        {
            DataTable dt = new DataTable();
            dt.Clear();

            string adapterString = theString;

            try {
                con.Open();
                adapter = new SqlDataAdapter(adapterString, con);
                adapter.Fill(dt);
                adapter.Dispose();
                cmd.Dispose(); }

            catch (Exception) { MessageBox.Show("DB adaptor error"); }

            con.Close();

            if(dt.Rows.Count == 0) { MessageBox.Show("DataTable empty"); }

            return dt;

        }
        //=========================================================================================//
        public void SaveTxtFileToTable(string fileLocation)
        {
            string filePath = fileLocation;

            con.Open();

                // create table if not exists 
                //string createTableQuery = @"Create Table [MyTable](ID int, [FileData] varbinary(max))";
                //SqlCommand command = new SqlCommand(createTableQuery, con);
                //command.ExecuteNonQuery();

                // Converts text file(.txt) into byte[]
                byte[] fileData = File.ReadAllBytes(filePath);

                string insertQuery = @"Insert Into iFLEX_iRIS_LI_Results (Laser_Assy_Sn, LI_Txt_Results) Values(1, @LI_Txt_Results)";

                // Insert text file Value into Sql Table by SqlParameter
                SqlCommand insertCommand = new SqlCommand(insertQuery, con);
                SqlParameter sqlParam = insertCommand.Parameters.AddWithValue("@LI_Txt_Results", fileData);
                sqlParam.DbType = DbType.Binary;
                insertCommand.ExecuteNonQuery();

            con.Close();

        }
        //=========================================================================================//
        public void LoadTxtFileFromTable(string lsSn)//get the laser serial number
        {
                con.Open();

                string selectQuery = "Select [LI_Txt_Results] From [iFLEX_iRIS_LI_Results] Where Laser_Assy_Sn = " + lsSn;

                // Read File content from Sql Table 
                SqlCommand selectCommand = new SqlCommand(selectQuery, con);
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.Read())
                {
                    byte[] fileData = (byte[])reader[0];
                    // Write/Export File content into new text file
                    File.WriteAllBytes(@"C:\Log_01\Rtn_Data_LI.txt", fileData);
                }

            con.Close();
        }
        //=========================================================================================//
        //=========================================================================================//
    }
}
