﻿namespace Qioptiq_Prod_Dbs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Datbs_Trans));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_Help = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Lbl_opr = new System.Windows.Forms.Label();
            this.Cmbx_Opp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmBx_TablColumn = new System.Windows.Forms.ComboBox();
            this.Tb_FindTxt = new System.Windows.Forms.TextBox();
            this.Bt_EnDbPath = new System.Windows.Forms.Button();
            this.GbrBx_ConString = new System.Windows.Forms.GroupBox();
            this.TxBx_DBNAME = new System.Windows.Forms.TextBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.TxBx_ServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxBx_pwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxBx_Login = new System.Windows.Forms.TextBox();
            this.Bt_DisplayDb = new System.Windows.Forms.Button();
            this.CbBx_Table = new System.Windows.Forms.ComboBox();
            this.Bt_Connect = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.Bt_brwsTxt = new System.Windows.Forms.Button();
            this.Tb_TxtFileLoca = new System.Windows.Forms.TextBox();
            this.Bt_RdFromDtb = new System.Windows.Forms.Button();
            this.Bt_SavTodtb = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.GbrBx_ConString.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.Bt_SavTodtb);
            this.panel1.Controls.Add(this.Bt_RdFromDtb);
            this.panel1.Controls.Add(this.Tb_TxtFileLoca);
            this.panel1.Controls.Add(this.Bt_brwsTxt);
            this.panel1.Controls.Add(this.Lbl_Help);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.Lbl_opr);
            this.panel1.Controls.Add(this.Cmbx_Opp);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CmBx_TablColumn);
            this.panel1.Controls.Add(this.Tb_FindTxt);
            this.panel1.Controls.Add(this.Bt_EnDbPath);
            this.panel1.Controls.Add(this.GbrBx_ConString);
            this.panel1.Controls.Add(this.Bt_DisplayDb);
            this.panel1.Controls.Add(this.CbBx_Table);
            this.panel1.Controls.Add(this.Bt_Connect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 181);
            this.panel1.TabIndex = 0;
            // 
            // Lbl_Help
            // 
            this.Lbl_Help.AutoSize = true;
            this.Lbl_Help.Location = new System.Drawing.Point(279, 163);
            this.Lbl_Help.Name = "Lbl_Help";
            this.Lbl_Help.Size = new System.Drawing.Size(142, 13);
            this.Lbl_Help.TabIndex = 35;
            this.Lbl_Help.Text = "Double Click For Help >>> O";
            this.Lbl_Help.DoubleClick += new System.EventHandler(this.Lbl_Help_DoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(332, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Table Name";
            // 
            // Lbl_opr
            // 
            this.Lbl_opr.AutoSize = true;
            this.Lbl_opr.Location = new System.Drawing.Point(247, 101);
            this.Lbl_opr.Name = "Lbl_opr";
            this.Lbl_opr.Size = new System.Drawing.Size(48, 13);
            this.Lbl_opr.TabIndex = 27;
            this.Lbl_opr.Text = "Operator";
            // 
            // Cmbx_Opp
            // 
            this.Cmbx_Opp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbx_Opp.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.Cmbx_Opp, "Select Seach Operator");
            this.Cmbx_Opp.Items.AddRange(new object[] {
            "LIKE",
            "<=",
            ">=",
            "="});
            this.Cmbx_Opp.Location = new System.Drawing.Point(245, 116);
            this.Cmbx_Opp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Cmbx_Opp.Name = "Cmbx_Opp";
            this.helpProvider1.SetShowHelp(this.Cmbx_Opp, true);
            this.Cmbx_Opp.Size = new System.Drawing.Size(59, 21);
            this.Cmbx_Opp.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Table Column";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Text to Find";
            // 
            // CmBx_TablColumn
            // 
            this.CmBx_TablColumn.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.CmBx_TablColumn, "Select Column to search");
            this.CmBx_TablColumn.Items.AddRange(new object[] {
            "TestDate",
            "SerialNb",
            "PartNumber",
            "Wavelength",
            "Laser_Assy_Sn"});
            this.CmBx_TablColumn.Location = new System.Drawing.Point(157, 116);
            this.CmBx_TablColumn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CmBx_TablColumn.Name = "CmBx_TablColumn";
            this.helpProvider1.SetShowHelp(this.CmBx_TablColumn, true);
            this.CmBx_TablColumn.Size = new System.Drawing.Size(84, 21);
            this.CmBx_TablColumn.TabIndex = 23;
            // 
            // Tb_FindTxt
            // 
            this.Tb_FindTxt.Enabled = false;
            this.helpProvider1.SetHelpString(this.Tb_FindTxt, "search Serial Number (use LIKE and not =).  search Date (format yyyy/mm/dd).  sea" +
        "rch Wavelength or laser Part Number if exist...");
            this.Tb_FindTxt.Location = new System.Drawing.Point(309, 116);
            this.Tb_FindTxt.Name = "Tb_FindTxt";
            this.helpProvider1.SetShowHelp(this.Tb_FindTxt, true);
            this.Tb_FindTxt.Size = new System.Drawing.Size(80, 20);
            this.Tb_FindTxt.TabIndex = 22;
            this.Tb_FindTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_FindTxt_KeyPress);
            // 
            // Bt_EnDbPath
            // 
            this.Bt_EnDbPath.BackColor = System.Drawing.Color.Coral;
            this.Bt_EnDbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_EnDbPath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.helpProvider1.SetHelpString(this.Bt_EnDbPath, "Enable Database string modification in groupbox Db String");
            this.Bt_EnDbPath.Location = new System.Drawing.Point(149, 147);
            this.Bt_EnDbPath.Name = "Bt_EnDbPath";
            this.helpProvider1.SetShowHelp(this.Bt_EnDbPath, true);
            this.Bt_EnDbPath.Size = new System.Drawing.Size(22, 20);
            this.Bt_EnDbPath.TabIndex = 21;
            this.Bt_EnDbPath.UseVisualStyleBackColor = false;
            this.Bt_EnDbPath.Click += new System.EventHandler(this.Bt_EnDbPath_Click);
            // 
            // GbrBx_ConString
            // 
            this.GbrBx_ConString.Controls.Add(this.TxBx_DBNAME);
            this.GbrBx_ConString.Controls.Add(this.lblServerName);
            this.GbrBx_ConString.Controls.Add(this.TxBx_ServerName);
            this.GbrBx_ConString.Controls.Add(this.label1);
            this.GbrBx_ConString.Controls.Add(this.TxBx_pwd);
            this.GbrBx_ConString.Controls.Add(this.label2);
            this.GbrBx_ConString.Controls.Add(this.label3);
            this.GbrBx_ConString.Controls.Add(this.TxBx_Login);
            this.GbrBx_ConString.Enabled = false;
            this.helpProvider1.SetHelpString(this.GbrBx_ConString, "Database location and Login string");
            this.GbrBx_ConString.Location = new System.Drawing.Point(3, 3);
            this.GbrBx_ConString.Name = "GbrBx_ConString";
            this.helpProvider1.SetShowHelp(this.GbrBx_ConString, true);
            this.GbrBx_ConString.Size = new System.Drawing.Size(140, 164);
            this.GbrBx_ConString.TabIndex = 20;
            this.GbrBx_ConString.TabStop = false;
            this.GbrBx_ConString.Text = "Db String";
            // 
            // TxBx_DBNAME
            // 
            this.TxBx_DBNAME.Location = new System.Drawing.Point(5, 135);
            this.TxBx_DBNAME.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxBx_DBNAME.Name = "TxBx_DBNAME";
            this.TxBx_DBNAME.Size = new System.Drawing.Size(126, 20);
            this.TxBx_DBNAME.TabIndex = 12;
            this.TxBx_DBNAME.Text = "QPL Production";
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
            // TxBx_ServerName
            // 
            this.TxBx_ServerName.Location = new System.Drawing.Point(5, 30);
            this.TxBx_ServerName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxBx_ServerName.Name = "TxBx_ServerName";
            this.TxBx_ServerName.Size = new System.Drawing.Size(126, 20);
            this.TxBx_ServerName.TabIndex = 10;
            this.TxBx_ServerName.Text = "ETCMUCD02";
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
            // TxBx_pwd
            // 
            this.TxBx_pwd.Location = new System.Drawing.Point(5, 100);
            this.TxBx_pwd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxBx_pwd.Name = "TxBx_pwd";
            this.TxBx_pwd.PasswordChar = '*';
            this.TxBx_pwd.Size = new System.Drawing.Size(126, 20);
            this.TxBx_pwd.TabIndex = 16;
            this.TxBx_pwd.Text = "H@mbleDB!";
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
            // TxBx_Login
            // 
            this.TxBx_Login.Location = new System.Drawing.Point(5, 65);
            this.TxBx_Login.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxBx_Login.Name = "TxBx_Login";
            this.TxBx_Login.Size = new System.Drawing.Size(126, 20);
            this.TxBx_Login.TabIndex = 14;
            this.TxBx_Login.Text = "HambleDBUser";
            // 
            // Bt_DisplayDb
            // 
            this.Bt_DisplayDb.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Bt_DisplayDb.Enabled = false;
            this.Bt_DisplayDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bt_DisplayDb.ForeColor = System.Drawing.SystemColors.Control;
            this.helpProvider1.SetHelpString(this.Bt_DisplayDb, "Display complete Database Table");
            this.Bt_DisplayDb.Location = new System.Drawing.Point(245, 3);
            this.Bt_DisplayDb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Bt_DisplayDb.Name = "Bt_DisplayDb";
            this.helpProvider1.SetShowHelp(this.Bt_DisplayDb, true);
            this.Bt_DisplayDb.Size = new System.Drawing.Size(84, 45);
            this.Bt_DisplayDb.TabIndex = 19;
            this.Bt_DisplayDb.Text = "Display Table";
            this.Bt_DisplayDb.UseVisualStyleBackColor = false;
            this.Bt_DisplayDb.Click += new System.EventHandler(this.Bt_DisplayDb_Click);
            // 
            // CbBx_Table
            // 
            this.CbBx_Table.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbBx_Table.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.CbBx_Table, "Select table to display or search");
            this.CbBx_Table.Location = new System.Drawing.Point(157, 54);
            this.CbBx_Table.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CbBx_Table.Name = "CbBx_Table";
            this.helpProvider1.SetShowHelp(this.CbBx_Table, true);
            this.CbBx_Table.Size = new System.Drawing.Size(172, 21);
            this.CbBx_Table.TabIndex = 18;
            // 
            // Bt_Connect
            // 
            this.Bt_Connect.BackColor = System.Drawing.Color.SteelBlue;
            this.Bt_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bt_Connect.ForeColor = System.Drawing.SystemColors.Control;
            this.helpProvider1.SetHelpString(this.Bt_Connect, "Click to connect to Database");
            this.Bt_Connect.Location = new System.Drawing.Point(157, 2);
            this.Bt_Connect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Bt_Connect.Name = "Bt_Connect";
            this.helpProvider1.SetShowHelp(this.Bt_Connect, true);
            this.Bt_Connect.Size = new System.Drawing.Size(84, 45);
            this.Bt_Connect.TabIndex = 17;
            this.Bt_Connect.Text = "Connect to Database";
            this.Bt_Connect.UseVisualStyleBackColor = false;
            this.Bt_Connect.Click += new System.EventHandler(this.Bt_Connect_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 167);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider1.SetHelpString(this.dataGridView1, "DatagridView displays table results");
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.helpProvider1.SetShowHelp(this.dataGridView1, true);
            this.dataGridView1.Size = new System.Drawing.Size(825, 167);
            this.dataGridView1.TabIndex = 0;
            // 
            // Bt_brwsTxt
            // 
            this.Bt_brwsTxt.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Bt_brwsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bt_brwsTxt.ForeColor = System.Drawing.SystemColors.Control;
            this.helpProvider1.SetHelpString(this.Bt_brwsTxt, "");
            this.Bt_brwsTxt.Location = new System.Drawing.Point(422, 3);
            this.Bt_brwsTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Bt_brwsTxt.Name = "Bt_brwsTxt";
            this.helpProvider1.SetShowHelp(this.Bt_brwsTxt, false);
            this.Bt_brwsTxt.Size = new System.Drawing.Size(113, 29);
            this.Bt_brwsTxt.TabIndex = 36;
            this.Bt_brwsTxt.Text = "Browse Txt File";
            this.Bt_brwsTxt.UseVisualStyleBackColor = false;
            this.Bt_brwsTxt.Click += new System.EventHandler(this.Bt_brwsTxt_Click);
            // 
            // Tb_TxtFileLoca
            // 
            this.Tb_TxtFileLoca.Location = new System.Drawing.Point(540, 7);
            this.Tb_TxtFileLoca.Name = "Tb_TxtFileLoca";
            this.Tb_TxtFileLoca.Size = new System.Drawing.Size(273, 20);
            this.Tb_TxtFileLoca.TabIndex = 37;
            // 
            // Bt_RdFromDtb
            // 
            this.Bt_RdFromDtb.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Bt_RdFromDtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bt_RdFromDtb.ForeColor = System.Drawing.SystemColors.Control;
            this.helpProvider1.SetHelpString(this.Bt_RdFromDtb, "");
            this.Bt_RdFromDtb.Location = new System.Drawing.Point(422, 73);
            this.Bt_RdFromDtb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Bt_RdFromDtb.Name = "Bt_RdFromDtb";
            this.helpProvider1.SetShowHelp(this.Bt_RdFromDtb, false);
            this.Bt_RdFromDtb.Size = new System.Drawing.Size(113, 29);
            this.Bt_RdFromDtb.TabIndex = 38;
            this.Bt_RdFromDtb.Text = "Read from dtb";
            this.Bt_RdFromDtb.UseVisualStyleBackColor = false;
            this.Bt_RdFromDtb.Click += new System.EventHandler(this.Bt_RdFromDtb_Click);
            // 
            // Bt_SavTodtb
            // 
            this.Bt_SavTodtb.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Bt_SavTodtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bt_SavTodtb.ForeColor = System.Drawing.SystemColors.Control;
            this.helpProvider1.SetHelpString(this.Bt_SavTodtb, "");
            this.Bt_SavTodtb.Location = new System.Drawing.Point(422, 38);
            this.Bt_SavTodtb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Bt_SavTodtb.Name = "Bt_SavTodtb";
            this.helpProvider1.SetShowHelp(this.Bt_SavTodtb, false);
            this.Bt_SavTodtb.Size = new System.Drawing.Size(113, 29);
            this.Bt_SavTodtb.TabIndex = 39;
            this.Bt_SavTodtb.Text = "Save to dtb";
            this.Bt_SavTodtb.UseVisualStyleBackColor = false;
            this.Bt_SavTodtb.Click += new System.EventHandler(this.Bt_SavTodtb_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(541, 35);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(271, 140);
            this.richTextBox1.TabIndex = 40;
            this.richTextBox1.Text = "";
            // 
            // Frm_Datbs_Trans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 348);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Datbs_Trans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Databse Viewer 30065-01";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GbrBx_ConString.ResumeLayout(false);
            this.GbrBx_ConString.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox GbrBx_ConString;
        private System.Windows.Forms.TextBox TxBx_DBNAME;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.TextBox TxBx_ServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxBx_pwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxBx_Login;
        private System.Windows.Forms.Button Bt_DisplayDb;
        private System.Windows.Forms.ComboBox CbBx_Table;
        private System.Windows.Forms.Button Bt_Connect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Bt_EnDbPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmBx_TablColumn;
        private System.Windows.Forms.TextBox Tb_FindTxt;
        private System.Windows.Forms.Label Lbl_opr;
        private System.Windows.Forms.ComboBox Cmbx_Opp;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Lbl_Help;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Bt_SavTodtb;
        private System.Windows.Forms.Button Bt_RdFromDtb;
        private System.Windows.Forms.TextBox Tb_TxtFileLoca;
        private System.Windows.Forms.Button Bt_brwsTxt;
    }
}

