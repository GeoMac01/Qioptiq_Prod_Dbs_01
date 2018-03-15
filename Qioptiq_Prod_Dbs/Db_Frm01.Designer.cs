namespace Qioptiq_Prod_Dbs
{
    partial class Frm_Datbs_Trans
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDBNAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cboDatabase = new System.Windows.Forms.ComboBox();
            this.btnloadDB = new System.Windows.Forms.Button();
            this.GbrBx_ConString = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.GbrBx_ConString.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.GbrBx_ConString);
            this.panel1.Controls.Add(this.btnloadDB);
            this.panel1.Controls.Add(this.cboDatabase);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 253);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 225);
            this.panel2.TabIndex = 1;
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(5, 100);
            this.txtpwd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.Size = new System.Drawing.Size(126, 20);
            this.txtpwd.TabIndex = 16;
            this.txtpwd.Text = "H@mbleDB!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(5, 65);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(126, 20);
            this.txtLogin.TabIndex = 14;
            this.txtLogin.Text = "HambleDBUser";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Login:";
            // 
            // txtDBNAME
            // 
            this.txtDBNAME.Location = new System.Drawing.Point(5, 135);
            this.txtDBNAME.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDBNAME.Name = "txtDBNAME";
            this.txtDBNAME.Size = new System.Drawing.Size(126, 20);
            this.txtDBNAME.TabIndex = 12;
            this.txtDBNAME.Text = "QPL Production";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Database Name";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(5, 30);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(126, 20);
            this.txtServerName.TabIndex = 10;
            this.txtServerName.Text = "ETCMUCD02";
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(5, 16);
            this.lblServerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(70, 13);
            this.lblServerName.TabIndex = 9;
            this.lblServerName.Text = "Server name:";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.SteelBlue;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnConnect.Location = new System.Drawing.Point(3, 168);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(84, 45);
            this.btnConnect.TabIndex = 17;
            this.btnConnect.Text = "Connect Database";
            this.btnConnect.UseVisualStyleBackColor = false;
            // 
            // cboDatabase
            // 
            this.cboDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDatabase.FormattingEnabled = true;
            this.cboDatabase.Location = new System.Drawing.Point(3, 219);
            this.cboDatabase.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.Size = new System.Drawing.Size(172, 21);
            this.cboDatabase.TabIndex = 18;
            // 
            // btnloadDB
            // 
            this.btnloadDB.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnloadDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnloadDB.Location = new System.Drawing.Point(91, 168);
            this.btnloadDB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnloadDB.Name = "btnloadDB";
            this.btnloadDB.Size = new System.Drawing.Size(84, 45);
            this.btnloadDB.TabIndex = 19;
            this.btnloadDB.Text = "Display Table";
            this.btnloadDB.UseVisualStyleBackColor = false;
            // 
            // GbrBx_ConString
            // 
            this.GbrBx_ConString.Controls.Add(this.txtDBNAME);
            this.GbrBx_ConString.Controls.Add(this.lblServerName);
            this.GbrBx_ConString.Controls.Add(this.txtServerName);
            this.GbrBx_ConString.Controls.Add(this.label1);
            this.GbrBx_ConString.Controls.Add(this.txtpwd);
            this.GbrBx_ConString.Controls.Add(this.label2);
            this.GbrBx_ConString.Controls.Add(this.label3);
            this.GbrBx_ConString.Controls.Add(this.txtLogin);
            this.GbrBx_ConString.Location = new System.Drawing.Point(3, 3);
            this.GbrBx_ConString.Name = "GbrBx_ConString";
            this.GbrBx_ConString.Size = new System.Drawing.Size(140, 164);
            this.GbrBx_ConString.TabIndex = 20;
            this.GbrBx_ConString.TabStop = false;
            this.GbrBx_ConString.Text = "Db String";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(640, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // Frm_Datbs_Trans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 478);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Datbs_Trans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qioptiq Dbase Access 01";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.GbrBx_ConString.ResumeLayout(false);
            this.GbrBx_ConString.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox GbrBx_ConString;
        private System.Windows.Forms.TextBox txtDBNAME;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnloadDB;
        private System.Windows.Forms.ComboBox cboDatabase;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

