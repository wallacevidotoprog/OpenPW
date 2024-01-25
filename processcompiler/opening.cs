using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace processcompiler
{
    public class opening
    {
		public void openPW(string filedialogEXE,string user, string pwd, string role,string filedialog)
		{



			using (Process compiler = new Process())
			{
				compiler.StartInfo.FileName = filedialogEXE;
				compiler.StartInfo.Arguments = "startbypatcher console:1 user:" + user + " pwd:"+ pwd + " role:"+ role+"";
				compiler.StartInfo.UseShellExecute = false;
				compiler.StartInfo.RedirectStandardOutput = true;
				compiler.StartInfo.CreateNoWindow = true;
				compiler.StartInfo.WorkingDirectory = filedialog;
				compiler.Start();
			}
		}
		public void openPT(string filename)
		{
			var rstrui = new System.Diagnostics.ProcessStartInfo();
			rstrui.FileName = filename;
			rstrui.UseShellExecute = true;
			rstrui.Verb = "runas"; //O segredo é esta linha!
			rstrui.WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
			System.Diagnostics.Process.Start(rstrui);

		}











	}
}
