using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INIFile;

namespace OpenPW
{
	public partial class SavePW : Form
	{
		public SavePW()
		{
			LoadLocalizationText();
			InitializeComponent();
		}

		INIFile.INI ini;
		public static SortedList LocalizationText;
		public static int lLang = 0;

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

		public bool FULLEDIT { get; set; }

		int ID_CONT; bool EDIT = false; 

		private void SavePW_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'pwDBDataSet.contas_pw'. Você pode movê-la ou removê-la conforme necessário.
			this.contas_pwTableAdapter.Fill(this.pwDBDataSet.contas_pw);
			// TODO: esta linha de código carrega dados na tabela 'pwDBDataSet.caminho_pw'. Você pode movê-la ou removê-la conforme necessário.
			this.caminho_pwTableAdapter.Fill(this.pwDBDataSet.caminho_pw);

			dataGridView_PW.ClearSelection();
			tamanos();
			IMGS();
			GET();
			if (FULLEDIT == true)
			{
				timer_edit.Start();
				//timer_edit_Tick( sender,  e);
			}
		}

		void IMGS()
		{
			ini = new INIFile.INI(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img.ini"));

			Bitmap BMP_BtClose = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, ini.ReadValue("main", "BMP_BtClose")));
			Bitmap BMP_BacF = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, ini.ReadValue("file", "BMP_BacF")));
			Bitmap BMP_Bus = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, ini.ReadValue("file", "BMP_Bus")));
			Bitmap BMP_SALVE = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, ini.ReadValue("file", "BMP_SALVE")));
			Bitmap BMP_SALVE_name = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, ini.ReadValue("file", "BMP_SALVE_name")));
			Bitmap BMP_MENU = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, ini.ReadValue("file", "BMP_MENU")));

			eDITARToolStripMenuItem.Image = BMP_MENU;
			dELETARToolStripMenuItem.Image = BMP_MENU;
			pictureBox_SALVAR.BackgroundImage = BMP_SALVE; pictureBox_SALVAR.Image = BMP_SALVE_name;
			pictureBox_DELETAR.BackgroundImage = BMP_SALVE;
			this.BackgroundImage = BMP_BacF;
			button_Fechar.BackgroundImage = BMP_BtClose;
			pictureBox_buscaEXE.BackgroundImage = BMP_Bus; pictureBox_buscaPasta.BackgroundImage = BMP_Bus; pictureBox_buscaPT.BackgroundImage = BMP_Bus;



			this.TransparencyKey = this.BackColor;
		}
		void tamanos()
		{
			#region INI
			ini = new INIFile.INI(Path.Combine(System.Windows.Forms.Application.StartupPath, @"sizes.ini"));
			#endregion

			
			#region FM

			this.ClientSize = new System.Drawing.Size(Convert.ToInt32(ini.ReadValue("file", "formH")), Convert.ToInt32(ini.ReadValue("file", "formW")));

			this.button_Fechar.Location = new System.Drawing.Point(Convert.ToInt32(ini.ReadValue("file", "closeX")), Convert.ToInt32(ini.ReadValue("file", "closeY")));
			this.button_Fechar.Size = new System.Drawing.Size(Convert.ToInt32(ini.ReadValue("file", "closeH")), Convert.ToInt32(ini.ReadValue("file", "closeW")));

			this.groupBox2.Location = new System.Drawing.Point(Convert.ToInt32(ini.ReadValue("file", "gridX")), Convert.ToInt32(ini.ReadValue("file", "gridY")));
			this.groupBox2.Size = new System.Drawing.Size(Convert.ToInt32(ini.ReadValue("file", "gridH")), Convert.ToInt32(ini.ReadValue("file", "gridW"))); 

			this.textBox_nomePW.Location = new System.Drawing.Point(Convert.ToInt32(ini.ReadValue("file", "txtnameX")), Convert.ToInt32(ini.ReadValue("file", "txtnameY"))); 
			this.textBox_nomePW.Size = new System.Drawing.Size(Convert.ToInt32(ini.ReadValue("file", "txtnameH")), Convert.ToInt32(ini.ReadValue("file", "txtnameW"))); 

			this.label1.Location = new System.Drawing.Point(Convert.ToInt32(ini.ReadValue("file", "lbnameX")), Convert.ToInt32(ini.ReadValue("file", "lbnameY"))); // nome pw
			this.label1.Size = new System.Drawing.Size(Convert.ToInt32(ini.ReadValue("file", "lbnameH")), Convert.ToInt32(ini.ReadValue("file", "lbnameW"))); 

			this.textBox_pastaPW.Location = new System.Drawing.Point(Convert.ToInt32(ini.ReadValue("file", "fileX")), Convert.ToInt32(ini.ReadValue("file", "fileY")));
			this.textBox_pastaPW.Size = new System.Drawing.Size(Convert.ToInt32(ini.ReadValue("file", "fileH")), Convert.ToInt32(ini.ReadValue("file", "fileW"))); 

			this.label2.Location = new System.Drawing.Point(Convert.ToInt32(ini.ReadValue("file", "lbfileX")), Convert.ToInt32(ini.ReadValue("file", "lbfileY"))); // pasta pw
			this.label2.Size = new System.Drawing.Size(Convert.ToInt32(ini.ReadValue("file", "lbfileH")), Convert.ToInt32(ini.ReadValue("file", "lbfileW"))); 

			this.textBox_exePW.Location = new System.Drawing.Point(Convert.ToInt32(ini.ReadValue("file", "exeX")), Convert.ToInt32(ini.ReadValue("file", "exeY"))); 
			this.textBox_exePW.Size = new System.Drawing.Size(Convert.ToInt32(ini.ReadValue("file", "exeH")), Convert.ToInt32(ini.ReadValue("file", "exeW"))); 

			this.label3.Location = new System.Drawing.Point(Convert.ToInt32(ini.ReadValue("file", "lbexeX")), Convert.ToInt32(ini.ReadValue("file", "lbexeY"))); // exe
			this.label3.Size = new System.Drawing.Size(Convert.ToInt32(ini.ReadValue("file", "lbexeH")), Convert.ToInt32(ini.ReadValue("file", "lbexeW")));


			this.textBox_ptPW.Location = new System.Drawing.Point(Convert.ToInt32(ini.ReadValue("file", "patX")), Convert.ToInt32(ini.ReadValue("file", "patY")));
			this.textBox_ptPW.Size = new System.Drawing.Size(Convert.ToInt32(ini.ReadValue("file", "patH")), Convert.ToInt32(ini.ReadValue("file", "patW"))); 

			this.label4.Location = new System.Drawing.Point(Convert.ToInt32(ini.ReadValue("file", "lbpatX")), Convert.ToInt32(ini.ReadValue("file", "lbpatY"))); //patcher
			this.label4.Size = new System.Drawing.Size(Convert.ToInt32(ini.ReadValue("file", "lbpatH")), Convert.ToInt32(ini.ReadValue("file", "lbpatW")));


			this.pictureBox_SALVAR.Location = new System.Drawing.Point(Convert.ToInt32(ini.ReadValue("file", "salvarX")), Convert.ToInt32(ini.ReadValue("file", "salvarY"))); 
			this.pictureBox_SALVAR.Size = new System.Drawing.Size(Convert.ToInt32(ini.ReadValue("file", "salvarH")), Convert.ToInt32(ini.ReadValue("file", "salvarW")));

			#endregion





		}

		private void button_Fechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pictureBox_buscaPasta_Click(object sender, EventArgs e)
		{
			string CM = null;
			FolderBrowserDialog browser = new FolderBrowserDialog();
			if (browser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				CM = browser.SelectedPath;
				textBox_pastaPW.Text = CM+ @"\element";
				textBox_exePW.Text = CM + @"\element\ELEMENTCLIENT.exe";
				textBox_ptPW.Text = CM + @"\patcher\patcher.exe";
			}
		}

		private void pictureBox_buscaEXE_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "ELEMENTECILENT (*.exe)|.exe|All files (*.*)|*.*";
			dialog.InitialDirectory = @"C:\";
			dialog.Title = Class_ling.GetLocalization(28) ;
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				textBox_exePW.Text = dialog.FileName;
			}
		}

		private void pictureBox_buscaPT_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "PATCHER (*.exe)|*.exe|All files (*.*)|*.*";
			dialog.InitialDirectory = @"C:\";
			dialog.Title = Class_ling.GetLocalization(28);
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				textBox_ptPW.Text = dialog.FileName;
			}
		}

		private void SavePW_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void pictureBox_SALVAR_MouseHover(object sender, EventArgs e)
		{
			Bitmap BMP_SALVE = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img\bttrues.png"));
			pictureBox_SALVAR.BackgroundImage = BMP_SALVE;
		}

		private void pictureBox_SALVAR_MouseLeave(object sender, EventArgs e)
		{
			Bitmap BMP_SALVE = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img\btfalse.png"));
			pictureBox_SALVAR.BackgroundImage = BMP_SALVE;
		}

		private void pictureBox_SALVAR_Click(object sender, EventArgs e)
		{
			if (EDIT == true)
			{
					if (ID_CONT != 0)
					{
						if (textBox_nomePW.Text != "" && textBox_pastaPW.Text != "" && textBox_exePW.Text != "" && textBox_ptPW.Text != "")
						{
							this.caminho_pwTableAdapter.UpdateQueryCaminho(textBox_nomePW.Text, textBox_pastaPW.Text, textBox_exePW.Text, textBox_ptPW.Text, ID_CONT);
							MessageBox.Show(Class_ling.GetLocalization(27), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
							textBox_nomePW.Clear(); textBox_pastaPW.Clear(); textBox_exePW.Clear(); textBox_ptPW.Clear();
							this.caminho_pwTableAdapter.Fill(this.pwDBDataSet.caminho_pw);
							EDIT = false;
						}
						else
						{
							MessageBox.Show(Class_ling.GetLocalization(26), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}				
			}
			else
			{
				if (textBox_nomePW.Text != "" && textBox_pastaPW.Text != "" && textBox_exePW.Text != "" && textBox_ptPW.Text != "")
				{
					this.caminho_pwTableAdapter.InsertQueryPW(textBox_nomePW.Text, textBox_pastaPW.Text, textBox_exePW.Text, textBox_ptPW.Text);
					MessageBox.Show(Class_ling.GetLocalization(27), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					textBox_nomePW.Clear(); textBox_pastaPW.Clear(); textBox_exePW.Clear(); textBox_ptPW.Clear();
					this.caminho_pwTableAdapter.Fill(this.pwDBDataSet.caminho_pw);

				}
				else
				{
					MessageBox.Show(Class_ling.GetLocalization(26), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}			

		}

		private void eDITARToolStripMenuItem_Click(object sender, EventArgs e)
		{
			

			if (ID_CONT != 0)
			{
				textBox_nomePW.Text = dataGridView_PW.CurrentRow.Cells[1].Value.ToString();
				textBox_pastaPW.Text = dataGridView_PW.CurrentRow.Cells[2].Value.ToString();
				textBox_exePW.Text = dataGridView_PW.CurrentRow.Cells[3].Value.ToString();
				textBox_ptPW.Text = dataGridView_PW.CurrentRow.Cells[4].Value.ToString();
				EDIT = true;
			}
			else
			{
				MessageBox.Show(Class_ling.GetLocalization(25), Class_ling.GetLocalization(19), MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void dELETARToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (ID_CONT != 0)
			{
				if (MessageBox.Show(Class_ling.GetLocalization(24), Class_ling.GetLocalization(13), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try
					{
						this.caminho_pwTableAdapter.DeleteQueryCaminho(ID_CONT); this.contas_pwTableAdapter.DeleteQueryCAMINHO(ID_CONT);
						this.caminho_pwTableAdapter.Fill(this.pwDBDataSet.caminho_pw);
						MessageBox.Show(Class_ling.GetLocalization(22), Class_ling.GetLocalization(23), MessageBoxButtons.OK, MessageBoxIcon.Information);
						dataGridView_PW.ClearSelection();
						ID_CONT = 0;
					}
					catch (Exception ex)
					{
						MessageBox.Show(Class_ling.GetLocalization(21) + ex); ;
					}
				}
				else
				{
					MessageBox.Show(Class_ling.GetLocalization(20));
				}
			}
			else
			{
				MessageBox.Show(Class_ling.GetLocalization(18), Class_ling.GetLocalization(19), MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void dataGridView_PW_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			ID_CONT = Convert.ToInt32(dataGridView_PW.Rows[e.RowIndex].Cells[0].Value.ToString());
		}

		public void LoadLocalizationText()
		{

			LocalizationText = new SortedList();
			string path = @"\language_ptbr.openpw";
			if (MainWindow.lLang == 0) path = @"\language_ptbr.openpw";
			if (MainWindow.lLang == 1) path = @"\language_ru.openpw";
			if (MainWindow.lLang == 2) path = @"\language_en.openpw";
			if (File.Exists(Application.StartupPath + "\\localization" + path))
			{
				try
				{
					StreamReader sr = new StreamReader(Application.StartupPath + "\\localization" + path, Encoding.Unicode);

					char[] seperator = new char[] { '"' };
					string line;
					string[] split;
					while (!sr.EndOfStream)
					{
						line = sr.ReadLine();
						if (line != "" && !line.StartsWith("/") && !line.StartsWith("#"))
						{
							split = line.Split(seperator);
							LocalizationText.Add(split[0].Trim(), split[1]);
						}
					}

					sr.Close();
				}
				catch (Exception e)
				{
					MessageBox.Show("ERROR LOADING LOCALIZATION\n" + e.Message);
				}
			}
			else
			{
				MessageBox.Show("NOT FOUND localization" + path + "!");
			}
		}

		void GET()
		{
			this.label4.Text = Class_ling.GetLocalization(17);
			this.label3.Text = Class_ling.GetLocalization(16);
			this.label2.Text = Class_ling.GetLocalization(15);
			this.label1.Text = Class_ling.GetLocalization(14);
			this.dELETARToolStripMenuItem.Text = Class_ling.GetLocalization(13);
		}
		
	}
}
