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
using Microsoft.VisualBasic;


namespace Qioptiq_Prod_Dbs
{
    public partial class Frm_Datbs_Trans : Form
    {
        Helper.SQLadaptClass objSQL = new Helper.SQLadaptClass();

        public Frm_Datbs_Trans()
        {
            InitializeComponent();
        }
        //================================================================================//
        private void Bt_Connect_Click(object sender, EventArgs e)
        {
            Helper.SQLadaptClass.DbName = TxBx_DBNAME.Text.Trim();
            Helper.SQLadaptClass.DbPassword = TxBx_pwd.Text.Trim();
            Helper.SQLadaptClass.DbServerName = TxBx_ServerName.Text.Trim();
            Helper.SQLadaptClass.DbUsername = TxBx_Login.Text.Trim();

            bool allgood =  objSQL.OpenSqlConnection();

        }
        //================================================================================//
        private void Bt_DisplayDb_Click(object sender, EventArgs e)
        {
            DataSet dbDisplay = new DataSet();

            dbDisplay = objSQL.FindTables();




        }
        //================================================================================//
        //================================================================================//
    }
}
