using System;
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

namespace OpenPW
{
	public partial class Form_BAR : Form
	{
		Timer TM = new Timer();

		double pdUnit;
		int pdWINDTH, pdHEIGTH, pdFULL;
		Bitmap bmp;
		Graphics G;


		public Form_BAR()
		{
			InitializeComponent();
		}

		

		private void Form_BAR_Load(object sender, EventArgs e)
		{
			pdWINDTH = pictureBox_BAR.Width;
			pdHEIGTH = pictureBox_BAR.Height;

			pdUnit = pdWINDTH / 100.0;

			pdFULL = 0;

			bmp = new Bitmap(pdWINDTH, pdHEIGTH);
			progressBar1.Maximum = 100;
			progressBar1.Minimum = 0;


			TM.Interval = 50;
			TM.Tick += new EventHandler(this.TM_Tick);
			TM.Start();

		}


		void TM_Tick(object sender,EventArgs e)
		{
			Bitmap BMP_BtClose = new Bitmap(Path.Combine(System.Windows.Forms.Application.StartupPath, @"img\close.png"));

			G = Graphics.FromImage(bmp);

			G.Clear(Color.Red);

			 G.FillRectangle(Brushes.Purple, new Rectangle(0, 0, (int)(pdFULL * pdUnit), pdHEIGTH));

			G.DrawString(pdFULL + "%", new Font("Arial", pdHEIGTH / 2), Brushes.Black, new PointF(pdWINDTH / 2 - pdHEIGTH, pdHEIGTH / 10));

			pictureBox_BAR.Image = bmp;
			progressBar1.Increment(1);
			pdFULL++;
			if (pdFULL>100)
			{
				G.Dispose();
				TM.Stop();
			}
		}

		//void TM_Tick(object sender, EventArgs e)
		//{
		//	G = Graphics.FromImage(bmp);

		//	G.Clear(Color.Red);

		//	G.FillRectangle(Brushes.Purple, new Rectangle(0, 0, (int)(pdFULL * pdUnit), pdHEIGTH));

		//	G.DrawString(pdFULL + "%", new Font("Arial", pdHEIGTH / 2), Brushes.Black, new PointF(pdWINDTH / 2 - pdHEIGTH, pdHEIGTH / 10));

		//	pictureBox_BAR.Image = bmp;

		//	pdFULL++;
		//	if (pdFULL > 100)
		//	{
		//		G.Dispose();
		//		TM.Stop();
		//	}
		//}










	}
}
