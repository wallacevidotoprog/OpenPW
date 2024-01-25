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
	public partial class SaveAcc : Form
	{
		public SaveAcc()
		{
			LoadLocalizationText();
			InitializeComponent();
		}

		INIFile.INI ini;

		public static SortedList LocalizationText;

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
				private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

		CheckBox XV = new CheckBox();
		bool EDIT; int ID_CONTA;

		[System.ComponentModel.Browsable(false)]
		public override System.Drawing.Image BackgroundImage { get; set; }

		private void SaveAcc_Load(object sender, EventArgs e)
		{
			//this.TransparencyKey = Color.Magenta;
			// TODO: esta linha de código carrega dados na tabela 'pwDBDataSet.caminho_pw'. Você pode movê-la ou removê-la conforme necessário.
			this.caminho_pwTableAdapter.FillBy2(this.pwDBDataSet.caminho_pw);
			// TODO: esta linha de código carrega dados na tabela 'pwDBDataSet.contas_pw'. Você pode movê-la ou removê-la conforme necessário.
			this.contas_pwTableAdapter.Fill_INNER(this.pwDBDataSet.contas_pw);

			comboBox_Classes.Text = "[ CLASSE ]";
			XV.Checked = true;

			this.TransparencyKey = this.BackColor;

			dataGridView_PW.ClearSelection();

			IMGS();
			pictureBox_Check_Click( sender,  e);
			comboBox_IdPw.DropDownStyle = ComboBoxStyle.DropDownList;
			dataGridView_PW.ClearSelection();
			GET();
		}

		private void SaveAcc_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		void IMGS()
		{

			ini = new INIFile.INI(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img.ini"));

			//Bitmap BMP_BtClose = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img\close.png"));
			//Bitmap BMP_BacF = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img\background_2.png"));
			//Bitmap BMP_PbCLass = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img\neutro.png"));
			//Bitmap BMP_SALVE = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img\btfalse.png"));
			//Bitmap BMP_SALVE_name = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img\btsave.png"));
			//Bitmap BMP_MENU = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img\seta.png"));

			//Bitmap BMP_BB = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img\focus.png"));

			Bitmap BMP_BtClose = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, ini.ReadValue("main", "BMP_BtClose")));
			Bitmap BMP_BacF = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, ini.ReadValue("acc", "BMP_BacF")));
			Bitmap BMP_PbCLass = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, ini.ReadValue("acc", "BMP_PbCLass")));
			Bitmap BMP_SALVE = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, ini.ReadValue("acc", "BMP_SALVE")));
			Bitmap BMP_SALVE_name = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, ini.ReadValue("acc", "BMP_SALVE_name")));
			Bitmap BMP_MENU = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, ini.ReadValue("acc", "BMP_MENU")));

			Bitmap BMP_BB = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, ini.ReadValue("acc", "BMP_BB")));


			this.panel_LOG.BackgroundImage = BMP_BB;
			this.panel_LOG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

			oiToolStripMenuItem.Image = BMP_MENU; dELETARToolStripMenuItem.Image = BMP_MENU;
			this.BackgroundImage = BMP_BacF;
			button_Fechar.BackgroundImage = BMP_BtClose;
			pictureBox_Classes.BackgroundImage = BMP_PbCLass;
			pictureBox_salve.BackgroundImage = BMP_SALVE; pictureBox_salve.Image = BMP_SALVE_name;

			this.TransparencyKey = this.BackColor;
		}

		private void button_Fechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pictureBox_Check_Click(object sender, EventArgs e)
		{

			if (XV.Checked == true)
			{
				textBox_Senha.PasswordChar = '*';
				Bitmap BMP_PbCLass = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img\close.png"));
				pictureBox_Check.BackgroundImage = BMP_PbCLass;
				XV.Checked = false;

			}
			else
			{
				//textBox_Senha.PasswordChar = '\0';
				textBox_Senha.PasswordChar = '1'; //char.Parse("");


				Bitmap BMP_PbCLass = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img\true.png"));
				pictureBox_Check.BackgroundImage = BMP_PbCLass;
				XV.Checked = true;
			}
		}

		private void comboBox_Classes_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			try
			{
				Bitmap BMP_PbCLass = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img\pers\" + Convert.ToString(comboBox_Classes.Text) + ".png"));
				
				pictureBox_Classes.BackgroundImage = BMP_PbCLass;
			}
			catch (Exception)
			{
				Bitmap BMP_PbCLass = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img\neutro.png"));
				pictureBox_Classes.BackgroundImage = BMP_PbCLass;
			}
			
			

		}


		private void pictureBox_salve_MouseHover(object sender, EventArgs e)
		{
			//fica em cima
			Bitmap BMP_SALVE = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img\bttrues.png"));
			pictureBox_salve.BackgroundImage = BMP_SALVE;

		}

		private void pictureBox_salve_MouseLeave(object sender, EventArgs e)
		{
			//sai de cima
			Bitmap BMP_SALVE = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img\btfalse.png"));
			pictureBox_salve.BackgroundImage = BMP_SALVE;

		}

		private void pictureBox_salve_Click(object sender, EventArgs e)
		{
			if (EDIT == true)
			{
				this.contas_pwTableAdapter.UpdateQueryCONTA(textBox_Login.Text, textBox_Senha.Text, Convert.ToInt32(comboBox_IdPw.SelectedValue), comboBox_Classes.Text, textBox_Char.Text, ID_CONTA);
				MessageBox.Show("Conta alterada com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

				textBox_Login.Text = "login";
				textBox_Senha.Text = "senha";
				textBox_Char.Text = "[ CLASSE ]";
				dataGridView_PW.ClearSelection(); EDIT = false;
			}
			else
			{
				this.contas_pwTableAdapter.InsertQueryCONTA(textBox_Login.Text, textBox_Senha.Text, Convert.ToInt32(comboBox_IdPw.SelectedValue), comboBox_Classes.Text, textBox_Char.Text);
				MessageBox.Show("Conta cadastrada com sucesso!","",MessageBoxButtons.OK,MessageBoxIcon.Information);

				textBox_Login.Text = "login";
				textBox_Senha.Text = "senha";
				textBox_Char.Text = "[ CLASSE ]";
				dataGridView_PW.ClearSelection(); EDIT = false;
			}
			this.contas_pwTableAdapter.Fill_INNER(this.pwDBDataSet.contas_pw);
		}

		private void dataGridView_PW_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			ID_CONTA = int.Parse(dataGridView_PW.CurrentRow.Cells[0].Value.ToString());
		}

		private void oiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Deseja editar a conta:"+ dataGridView_PW.CurrentRow.Cells[1].Value.ToString(),"",MessageBoxButtons.YesNo,MessageBoxIcon.Question) ==DialogResult.Yes)
			{
				textBox_Login.Text = dataGridView_PW.CurrentRow.Cells[1].Value.ToString();
				textBox_Senha.Text = dataGridView_PW.CurrentRow.Cells[2].Value.ToString();
				comboBox_IdPw.Text = dataGridView_PW.CurrentRow.Cells[3].Value.ToString();
				comboBox_Classes.Text = dataGridView_PW.CurrentRow.Cells[4].Value.ToString();
				textBox_Char.Text = dataGridView_PW.CurrentRow.Cells[5].Value.ToString();
				EDIT = true;
			}
			else
			{
				ID_CONTA = 0;
				EDIT = false;
			}
		}

		private void dELETARToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Deseja deletar a conta:" + dataGridView_PW.CurrentRow.Cells[1].Value.ToString(), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{

				this.contas_pwTableAdapter.DeleteQueryCONTA(Convert.ToInt32( dataGridView_PW.CurrentRow.Cells[0].Value.ToString()));

				MessageBox.Show("Conta deletada..", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			}
			else
			{;
			}
			this.contas_pwTableAdapter.Fill_INNER(this.pwDBDataSet.contas_pw);
		}

		public void LoadLocalizationText()
		{

			LocalizationText = new SortedList();
			string path = "\\language_en.txt";
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
			this.oiToolStripMenuItem.Text = Class_ling.GetLocalization(12);
			this.dELETARToolStripMenuItem.Text = Class_ling.GetLocalization(12); 
			this.textBox_Senha.Text = Class_ling.GetLocalization(31);
			this.textBox_Login.Text = Class_ling.GetLocalization(30);
			this.textBox_Char.Text = Class_ling.GetLocalization(34);
			this.senhaDataGridViewTextBoxColumn.HeaderText = Class_ling.GetLocalization(31);
			this.nomePW.HeaderText = Class_ling.GetLocalization(1);
			this.classeDataGridViewTextBoxColumn.HeaderText = Class_ling.GetLocalization(32);
			this.nomeCharDataGridViewTextBoxColumn.HeaderText = Class_ling.GetLocalization(33);
			this.groupBox2.Text = Class_ling.GetLocalization(1);
			this.loginDataGridViewTextBoxColumn.HeaderText = Class_ling.GetLocalization(30);
		}
	}
}
