namespace OpenPW
{
	partial class SaveAcc
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveAcc));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.button_Fechar = new System.Windows.Forms.Button();
			this.pictureBox_Classes = new System.Windows.Forms.PictureBox();
			this.caminhopwBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pwDBDataSet = new OpenPW.pwDBDataSet();
			this.comboBox_Classes = new System.Windows.Forms.ComboBox();
			this.pictureBox_Check = new System.Windows.Forms.PictureBox();
			this.dataGridView_PW = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomePW = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeCharDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.oiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dELETARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contaspwBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.contas_pwTableAdapter = new OpenPW.pwDBDataSetTableAdapters.contas_pwTableAdapter();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.caminho_pwTableAdapter = new OpenPW.pwDBDataSetTableAdapters.caminho_pwTableAdapter();
			this.pictureBox_salve = new System.Windows.Forms.PictureBox();
			this.comboBox_IdPw = new System.Windows.Forms.ComboBox();
			this.caminhopwcontaspwBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.textBox_Senha = new ZBobb.AlphaBlendTextBox();
			this.textBox_Login = new ZBobb.AlphaBlendTextBox();
			this.textBox_Char = new ZBobb.AlphaBlendTextBox();
			this.panel_LOG = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Classes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.caminhopwBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pwDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Check)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_PW)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.contaspwBindingSource)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_salve)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.caminhopwcontaspwBindingSource)).BeginInit();
			this.panel_LOG.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_Fechar
			// 
			this.button_Fechar.BackColor = System.Drawing.Color.Transparent;
			this.button_Fechar.BackgroundImage = global::OpenPW.Properties.Resources.fechar;
			this.button_Fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button_Fechar.FlatAppearance.BorderSize = 0;
			this.button_Fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button_Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Fechar.Location = new System.Drawing.Point(755, 10);
			this.button_Fechar.Name = "button_Fechar";
			this.button_Fechar.Size = new System.Drawing.Size(37, 23);
			this.button_Fechar.TabIndex = 18;
			this.button_Fechar.UseVisualStyleBackColor = false;
			this.button_Fechar.Click += new System.EventHandler(this.button_Fechar_Click);
			// 
			// pictureBox_Classes
			// 
			this.pictureBox_Classes.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox_Classes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Classes.BackgroundImage")));
			this.pictureBox_Classes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox_Classes.Location = new System.Drawing.Point(542, 21);
			this.pictureBox_Classes.Name = "pictureBox_Classes";
			this.pictureBox_Classes.Size = new System.Drawing.Size(110, 97);
			this.pictureBox_Classes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_Classes.TabIndex = 24;
			this.pictureBox_Classes.TabStop = false;
			// 
			// caminhopwBindingSource
			// 
			this.caminhopwBindingSource.DataMember = "caminho_pw";
			this.caminhopwBindingSource.DataSource = this.pwDBDataSet;
			// 
			// pwDBDataSet
			// 
			this.pwDBDataSet.DataSetName = "pwDBDataSet";
			this.pwDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// comboBox_Classes
			// 
			this.comboBox_Classes.Cursor = System.Windows.Forms.Cursors.Default;
			this.comboBox_Classes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Classes.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_Classes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.comboBox_Classes.FormattingEnabled = true;
			this.comboBox_Classes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.comboBox_Classes.Items.AddRange(new object[] {
            "[ CLASSE ]",
            "WR",
            "MG",
            " ",
            "EA",
            "EP",
            " ",
            "WB",
            "WF",
            " ",
            "MC",
            "PSY",
            " ",
            "SK",
            "MS",
            " ",
            "RT",
            "TM",
            " ",
            "AT",
            "PL"});
			this.comboBox_Classes.Location = new System.Drawing.Point(536, 123);
			this.comboBox_Classes.Name = "comboBox_Classes";
			this.comboBox_Classes.Size = new System.Drawing.Size(121, 23);
			this.comboBox_Classes.TabIndex = 19;
			this.comboBox_Classes.SelectedIndexChanged += new System.EventHandler(this.comboBox_Classes_SelectedIndexChanged);
			// 
			// pictureBox_Check
			// 
			this.pictureBox_Check.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox_Check.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Check.BackgroundImage")));
			this.pictureBox_Check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox_Check.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_Check.Location = new System.Drawing.Point(699, 258);
			this.pictureBox_Check.Name = "pictureBox_Check";
			this.pictureBox_Check.Size = new System.Drawing.Size(22, 20);
			this.pictureBox_Check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox_Check.TabIndex = 25;
			this.pictureBox_Check.TabStop = false;
			this.pictureBox_Check.Click += new System.EventHandler(this.pictureBox_Check_Click);
			// 
			// dataGridView_PW
			// 
			this.dataGridView_PW.AllowUserToAddRows = false;
			this.dataGridView_PW.AllowUserToDeleteRows = false;
			this.dataGridView_PW.AllowUserToResizeColumns = false;
			this.dataGridView_PW.AllowUserToResizeRows = false;
			this.dataGridView_PW.AutoGenerateColumns = false;
			this.dataGridView_PW.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridView_PW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView_PW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView_PW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_PW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn,
            this.nomePW,
            this.classeDataGridViewTextBoxColumn,
            this.nomeCharDataGridViewTextBoxColumn});
			this.dataGridView_PW.ContextMenuStrip = this.contextMenuStrip1;
			this.dataGridView_PW.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dataGridView_PW.DataSource = this.contaspwBindingSource;
			this.dataGridView_PW.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_PW.GridColor = System.Drawing.Color.White;
			this.dataGridView_PW.Location = new System.Drawing.Point(3, 16);
			this.dataGridView_PW.MultiSelect = false;
			this.dataGridView_PW.Name = "dataGridView_PW";
			this.dataGridView_PW.ReadOnly = true;
			this.dataGridView_PW.RowHeadersVisible = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridView_PW.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_PW.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridView_PW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_PW.Size = new System.Drawing.Size(357, 418);
			this.dataGridView_PW.TabIndex = 26;
			this.dataGridView_PW.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_PW_CellMouseClick);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// loginDataGridViewTextBoxColumn
			// 
			this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
			this.loginDataGridViewTextBoxColumn.HeaderText = "NOT FOUND KEY 30";
			this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
			this.loginDataGridViewTextBoxColumn.ReadOnly = true;
			this.loginDataGridViewTextBoxColumn.Width = 89;
			// 
			// senhaDataGridViewTextBoxColumn
			// 
			this.senhaDataGridViewTextBoxColumn.DataPropertyName = "senha";
			this.senhaDataGridViewTextBoxColumn.HeaderText = "NOT FOUND KEY 31";
			this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
			this.senhaDataGridViewTextBoxColumn.ReadOnly = true;
			this.senhaDataGridViewTextBoxColumn.Visible = false;
			// 
			// nomePW
			// 
			this.nomePW.DataPropertyName = "nomePW";
			this.nomePW.HeaderText = "NOT FOUND KEY 1";
			this.nomePW.Name = "nomePW";
			this.nomePW.ReadOnly = true;
			this.nomePW.Width = 108;
			// 
			// classeDataGridViewTextBoxColumn
			// 
			this.classeDataGridViewTextBoxColumn.DataPropertyName = "classe";
			this.classeDataGridViewTextBoxColumn.HeaderText = "NOT FOUND KEY 32";
			this.classeDataGridViewTextBoxColumn.Name = "classeDataGridViewTextBoxColumn";
			this.classeDataGridViewTextBoxColumn.ReadOnly = true;
			this.classeDataGridViewTextBoxColumn.Width = 69;
			// 
			// nomeCharDataGridViewTextBoxColumn
			// 
			this.nomeCharDataGridViewTextBoxColumn.DataPropertyName = "NomeChar";
			this.nomeCharDataGridViewTextBoxColumn.HeaderText = "NOT FOUND KEY 33";
			this.nomeCharDataGridViewTextBoxColumn.Name = "nomeCharDataGridViewTextBoxColumn";
			this.nomeCharDataGridViewTextBoxColumn.ReadOnly = true;
			this.nomeCharDataGridViewTextBoxColumn.Width = 88;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oiToolStripMenuItem,
            this.dELETARToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(179, 48);
			// 
			// oiToolStripMenuItem
			// 
			this.oiToolStripMenuItem.Image = global::OpenPW.Properties.Resources.fechar;
			this.oiToolStripMenuItem.Name = "oiToolStripMenuItem";
			this.oiToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.oiToolStripMenuItem.Text = "NOT FOUND KEY 12";
			this.oiToolStripMenuItem.Click += new System.EventHandler(this.oiToolStripMenuItem_Click);
			// 
			// dELETARToolStripMenuItem
			// 
			this.dELETARToolStripMenuItem.Image = global::OpenPW.Properties.Resources.fechar;
			this.dELETARToolStripMenuItem.Name = "dELETARToolStripMenuItem";
			this.dELETARToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.dELETARToolStripMenuItem.Text = "NOT FOUND KEY 13";
			this.dELETARToolStripMenuItem.Click += new System.EventHandler(this.dELETARToolStripMenuItem_Click);
			// 
			// contaspwBindingSource
			// 
			this.contaspwBindingSource.DataMember = "contas_pw";
			this.contaspwBindingSource.DataSource = this.pwDBDataSet;
			// 
			// contas_pwTableAdapter
			// 
			this.contas_pwTableAdapter.ClearBeforeFill = true;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.dataGridView_PW);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.Black;
			this.groupBox2.Location = new System.Drawing.Point(26, 30);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(363, 437);
			this.groupBox2.TabIndex = 27;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "NOT FOUND KEY 1";
			// 
			// caminho_pwTableAdapter
			// 
			this.caminho_pwTableAdapter.ClearBeforeFill = true;
			// 
			// pictureBox_salve
			// 
			this.pictureBox_salve.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox_salve.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_salve.BackgroundImage")));
			this.pictureBox_salve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox_salve.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_salve.Location = new System.Drawing.Point(461, 409);
			this.pictureBox_salve.Name = "pictureBox_salve";
			this.pictureBox_salve.Size = new System.Drawing.Size(270, 93);
			this.pictureBox_salve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_salve.TabIndex = 28;
			this.pictureBox_salve.TabStop = false;
			this.pictureBox_salve.Click += new System.EventHandler(this.pictureBox_salve_Click);
			this.pictureBox_salve.MouseLeave += new System.EventHandler(this.pictureBox_salve_MouseLeave);
			this.pictureBox_salve.MouseHover += new System.EventHandler(this.pictureBox_salve_MouseHover);
			// 
			// comboBox_IdPw
			// 
			this.comboBox_IdPw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("comboBox_IdPw.BackgroundImage")));
			this.comboBox_IdPw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.comboBox_IdPw.DataSource = this.caminhopwBindingSource;
			this.comboBox_IdPw.DisplayMember = "nomePW";
			this.comboBox_IdPw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_IdPw.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.comboBox_IdPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_IdPw.FormattingEnabled = true;
			this.comboBox_IdPw.Location = new System.Drawing.Point(461, 364);
			this.comboBox_IdPw.Name = "comboBox_IdPw";
			this.comboBox_IdPw.Size = new System.Drawing.Size(270, 39);
			this.comboBox_IdPw.TabIndex = 27;
			this.comboBox_IdPw.ValueMember = "id";
			// 
			// caminhopwcontaspwBindingSource
			// 
			this.caminhopwcontaspwBindingSource.DataMember = "caminho_pwcontas_pw";
			this.caminhopwcontaspwBindingSource.DataSource = this.caminhopwBindingSource;
			// 
			// textBox_Senha
			// 
			this.textBox_Senha.BackAlpha = 10;
			this.textBox_Senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.textBox_Senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.textBox_Senha.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.textBox_Senha.Location = new System.Drawing.Point(512, 243);
			this.textBox_Senha.Name = "textBox_Senha";
			this.textBox_Senha.PasswordChar = '1';
			this.textBox_Senha.Size = new System.Drawing.Size(167, 31);
			this.textBox_Senha.TabIndex = 29;
			this.textBox_Senha.Text = "NOT FOUND KEY 31";
			this.textBox_Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox_Login
			// 
			this.textBox_Login.BackAlpha = 10;
			this.textBox_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.textBox_Login.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.textBox_Login.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.textBox_Login.Location = new System.Drawing.Point(512, 177);
			this.textBox_Login.Name = "textBox_Login";
			this.textBox_Login.Size = new System.Drawing.Size(167, 31);
			this.textBox_Login.TabIndex = 29;
			this.textBox_Login.Text = "NOT FOUND KEY 30";
			this.textBox_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox_Char
			// 
			this.textBox_Char.BackAlpha = 10;
			this.textBox_Char.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.textBox_Char.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_Char.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.textBox_Char.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.textBox_Char.Location = new System.Drawing.Point(12, 7);
			this.textBox_Char.Multiline = true;
			this.textBox_Char.Name = "textBox_Char";
			this.textBox_Char.Size = new System.Drawing.Size(167, 35);
			this.textBox_Char.TabIndex = 30;
			this.textBox_Char.Text = "NOT FOUND KEY 34";
			this.textBox_Char.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// panel_LOG
			// 
			this.panel_LOG.BackColor = System.Drawing.Color.Transparent;
			this.panel_LOG.BackgroundImage = global::OpenPW.Properties.Resources.fechar;
			this.panel_LOG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel_LOG.Controls.Add(this.textBox_Char);
			this.panel_LOG.Location = new System.Drawing.Point(500, 296);
			this.panel_LOG.Name = "panel_LOG";
			this.panel_LOG.Size = new System.Drawing.Size(193, 46);
			this.panel_LOG.TabIndex = 31;
			// 
			// SaveAcc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Maroon;
			this.BackgroundImage = global::OpenPW.Properties.Resources.fechar;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(804, 529);
			this.Controls.Add(this.textBox_Login);
			this.Controls.Add(this.textBox_Senha);
			this.Controls.Add(this.comboBox_IdPw);
			this.Controls.Add(this.pictureBox_salve);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.pictureBox_Check);
			this.Controls.Add(this.pictureBox_Classes);
			this.Controls.Add(this.comboBox_Classes);
			this.Controls.Add(this.button_Fechar);
			this.Controls.Add(this.panel_LOG);
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SaveAcc";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SaveAcc";
			this.Load += new System.EventHandler(this.SaveAcc_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SaveAcc_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Classes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.caminhopwBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pwDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Check)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_PW)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.contaspwBindingSource)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_salve)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.caminhopwcontaspwBindingSource)).EndInit();
			this.panel_LOG.ResumeLayout(false);
			this.panel_LOG.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_Fechar;
		private System.Windows.Forms.PictureBox pictureBox_Classes;
		private System.Windows.Forms.ComboBox comboBox_Classes;
		private System.Windows.Forms.PictureBox pictureBox_Check;
		private System.Windows.Forms.DataGridView dataGridView_PW;
		private pwDBDataSet pwDBDataSet;
		private System.Windows.Forms.BindingSource contaspwBindingSource;
		private pwDBDataSetTableAdapters.contas_pwTableAdapter contas_pwTableAdapter;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.BindingSource caminhopwBindingSource;
		private pwDBDataSetTableAdapters.caminho_pwTableAdapter caminho_pwTableAdapter;
		private System.Windows.Forms.PictureBox pictureBox_salve;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem oiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dELETARToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn pwDataGridViewTextBoxColumn;
		private System.Windows.Forms.ComboBox comboBox_IdPw;
		private System.Windows.Forms.BindingSource caminhopwcontaspwBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private ZBobb.AlphaBlendTextBox textBox_Senha;
		private ZBobb.AlphaBlendTextBox textBox_Login;
		private ZBobb.AlphaBlendTextBox textBox_Char;
		private System.Windows.Forms.Panel panel_LOG;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomePW;
		private System.Windows.Forms.DataGridViewTextBoxColumn classeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeCharDataGridViewTextBoxColumn;
	}
}