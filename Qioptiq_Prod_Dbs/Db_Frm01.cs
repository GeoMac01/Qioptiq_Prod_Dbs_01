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
            for (int i = 0; i <= dbDisplay.Tables[0].Rows.Count - 1; i++) {
            CbBx_Table.Items.Add(dbDisplay.Tables[0].Rows[i].ItemArray[0].ToString()); }
            if (CbBx_Table.Items.Count > 0) { CbBx_Table.SelectedIndex = 0; }

            else CbBx_Table.Text = "No Table !";
        }
        //================================================================================//
        private void Bt_DisplayDb_Click(object sender, EventArgs e)
        {
            /**call class method return a datatable**/
            dataGridView1.DataSource = objSQL.FillTable(CbBx_Table.Text);
            CmBx_TablColumn.SelectedIndex = 0;
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
            string value = Tb_FindTxt.Text;

            if (e.KeyChar == (char)Keys.Enter)
            {
                /*
                using (SqlConnection connection = new SqlConnection(connString)) ;
                using (SqlCommand cmd = new SqlCommand(
                   "select keyword from messageanalysis where value=@value")
                    {
                    cmd.AddParameter("@value",searchValue);
                    var result = cmd.ExecuteScalar();
                    return (result == null) ? null : result.ToString();
                    */
            }
            else { MessageBox.Show("Press Enter"); }
        }
        //================================================================================//
        //================================================================================//
    }
}
