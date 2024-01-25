namespace OpenPW
{
	partial class SavePW
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavePW));
			this.button_Fechar = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView_PW = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomePWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.caminhoPastaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.caminhoEXEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.caminhoPatcherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenuStrip_DATAg = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.eDITARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dELETARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.caminhopwBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pwDBDataSet = new OpenPW.pwDBDataSet();
			this.textBox_nomePW = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_pastaPW = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_exePW = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox_ptPW = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox_buscaPasta = new System.Windows.Forms.PictureBox();
			this.pictureBox_buscaEXE = new System.Windows.Forms.PictureBox();
			this.pictureBox_buscaPT = new System.Windows.Forms.PictureBox();
			this.pictureBox_DELETAR = new System.Windows.Forms.PictureBox();
			this.pictureBox_SALVAR = new System.Windows.Forms.PictureBox();
			this.pictureBox_Editar = new System.Windows.Forms.PictureBox();
			this.caminho_pwTableAdapter = new OpenPW.pwDBDataSetTableAdapters.caminho_pwTableAdapter();
			this.contas_pwBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.contas_pwTableAdapter = new OpenPW.pwDBDataSetTableAdapters.contas_pwTableAdapter();
			this.tableAdapterManager = new OpenPW.pwDBDataSetTableAdapters.TableAdapterManager();
			this.timer_edit = new System.Windows.Forms.Timer(this.components);
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_PW)).BeginInit();
			this.contextMenuStrip_DATAg.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.caminhopwBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pwDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_buscaPasta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_buscaEXE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_buscaPT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_DELETAR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_SALVAR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Editar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.contas_pwBindingSource)).BeginInit();
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
			this.button_Fechar.Location = new System.Drawing.Point(576, 58);
			this.button_Fechar.Name = "button_Fechar";
			this.button_Fechar.Size = new System.Drawing.Size(37, 23);
			this.button_Fechar.TabIndex = 18;
			this.button_Fechar.UseVisualStyleBackColor = false;
			this.button_Fechar.Click += new System.EventHandler(this.button_Fechar_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.dataGridView_PW);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(72, 88);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(528, 199);
			this.groupBox2.TabIndex = 19;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = Class_ling.GetLocalization(1);
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
			this.dataGridView_PW.ContextMenuStrip = this.contextMenuStrip_DATAg;
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
			this.dataGridView_PW.Size = new System.Drawing.Size(522, 180);
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
			// contextMenuStrip_DATAg
			// 
			this.contextMenuStrip_DATAg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eDITARToolStripMenuItem,
            this.dELETARToolStripMenuItem});
			this.contextMenuStrip_DATAg.Name = "contextMenuStrip_DATAg";
			this.contextMenuStrip_DATAg.Size = new System.Drawing.Size(179, 48);
			// 
			// eDITARToolStripMenuItem
			// 
			this.eDITARToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.eDITARToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.eDITARToolStripMenuItem.Image = global::OpenPW.Properties.Resources.fechar;
			this.eDITARToolStripMenuItem.Name = "eDITARToolStripMenuItem";
			this.eDITARToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.eDITARToolStripMenuItem.Text = Class_ling.GetLocalization(12);
			this.eDITARToolStripMenuItem.Click += new System.EventHandler(this.eDITARToolStripMenuItem_Click);
			// 
			// dELETARToolStripMenuItem
			// 
			this.dELETARToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.dELETARToolStripMenuItem.Image = global::OpenPW.Properties.Resources.fechar;
			this.dELETARToolStripMenuItem.Name = "dELETARToolStripMenuItem";
			this.dELETARToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.dELETARToolStripMenuItem.Text = Class_ling.GetLocalization(13);
			this.dELETARToolStripMenuItem.Click += new System.EventHandler(this.dELETARToolStripMenuItem_Click);
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
			// textBox_nomePW
			// 
			this.textBox_nomePW.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.textBox_nomePW.Location = new System.Drawing.Point(72, 312);
			this.textBox_nomePW.Name = "textBox_nomePW";
			this.textBox_nomePW.Size = new System.Drawing.Size(528, 20);
			this.textBox_nomePW.TabIndex = 20;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(72, 296);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 13);
			this.label1.TabIndex = 21;
			this.label1.Text = Class_ling.GetLocalization(14);
			// 
			// textBox_pastaPW
			// 
			this.textBox_pastaPW.Location = new System.Drawing.Point(72, 351);
			this.textBox_pastaPW.Name = "textBox_pastaPW";
			this.textBox_pastaPW.Size = new System.Drawing.Size(490, 20);
			this.textBox_pastaPW.TabIndex = 20;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(72, 335);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 13);
			this.label2.TabIndex = 21;
			this.label2.Text = Class_ling.GetLocalization(15);
			// 
			// textBox_exePW
			// 
			this.textBox_exePW.Location = new System.Drawing.Point(72, 390);
			this.textBox_exePW.Name = "textBox_exePW";
			this.textBox_exePW.Size = new System.Drawing.Size(490, 20);
			this.textBox_exePW.TabIndex = 20;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(69, 374);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 13);
			this.label3.TabIndex = 21;
			this.label3.Text = Class_ling.GetLocalization(16);
			// 
			// textBox_ptPW
			// 
			this.textBox_ptPW.Location = new System.Drawing.Point(72, 429);
			this.textBox_ptPW.Name = "textBox_ptPW";
			this.textBox_ptPW.Size = new System.Drawing.Size(490, 20);
			this.textBox_ptPW.TabIndex = 20;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(72, 413);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(126, 13);
			this.label4.TabIndex = 21;
			this.label4.Text = Class_ling.GetLocalization(17);
			// 
			// pictureBox_buscaPasta
			// 
			this.pictureBox_buscaPasta.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox_buscaPasta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_buscaPasta.BackgroundImage")));
			this.pictureBox_buscaPasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox_buscaPasta.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_buscaPasta.Location = new System.Drawing.Point(569, 351);
			this.pictureBox_buscaPasta.Name = "pictureBox_buscaPasta";
			this.pictureBox_buscaPasta.Size = new System.Drawing.Size(28, 19);
			this.pictureBox_buscaPasta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_buscaPasta.TabIndex = 22;
			this.pictureBox_buscaPasta.TabStop = false;
			this.pictureBox_buscaPasta.Click += new System.EventHandler(this.pictureBox_buscaPasta_Click);
			// 
			// pictureBox_buscaEXE
			// 
			this.pictureBox_buscaEXE.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox_buscaEXE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_buscaEXE.BackgroundImage")));
			this.pictureBox_buscaEXE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox_buscaEXE.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_buscaEXE.Location = new System.Drawing.Point(568, 391);
			this.pictureBox_buscaEXE.Name = "pictureBox_buscaEXE";
			this.pictureBox_buscaEXE.Size = new System.Drawing.Size(28, 19);
			this.pictureBox_buscaEXE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_buscaEXE.TabIndex = 22;
			this.pictureBox_buscaEXE.TabStop = false;
			this.pictureBox_buscaEXE.Click += new System.EventHandler(this.pictureBox_buscaEXE_Click);
			// 
			// pictureBox_buscaPT
			// 
			this.pictureBox_buscaPT.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox_buscaPT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_buscaPT.BackgroundImage")));
			this.pictureBox_buscaPT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox_buscaPT.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_buscaPT.Location = new System.Drawing.Point(568, 430);
			this.pictureBox_buscaPT.Name = "pictureBox_buscaPT";
			this.pictureBox_buscaPT.Size = new System.Drawing.Size(28, 19);
			this.pictureBox_buscaPT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_buscaPT.TabIndex = 22;
			this.pictureBox_buscaPT.TabStop = false;
			this.pictureBox_buscaPT.Click += new System.EventHandler(this.pictureBox_buscaPT_Click);
			// 
			// pictureBox_DELETAR
			// 
			this.pictureBox_DELETAR.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox_DELETAR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_DELETAR.BackgroundImage")));
			this.pictureBox_DELETAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox_DELETAR.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_DELETAR.Location = new System.Drawing.Point(94, 0);
			this.pictureBox_DELETAR.Name = "pictureBox_DELETAR";
			this.pictureBox_DELETAR.Size = new System.Drawing.Size(92, 64);
			this.pictureBox_DELETAR.TabIndex = 22;
			this.pictureBox_DELETAR.TabStop = false;
			this.pictureBox_DELETAR.Visible = false;
			// 
			// pictureBox_SALVAR
			// 
			this.pictureBox_SALVAR.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox_SALVAR.BackgroundImage = global::OpenPW.Properties.Resources.fechar;
			this.pictureBox_SALVAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox_SALVAR.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_SALVAR.Location = new System.Drawing.Point(343, 463);
			this.pictureBox_SALVAR.Name = "pictureBox_SALVAR";
			this.pictureBox_SALVAR.Size = new System.Drawing.Size(257, 73);
			this.pictureBox_SALVAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_SALVAR.TabIndex = 22;
			this.pictureBox_SALVAR.TabStop = false;
			this.pictureBox_SALVAR.Click += new System.EventHandler(this.pictureBox_SALVAR_Click);
			this.pictureBox_SALVAR.MouseLeave += new System.EventHandler(this.pictureBox_SALVAR_MouseLeave);
			this.pictureBox_SALVAR.MouseHover += new System.EventHandler(this.pictureBox_SALVAR_MouseHover);
			// 
			// pictureBox_Editar
			// 
			this.pictureBox_Editar.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox_Editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Editar.BackgroundImage")));
			this.pictureBox_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_Editar.Location = new System.Drawing.Point(-4, 0);
			this.pictureBox_Editar.Name = "pictureBox_Editar";
			this.pictureBox_Editar.Size = new System.Drawing.Size(92, 64);
			this.pictureBox_Editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_Editar.TabIndex = 22;
			this.pictureBox_Editar.TabStop = false;
			this.pictureBox_Editar.Visible = false;
			// 
			// caminho_pwTableAdapter
			// 
			this.caminho_pwTableAdapter.ClearBeforeFill = true;
			// 
			// contas_pwBindingSource
			// 
			this.contas_pwBindingSource.DataMember = "contas_pw";
			this.contas_pwBindingSource.DataSource = this.pwDBDataSet;
			// 
			// contas_pwTableAdapter
			// 
			this.contas_pwTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.caminho_pwTableAdapter = this.caminho_pwTableAdapter;
			this.tableAdapterManager.contas_pwTableAdapter = this.contas_pwTableAdapter;
			this.tableAdapterManager.UpdateOrder = OpenPW.pwDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// timer_edit
			// 
			// 
			// SavePW
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGoldenrod;
			this.BackgroundImage = global::OpenPW.Properties.Resources.fechar;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(662, 556);
			this.Controls.Add(this.pictureBox_Editar);
			this.Controls.Add(this.pictureBox_SALVAR);
			this.Controls.Add(this.pictureBox_DELETAR);
			this.Controls.Add(this.pictureBox_buscaPT);
			this.Controls.Add(this.pictureBox_buscaEXE);
			this.Controls.Add(this.pictureBox_buscaPasta);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox_ptPW);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox_exePW);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox_pastaPW);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_nomePW);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.button_Fechar);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SavePW";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.SavePW_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SavePW_MouseDown);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_PW)).EndInit();
			this.contextMenuStrip_DATAg.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.caminhopwBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pwDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_buscaPasta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_buscaEXE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_buscaPT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_DELETAR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_SALVAR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Editar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.contas_pwBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_Fechar;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridView_PW;
		private System.Windows.Forms.TextBox textBox_nomePW;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_pastaPW;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_exePW;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox_ptPW;
		private System.Windows.Forms.Label label4;
		private pwDBDataSet pwDBDataSet;
		private System.Windows.Forms.BindingSource caminhopwBindingSource;
		private pwDBDataSetTableAdapters.caminho_pwTableAdapter caminho_pwTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomePWDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn caminhoPastaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn caminhoEXEDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn caminhoPatcherDataGridViewTextBoxColumn;
		private System.Windows.Forms.PictureBox pictureBox_buscaPasta;
		private System.Windows.Forms.PictureBox pictureBox_buscaEXE;
		private System.Windows.Forms.PictureBox pictureBox_buscaPT;
		private System.Windows.Forms.PictureBox pictureBox_DELETAR;
		private System.Windows.Forms.PictureBox pictureBox_SALVAR;
		private System.Windows.Forms.PictureBox pictureBox_Editar;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_DATAg;
		private System.Windows.Forms.ToolStripMenuItem eDITARToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dELETARToolStripMenuItem;
		private System.Windows.Forms.BindingSource contas_pwBindingSource;
		private pwDBDataSetTableAdapters.contas_pwTableAdapter contas_pwTableAdapter;
		private pwDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.Timer timer_edit;
	}
}