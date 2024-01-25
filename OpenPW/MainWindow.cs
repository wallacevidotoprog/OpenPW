using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using processcompiler;
using INIFile;
using System.Net;

namespace OpenPW
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		INIFile.INI ini;

		public static SortedList LocalizationText;
		public static int lLang = 0;

		int TEMPO = 0;
		string user; string pwd; string role; string filedialogEXE; string filedialog; string ID_PW;string VSC; string VSS; string URL_PG; bool ATT; string filedialogPT;

		 [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

		private void Form1_Load(object sender, EventArgs e)

		{
			LoadLocalizationText();
			SetLocalization();

		//	webBrowser2.Navigate("https://drive.google.com/drive/u/0/folders/1INqaVDnoyxr6RzWbryRs2YRpLtjgdNmd");



			this.caminho_pwTableAdapter.Fill(this.pwDBDataSet.caminho_pw);
			IMGS();
			dataGridView_Conta.ClearSelection(); dataGridView_PW.ClearSelection();
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		void IMGS()
		{
			ini = new INIFile.INI(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img.ini"));

			Bitmap BMP_BtClose = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, ini.ReadValue("main", "BMP_BtClose")));
			Bitmap BMP_BacF = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, ini.ReadValue("main", "BMP_BacF")));
			Bitmap BMP_BtPlay = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, ini.ReadValue("main", "BMP_BtPlay")));
			Bitmap BMP_PbCLass = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, ini.ReadValue("main", "BMP_PbCLass")));
			Bitmap BMP_Config = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, ini.ReadValue("main", "BMP_Config")));
			Bitmap BMP_Pw = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, ini.ReadValue("main", "BMP_Pw")));
			Bitmap BMP_Conta = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, ini.ReadValue("main", "BMP_Conta")));


			#region BK
			//Bitmap BMP_BtClose = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img\close.png"));
			//Bitmap BMP_BacF = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img\background.png"));
			//Bitmap BMP_BtPlay = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img\play.png"));
			//Bitmap BMP_PbCLass = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img\neutro.png"));
			//Bitmap BMP_Config = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img\config.png"));
			//Bitmap BMP_Pw = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img\pwfile.png"));
			//Bitmap BMP_Conta = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img\acc.png"));

			#endregion




			this.BackgroundImage = BMP_BacF;
			button_Fechar.BackgroundImage = BMP_BtClose;
			pictureBox_play.BackgroundImage = BMP_BtPlay;
			pictureBox_Classes.BackgroundImage = BMP_PbCLass;
			this.TransparencyKey = this.BackColor;
			pictureBox_config.BackgroundImage = BMP_Config; pictureBox_conta.BackgroundImage = BMP_Conta; pictureBox_pw.BackgroundImage = BMP_Pw;
		}

		private void button_Fechar_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void pictureBox_play_Click(object sender, EventArgs e)
		{
			
				if (filedialogEXE != null)
				{
					if (ATT == false)
					{
					processcompiler.opening PCO = new opening();
					PCO.openPW(filedialogEXE, user, pwd, role, filedialog);
					}
					else
					{
					//string X1 = Class_ling.GetLocalization(7);
					string X = String.Format(Class_ling.GetLocalization(7), VSC, VSS);

						var RR	= MessageBox.Show(X, Class_ling.GetLocalization(8) , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

						if (RR == DialogResult.Yes)
						{
						processcompiler.opening PCO = new opening();
						PCO.openPT(filedialogPT);
					}
						if (RR == DialogResult.No)
						{
						
						processcompiler.opening PCO = new opening();
						PCO.openPW(filedialogEXE, user, pwd, role, filedialog);
					}
					}
					
				}
				else
				{
					MessageBox.Show(Class_ling.GetLocalization(9), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			
			

		}


		private void adicionarPerfectWorldToolStripMenuItem1_Click_1(object sender, EventArgs e)
		{

		}

		private void adicionarContaToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView_PW_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView_Conta_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			user = dataGridView_Conta.CurrentRow.Cells[1].Value.ToString();
			pwd = dataGridView_Conta.CurrentRow.Cells[2].Value.ToString();
			role = dataGridView_Conta.CurrentRow.Cells[5].Value.ToString();
			VERSION(filedialog, filedialog);
			Bitmap BMP_PbCLass = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img\pers\" + Convert.ToString(dataGridView_Conta.CurrentRow.Cells[4].Value.ToString()) + ".png"));
			pictureBox_Classes.BackgroundImage = BMP_PbCLass;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (ID_PW != null)
			{
				this.contas_pwTableAdapter.Fill(this.pwDBDataSet.contas_pw);
				this.caminho_pwTableAdapter.Fill(this.pwDBDataSet.caminho_pw);
			}

		}

		private void dataGridView_PW_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			filedialog = dataGridView_PW.CurrentRow.Cells[2].Value.ToString();
			VERSION(filedialog, filedialog);
		//	timer_VERSAO.Start();

			ID_PW = dataGridView_PW.CurrentRow.Cells[0].Value.ToString();

			filedialogEXE = dataGridView_PW.CurrentRow.Cells[3].Value.ToString();
			filedialogPT = dataGridView_PW.CurrentRow.Cells[4].Value.ToString();

			if (ID_PW != null)
			{
				this.contas_pwTableAdapter.BuscaPw(this.pwDBDataSet.contas_pw, int.Parse(ID_PW));

			}
			
			dataGridView_Conta.ClearSelection();
		}

		private void dataGridView_PW_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void pictureBox_config_Click(object sender, EventArgs e)
		{
			pictureBox_conta.Visible = true; pictureBox_pw.Visible = true;
		}

		private void pictureBox_pw_Click(object sender, EventArgs e)
		{
			SavePW form_Pw = new SavePW();
			form_Pw.ShowDialog();
			pictureBox_conta.Visible = false; pictureBox_pw.Visible = false;
			Form1_Load( sender,  e);
		}

		private void pictureBox_conta_Click(object sender, EventArgs e)
		{
			SaveAcc form_Pw = new SaveAcc();
			form_Pw.ShowDialog();
			pictureBox_conta.Visible = false; pictureBox_pw.Visible = false;
			Form1_Load(sender, e);
		}

		void VERSION(string FILE,string SERV)
		{
			VSC = null; VSS = null; 


					   			 
			try
			{

				TextBox tex2 = new TextBox();

				tex2.Text = FILE.Replace(@"\element", @"\config\element\version.sw");
				FILE = tex2.Text;

				TextReader fileReader = new StreamReader(FILE);
				for (int i = 0; i < 1; i++)
					VSC = fileReader.ReadLine();
				fileReader.Close();

				VSC.Replace(" 0", "");


				TextBox tex = new TextBox();

				tex.Text = VSC.Replace(" 0", "");

				VSC = tex.Text;
			}
			catch (Exception)
			{



			}

			try
			{
				TextBox tex3 = new TextBox();
				tex3.Text = SERV.Replace(@"\element", @"\patcher\server\updateserver.txt");
				SERV = tex3.Text;

				DataTable DTTXT = new DataTable();

				DTTXT.Columns.Add("COD", typeof(string));
				DTTXT.Columns.Add("COD1", typeof(string));
				DTTXT.Columns.Add("COD2", typeof(string));
				DTTXT.Columns.Add("SERVER", typeof(string));
				DTTXT.Columns.Add("COD4", typeof(string));
				DTTXT.Columns.Add("COD5", typeof(string));

				DTTXT.Clear();

				string[] lines = File.ReadAllLines(SERV);
				string[] values;


				for (int i = 0; i < lines.Length; i++)
				{
					values = lines[i].ToString().Split('"');
					string[] row = new string[values.Length];

					for (int j = 0; j < values.Length; j++)
					{
						row[j] = values[j].Trim();
					}
					DTTXT.Rows.Add(row);
				}
				string TT = DTTXT.Rows[0]["SERVER"].ToString();

				URL_PG = TT + "element/version";
			}
			catch (Exception)
			{

				
			}
			

			try
			{
				var URL = new WebClient();

				string pagina = URL.DownloadString(URL_PG.ToString());

				var htmlDocument = new HtmlAgilityPack.HtmlDocument();

				htmlDocument.LoadHtml(pagina);


				VSS = pagina;

				
			}
			catch (Exception)
			{

				
			}

			


			if (Convert.ToInt32(VSC) != Convert.ToInt32(VSS))
			{
				ATT = true;
			}
			else
			{
				ATT = false;
			}

			string X;

			if (VSC != null && VSS != null)
			{
				X = String.Format(Class_ling.GetLocalization(10), VSC, VSS);
			}
			else
			{
				X = Class_ling.GetLocalization(11);
			}

			label_VS.Text = X;

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

		public void SetLocalization()
		{
			groupBox2.Text = Class_ling.GetLocalization(1);
			groupBox1.Text = Class_ling.GetLocalization(2);
			groupBox4.Text = Class_ling.GetLocalization(3);
			toolTip_CONFIG.SetToolTip(pictureBox_config, Class_ling.GetLocalization(4));
			toolTip_PW.SetToolTip(pictureBox_pw, Class_ling.GetLocalization(5));
			toolTip_CONTA.SetToolTip(pictureBox_conta, Class_ling.GetLocalization(6));


		}



	}
}
