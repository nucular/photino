using System;
using System.Windows.Forms;

namespace Photino
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.SetCompatibleTextRenderingDefault(false);
			Application.EnableVisualStyles();
			
			MainForm mf;
			
			if (args.Length > 0) {
				mf = new MainForm(args[0]);
			} else {
				mf = new MainForm();
			}
			
			Application.Run(mf);
		}
	}
}
