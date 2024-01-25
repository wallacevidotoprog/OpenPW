namespace OpenPW
{
	partial class MainWindow
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView_PW = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomePWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.caminhoPastaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.caminhoEXEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.caminhoPatcherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.caminhopwBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pwDBDataSet = new OpenPW.pwDBDataSet();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridView_Conta = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pwDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeCharDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contaspwBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.pictureBox_Classes = new System.Windows.Forms.PictureBox();
			this.pictureBox_play = new System.Windows.Forms.PictureBox();
			this.button_Fechar = new System.Windows.Forms.Button();
			this.caminho_pwTableAdapter = new OpenPW.pwDBDataSetTableAdapters.caminho_pwTableAdapter();
			this.contas_pwTableAdapter = new OpenPW.pwDBDataSetTableAdapters.contas_pwTableAdapter();
			this.pictureBox_config = new System.Windows.Forms.PictureBox();
			this.pictureBox_pw = new System.Windows.Forms.PictureBox();
			this.pictureBox_conta = new System.Windows.Forms.PictureBox();
			this.toolTip_CONFIG = new System.Windows.Forms.ToolTip(this.components);
			this.toolTip_PW = new System.Windows.Forms.ToolTip(this.components);
			this.toolTip_CONTA = new System.Windows.Forms.ToolTip(this.components);
			this.label_VS = new System.Windows.Forms.Label();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_PW)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.caminhopwBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pwDBDataSet)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Conta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.contaspwBindingSource)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Classes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_play)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_config)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_pw)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_conta)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(713, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.dataGridView_PW);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(106, 87);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(209, 293);
			this.groupBox2.TabIndex = 14;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Perfect Wolrd";
			// 
			// dataGridView_PW
			// 
			this.dataGridView_PW.AllowUserToAddRows = false;
			this.dataGridView_PW.AllowUserToDeleteRows = false;
			this.dataGridView_PW.AllowUserToResizeColumns = false;
			this.dataGridView_PW.AllowUserToResizeRows = false;
			this.dataGridView_PW.AutoGenerateColumns = false;
			this.dataGridView_PW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView_PW.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView_PW.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGridView_PW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView_PW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_PW.ColumnHeadersVisible = false;
			this.dataGridView_PW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomePWDataGridViewTextBoxColumn,
            this.caminhoPastaDataGridViewTextBoxColumn,
            this.caminhoEXEDataGridViewTextBoxColumn,
            this.caminhoPatcherDataGridViewTextBoxColumn});
			this.dataGridView_PW.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dataGridView_PW.DataSource = this.caminhopwBindingSource;
			this.dataGridView_PW.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_PW.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridView_PW.Location = new System.Drawing.Point(3, 16);
			this.dataGridView_PW.MultiSelect = false;
			this.dataGridView_PW.Name = "dataGridView_PW";
			this.dataGridView_PW.ReadOnly = true;
			this.dataGridView_PW.RowHeadersVisible = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.dataGridView_PW.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView_PW.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridView_PW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_PW.Size = new System.Drawing.Size(203, 274);
			this.dataGridView_PW.TabIndex = 0;
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
			// nomePWDataGridViewTextBoxColumn
			// 
			this.nomePWDataGridViewTextBoxColumn.DataPropertyName = "nomePW";
			this.nomePWDataGridViewTextBoxColumn.HeaderText = "nomePW";
			this.nomePWDataGridViewTextBoxColumn.Name = "nomePWDataGridViewTextBoxColumn";
			this.nomePWDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// caminhoPastaDataGridViewTextBoxColumn
			// 
			this.caminhoPastaDataGridViewTextBoxColumn.DataPropertyName = "caminhoPasta";
			this.caminhoPastaDataGridViewTextBoxColumn.HeaderText = "caminhoPasta";
			this.caminhoPastaDataGridViewTextBoxColumn.Name = "caminhoPastaDataGridViewTextBoxColumn";
			this.caminhoPastaDataGridViewTextBoxColumn.ReadOnly = true;
			this.caminhoPastaDataGridViewTextBoxColumn.Visible = false;
			// 
			// caminhoEXEDataGridViewTextBoxColumn
			// 
			this.caminhoEXEDataGridViewTextBoxColumn.DataPropertyName = "caminhoEXE";
			this.caminhoEXEDataGridViewTextBoxColumn.HeaderText = "caminhoEXE";
			this.caminhoEXEDataGridViewTextBoxColumn.Name = "caminhoEXEDataGridViewTextBoxColumn";
			this.caminhoEXEDataGridViewTextBoxColumn.ReadOnly = true;
			this.caminhoEXEDataGridViewTextBoxColumn.Visible = false;
			// 
			// caminhoPatcherDataGridViewTextBoxColumn
			// 
			this.caminhoPatcherDataGridViewTextBoxColumn.DataPropertyName = "caminhoPatcher";
			this.caminhoPatcherDataGridViewTextBoxColumn.HeaderText = "caminhoPatcher";
			this.caminhoPatcherDataGridViewTextBoxColumn.Name = "caminhoPatcherDataGridViewTextBoxColumn";
			this.caminhoPatcherDataGridViewTextBoxColumn.ReadOnly = true;
			this.caminhoPatcherDataGridViewTextBoxColumn.Visible = false;
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
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.dataGridView_Conta);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(318, 87);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(259, 293);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Contas";
			// 
			// dataGridView_Conta
			// 
			this.dataGridView_Conta.AllowUserToAddRows = false;
			this.dataGridView_Conta.AllowUserToDeleteRows = false;
			this.dataGridView_Conta.AllowUserToResizeColumns = false;
			this.dataGridView_Conta.AllowUserToResizeRows = false;
			this.dataGridView_Conta.AutoGenerateColumns = false;
			this.dataGridView_Conta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView_Conta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView_Conta.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGridView_Conta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView_Conta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Conta.ColumnHeadersVisible = false;
			this.dataGridView_Conta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.loginDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn,
            this.pwDataGridViewTextBoxColumn,
            this.classeDataGridViewTextBoxColumn,
            this.nomeCharDataGridViewTextBoxColumn});
			this.dataGridView_Conta.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dataGridView_Conta.DataSource = this.contaspwBindingSource;
			this.dataGridView_Conta.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_Conta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridView_Conta.Location = new System.Drawing.Point(3, 16);
			this.dataGridView_Conta.Name = "dataGridView_Conta";
			this.dataGridView_Conta.ReadOnly = true;
			this.dataGridView_Conta.RowHeadersVisible = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			this.dataGridView_Conta.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_Conta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridView_Conta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_Conta.Size = new System.Drawing.Size(253, 274);
			this.dataGridView_Conta.TabIndex = 1;
			this.dataGridView_Conta.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Conta_CellMouseClick);
			// 
			// idDataGridViewTextBoxColumn1
			// 
			this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn1.HeaderText = "id";
			this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
			this.idDataGridViewTextBoxColumn1.ReadOnly = true;
			this.idDataGridViewTextBoxColumn1.Visible = false;
			// 
			// loginDataGridViewTextBoxColumn
			// 
			this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
			this.loginDataGridViewTextBoxColumn.HeaderText = "login";
			this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
			this.loginDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// senhaDataGridViewTextBoxColumn
			// 
			this.senhaDataGridViewTextBoxColumn.DataPropertyName = "senha";
			this.senhaDataGridViewTextBoxColumn.HeaderText = "senha";
			this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
			this.senhaDataGridViewTextBoxColumn.ReadOnly = true;
			this.senhaDataGridViewTextBoxColumn.Visible = false;
			// 
			// pwDataGridViewTextBoxColumn
			// 
			this.pwDataGridViewTextBoxColumn.DataPropertyName = "pw";
			this.pwDataGridViewTextBoxColumn.HeaderText = "pw";
			this.pwDataGridViewTextBoxColumn.Name = "pwDataGridViewTextBoxColumn";
			this.pwDataGridViewTextBoxColumn.ReadOnly = true;
			this.pwDataGridViewTextBoxColumn.Visible = false;
			// 
			// classeDataGridViewTextBoxColumn
			// 
			this.classeDataGridViewTextBoxColumn.DataPropertyName = "classe";
			this.classeDataGridViewTextBoxColumn.HeaderText = "classe";
			this.classeDataGridViewTextBoxColumn.Name = "classeDataGridViewTextBoxColumn";
			this.classeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nomeCharDataGridViewTextBoxColumn
			// 
			this.nomeCharDataGridViewTextBoxColumn.DataPropertyName = "NomeChar";
			this.nomeCharDataGridViewTextBoxColumn.HeaderText = "NomeChar";
			this.nomeCharDataGridViewTextBoxColumn.Name = "nomeCharDataGridViewTextBoxColumn";
			this.nomeCharDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// contaspwBindingSource
			// 
			this.contaspwBindingSource.DataMember = "contas_pw";
			this.contaspwBindingSource.DataSource = this.pwDBDataSet;
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Transparent;
			this.groupBox4.Controls.Add(this.pictureBox_Classes);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.ForeColor = System.Drawing.Color.White;
			this.groupBox4.Location = new System.Drawing.Point(106, 383);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(206, 139);
			this.groupBox4.TabIndex = 16;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Classe Selecionada";
			// 
			// pictureBox_Classes
			// 
			this.pictureBox_Classes.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox_Classes.BackgroundImage = global::OpenPW.Properties.Resources.fechar;
			this.pictureBox_Classes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_Classes.Cursor = System.Windows.Forms.Cursors.No;
			this.pictureBox_Classes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox_Classes.Location = new System.Drawing.Point(3, 16);
			this.pictureBox_Classes.Name = "pictureBox_Classes";
			this.pictureBox_Classes.Size = new System.Drawing.Size(200, 120);
			this.pictureBox_Classes.TabIndex = 10;
			this.pictureBox_Classes.TabStop = false;
			// 
			// pictureBox_play
			// 
			this.pictureBox_play.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox_play.BackgroundImage = global::OpenPW.Properties.Resources.fechar;
			this.pictureBox_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_play.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_play.Location = new System.Drawing.Point(360, 386);
			this.pictureBox_play.Name = "pictureBox_play";
			this.pictureBox_play.Size = new System.Drawing.Size(180, 136);
			this.pictureBox_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_play.TabIndex = 18;
			this.pictureBox_play.TabStop = false;
			this.pictureBox_play.Click += new System.EventHandler(this.pictureBox_play_Click);
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
			this.button_Fechar.Location = new System.Drawing.Point(576, 58);
			this.button_Fechar.Name = "button_Fechar";
			this.button_Fechar.Size = new System.Drawing.Size(37, 23);
			this.button_Fechar.TabIndex = 17;
			this.button_Fechar.UseVisualStyleBackColor = false;
			this.button_Fechar.Click += new System.EventHandler(this.button_Fechar_Click);
			// 
			// caminho_pwTableAdapter
			// 
			this.caminho_pwTableAdapter.ClearBeforeFill = true;
			// 
			// contas_pwTableAdapter
			// 
			this.contas_pwTableAdapter.ClearBeforeFill = true;
			// 
			// pictureBox_config
			// 
			this.pictureBox_config.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox_config.BackgroundImage = global::OpenPW.Properties.Resources.fechar;
			this.pictureBox_config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_config.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_config.Location = new System.Drawing.Point(557, 492);
			this.pictureBox_config.Name = "pictureBox_config";
			this.pictureBox_config.Size = new System.Drawing.Size(49, 32);
			this.pictureBox_config.TabIndex = 11;
			this.pictureBox_config.TabStop = false;
			this.toolTip_CONFIG.SetToolTip(this.pictureBox_config, "NOT FOUND KEY 4");
			this.pictureBox_config.Click += new System.EventHandler(this.pictureBox_config_Click);
			// 
			// pictureBox_pw
			// 
			this.pictureBox_pw.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox_pw.BackgroundImage = global::OpenPW.Properties.Resources.fechar;
			this.pictureBox_pw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_pw.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_pw.Location = new System.Drawing.Point(557, 421);
			this.pictureBox_pw.Name = "pictureBox_pw";
			this.pictureBox_pw.Size = new System.Drawing.Size(49, 32);
			this.pictureBox_pw.TabIndex = 11;
			this.pictureBox_pw.TabStop = false;
			this.toolTip_PW.SetToolTip(this.pictureBox_pw, "NOT FOUND KEY 5");
			this.pictureBox_pw.Visible = false;
			this.pictureBox_pw.Click += new System.EventHandler(this.pictureBox_pw_Click);
			// 
			// pictureBox_conta
			// 
			this.pictureBox_conta.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox_conta.BackgroundImage = global::OpenPW.Properties.Resources.fechar;
			this.pictureBox_conta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_conta.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_conta.Location = new System.Drawing.Point(557, 454);
			this.pictureBox_conta.Name = "pictureBox_conta";
			this.pictureBox_conta.Size = new System.Drawing.Size(49, 32);
			this.pictureBox_conta.TabIndex = 11;
			this.pictureBox_conta.TabStop = false;
			this.toolTip_CONTA.SetToolTip(this.pictureBox_conta, "NOT FOUND KEY 6");
			this.pictureBox_conta.Visible = false;
			this.pictureBox_conta.Click += new System.EventHandler(this.pictureBox_conta_Click);
			// 
			// label_VS
			// 
			this.label_VS.AutoSize = true;
			this.label_VS.BackColor = System.Drawing.Color.Transparent;
			this.label_VS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_VS.ForeColor = System.Drawing.Color.White;
			this.label_VS.Location = new System.Drawing.Point(106, 522);
			this.label_VS.Name = "label_VS";
			this.label_VS.Size = new System.Drawing.Size(69, 17);
			this.label_VS.TabIndex = 19;
			this.label_VS.Text = "VERSÃO:";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGoldenrod;
			this.BackgroundImage = global::OpenPW.Properties.Resources.fechar;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(662, 548);
			this.Controls.Add(this.label_VS);
			this.Controls.Add(this.pictureBox_conta);
			this.Controls.Add(this.pictureBox_pw);
			this.Controls.Add(this.pictureBox_config);
			this.Controls.Add(this.pictureBox_play);
			this.Controls.Add(this.button_Fechar);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_PW)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.caminhopwBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pwDBDataSet)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Conta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.contaspwBindingSource)).EndInit();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Classes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_play)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_config)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_pw)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_conta)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridView_PW;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridView_Conta;
		private System.Windows.Forms.PictureBox pictureBox_Classes;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button button_Fechar;
		private System.Windows.Forms.PictureBox pictureBox_play;
		private pwDBDataSet pwDBDataSet;
		private System.Windows.Forms.BindingSource caminhopwBindingSource;
		private pwDBDataSetTableAdapters.caminho_pwTableAdapter caminho_pwTableAdapter;
		private System.Windows.Forms.BindingSource contaspwBindingSource;
		private pwDBDataSetTableAdapters.contas_pwTableAdapter contas_pwTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomePWDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn caminhoPastaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn caminhoEXEDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn caminhoPatcherDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pwDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn classeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeCharDataGridViewTextBoxColumn;
		private System.Windows.Forms.PictureBox pictureBox_config;
		private System.Windows.Forms.PictureBox pictureBox_pw;
		private System.Windows.Forms.PictureBox pictureBox_conta;
		private System.Windows.Forms.ToolTip toolTip_CONFIG;
		private System.Windows.Forms.ToolTip toolTip_PW;
		private System.Windows.Forms.ToolTip toolTip_CONTA;
		private System.Windows.Forms.Label label_VS;
	}
}

