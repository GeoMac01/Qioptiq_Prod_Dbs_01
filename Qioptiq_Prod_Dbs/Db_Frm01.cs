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

namespace Qioptiq_Prod_Dbs
{
    public partial class Frm_Datbs_Trans : Form
    {
        Helper.SQLadaptClass objSQL = new Helper.SQLadaptClass();

        public Frm_Datbs_Trans()  { InitializeComponent(); }
        //================================================================================//
        private void Bt_Connect_Click(object sender, EventArgs e)
        {
            /**Update the Class variable**/
            Helper.SQLadaptClass.DbName = TxBx_DBNAME.Text.Trim();
            Helper.SQLadaptClass.DbPassword = TxBx_pwd.Text.Trim();
            Helper.SQLadaptClass.DbServerName = TxBx_ServerName.Text.Trim();
            Helper.SQLadaptClass.DbUsername = TxBx_Login.Text.Trim();
            
            /**Open/Close Database**/
            bool allgood =  objSQL.OpenSqlConnection();
            
            /**Return a Datatable from database table**/
            DataSet dbDisplay = new DataSet();
            dbDisplay = objSQL.FindTables();

            /**Combobox populate with table names**/
            CbBx_Table.Items.Clear();

            for (int i = 0; i <= dbDisplay.Tables[0].Rows.Count - 1; i++) { CbBx_Table.Items.Add(dbDisplay.Tables[0].Rows[i].ItemArray[0].ToString()); }

            if (CbBx_Table.Items.Count > 0) { CbBx_Table.SelectedIndex = 0; }

            else CbBx_Table.Text = "No Table !";

            CmBx_TablColumn.SelectedIndex = 0;
            Cmbx_Opp.SelectedIndex = 0;
        }
        //================================================================================//
        private void Bt_DisplayDb_Click(object sender, EventArgs e)
        {
            ClearTable();
            /**call class method return a datatable**/
            dataGridView1.DataSource = objSQL.FillTable(CbBx_Table.Text, CmBx_TablColumn.Text);
        }
        //================================================================================//
        private void Bt_EnDbPath_Click(object sender, EventArgs e)
        {
            //**Enable access to the database path string**/
            if (Bt_EnDbPath.BackColor == Color.Coral)
            {
                GbrBx_ConString.Enabled = true;
                Bt_EnDbPath.BackColor = Color.Red;
            }
            else
            {
                GbrBx_ConString.Enabled = false;
                Bt_EnDbPath.BackColor = Color.Coral;
            }
        }
        //================================================================================//
        private void Tb_FindTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string expression = null;

            if (e.KeyChar == (char)Keys.Enter)
            {
                ClearTable();

                if (Cmbx_Opp.Text == "LIKE") {
                expression = "SELECT * FROM " + CbBx_Table.Text + " WHERE " + CmBx_TablColumn.Text + " " + Cmbx_Opp.Text + " " + "'%" + Tb_FindTxt.Text + "%'"; }
                else {
                expression = "SELECT * FROM " + CbBx_Table.Text + " WHERE " + CmBx_TablColumn.Text + " " + Cmbx_Opp.Text + " " + "'" + Tb_FindTxt.Text + "'"; }

                dataGridView1.DataSource = objSQL.FindTxtInCol2(CbBx_Table.Text, expression);
            }
        }
        //================================================================================//
        private void ClearTable()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Refresh();
        }
        //================================================================================//
        //================================================================================//
    }
}
