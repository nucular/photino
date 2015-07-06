using System;
using System.Drawing;
using System.Windows.Forms;

namespace Photino
{
	/// <summary>
	/// Description of SettingsForm.
	/// </summary>
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			InitializeComponent();
			this.propertyGrid.SelectedObject = Properties.Settings.Default;
			
			this.Closing += onClosing;
		}
		
		public void onClosing(object sender, EventArgs e) {
			Properties.Settings.Default.Save();
			MainForm.ActiveForm.Focus();
		}
	}
}
