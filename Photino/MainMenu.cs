using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Photino
{
	/// <summary>
	/// Description of MainMenu.
	/// </summary>
	public partial class MainMenu : ContextMenuStrip
	{
		public MainMenu() : base()
		{
			this.Items.Add(
				"Settings...",
				new Bitmap(16, 16),
				delegate(object sender, EventArgs e) {
					SettingsForm frm = new SettingsForm();
					frm.ShowDialog(this);
				}
			);
			this.Items.Add(
				"Info/Source",
				new Bitmap(16, 16),
				delegate(object sender, EventArgs e) {
					Process.Start("explorer", "https://github.com/nucular/photino");
				}
			);
		}
	}
}
