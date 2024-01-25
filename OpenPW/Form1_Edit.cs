using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INIFile;
using HtmlAgilityPack;

namespace OpenPW
{
	public partial class Form1_Edit : Form
	{
		public Form1_Edit()
		{
			InitializeComponent();
		}

		INIFile.INI ini;

		private void AbrirFormEnPanel(object formhija)
		{
			if (this.panel_central.Controls.Count > 0)
				this.panel_central.Controls.RemoveAt(0);
			Form fh = formhija as Form;
			fh.TopLevel = false;
			//fh.Dock = DockStyle.Fill;
			this.panel_central.Controls.Add(fh);
			this.panel_central.Tag = fh;
			fh.Show();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			ini = new INIFile.INI(Path.Combine(System.Windows.Forms.Application.StartupPath, @"sizes.ini"));

			int A = 0; A= Convert.ToInt32(ini.ReadValue("file", "formH"));
			int B = 0;B= Convert.ToInt32(ini.ReadValue("file", "formW"));


			numericUpDown_formH.Value = A;
			numericUpDown_formW.Value = B;
					   
			AbrirFormEnPanel(new SavePW());

		}

		

		private void salvar(object sender, EventArgs e)
		{
			ini.Write("file", "formH", Convert.ToString(numericUpDown_formH.Value));
			ini.Write("file", "formW", Convert.ToString(numericUpDown_formW.Value));



			AbrirFormEnPanel(new SavePW());
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var URL = new WebClient();

			string pagina = URL.DownloadString("http://cpw.pwconquest.com.br/CPW/element/version");

			var htmlDocument = new HtmlAgilityPack.HtmlDocument();

			htmlDocument.LoadHtml(pagina);

			int VSversion = 0;

			//var X = htmlDocument.GetElementbyId("pre").ChildNodes;

			MessageBox.Show(pagina.ToString());


		}
	}
}
