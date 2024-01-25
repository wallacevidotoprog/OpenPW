namespace OpenPW
{
	partial class Form1_Edit
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
			this.panel_central = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel_Conf = new System.Windows.Forms.Panel();
			this.panel_pw = new System.Windows.Forms.Panel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.numericUpDown_formW = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_formH = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel_Conf.SuspendLayout();
			this.panel_pw.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_formW)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_formH)).BeginInit();
			this.SuspendLayout();
			// 
			// panel_central
			// 
			this.panel_central.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel_central.BackColor = System.Drawing.Color.Black;
			this.panel_central.Location = new System.Drawing.Point(445, 12);
			this.panel_central.Name = "panel_central";
			this.panel_central.Size = new System.Drawing.Size(852, 590);
			this.panel_central.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(434, 49);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 19);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panel_Conf);
			this.groupBox2.Location = new System.Drawing.Point(12, 67);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(434, 535);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "groupBox2";
			// 
			// panel_Conf
			// 
			this.panel_Conf.Controls.Add(this.panel_pw);
			this.panel_Conf.Location = new System.Drawing.Point(6, 19);
			this.panel_Conf.Name = "panel_Conf";
			this.panel_Conf.Size = new System.Drawing.Size(422, 510);
			this.panel_Conf.TabIndex = 0;
			// 
			// panel_pw
			// 
			this.panel_pw.Controls.Add(this.tabControl1);
			this.panel_pw.Location = new System.Drawing.Point(3, 0);
			this.panel_pw.Name = "panel_pw";
			this.panel_pw.Size = new System.Drawing.Size(422, 510);
			this.panel_pw.TabIndex = 3;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(422, 510);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.numericUpDown_formW);
			this.tabPage1.Controls.Add(this.numericUpDown_formH);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(414, 484);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "TAMANOS I";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// numericUpDown_formW
			// 
			this.numericUpDown_formW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown_formW.Location = new System.Drawing.Point(186, 66);
			this.numericUpDown_formW.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown_formW.Name = "numericUpDown_formW";
			this.numericUpDown_formW.Size = new System.Drawing.Size(44, 23);
			this.numericUpDown_formW.TabIndex = 4;
			this.numericUpDown_formW.ValueChanged += new System.EventHandler(this.salvar);
			// 
			// numericUpDown_formH
			// 
			this.numericUpDown_formH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown_formH.Location = new System.Drawing.Point(186, 19);
			this.numericUpDown_formH.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown_formH.Name = "numericUpDown_formH";
			this.numericUpDown_formH.Size = new System.Drawing.Size(44, 23);
			this.numericUpDown_formH.TabIndex = 4;
			this.numericUpDown_formH.ValueChanged += new System.EventHandler(this.salvar);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(4, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(170, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "FORMULÁRIO LARGURA\r\n";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "FORMULÁRIO ALTURA";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(414, 484);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "TAMANOS II";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(414, 484);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "LOCAL I";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(414, 484);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "LOCAL II";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(186, 20);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1_Edit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1297, 614);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel_central);
			this.Name = "Form1_Edit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1_Edit";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.panel_Conf.ResumeLayout(false);
			this.panel_pw.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_formW)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_formH)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel_central;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Panel panel_Conf;
		private System.Windows.Forms.Panel panel_pw;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.NumericUpDown numericUpDown_formW;
		private System.Windows.Forms.NumericUpDown numericUpDown_formH;
		private System.Windows.Forms.Button button2;
	}
}