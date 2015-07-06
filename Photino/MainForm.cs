using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Photino
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm(string path="")
		{
			InitializeComponent();
			
			if (path != "") {
				this.imageViewer.LoadFromPath(path);
				this.ClientSize = this.imageViewer.CalcSize();
			} else {
				this.Shown += delegate(object sender, EventArgs args) {
					OpenFileDialog dlg = new OpenFileDialog();
				
					if (dlg.ShowDialog() != DialogResult.OK) {
						this.Close();
					} else {
						this.imageViewer.LoadFromPath(dlg.FileName);
						this.ClientSize = this.imageViewer.CalcSize();
						this.CenterToScreen();
					}
				};
			}
			
			this.LostFocus += onLostFocus;
		}
		
		public void onLostFocus(object sender, EventArgs args) {
			if (SettingsForm.ActiveForm == null) {
				this.Close();
			}
		}
		
		protected override void WndProc(ref Message m) {
			const int CAPTIONSIZE = 32;
			const int WM_NCHITTEST = 0x84;
			const int WM_SETCURSOR = 0x20;
			IntPtr HTCAPTION = (IntPtr)2;
			
			if (m.Msg == WM_NCHITTEST) {
				Point pos = new Point(
					m.LParam.ToInt32() & 0xffff,
					m.LParam.ToInt32() >> 16
				);
				pos = this.PointToClient(pos);
				
				if (this.ClientRectangle.Contains(pos)
				   && pos.Y < CAPTIONSIZE) {
					m.Result = HTCAPTION;
					return;
				}
			}
			else if (m.Msg == WM_SETCURSOR) {
				if ((m.LParam.ToInt32() & 0xffff) == (int)HTCAPTION) {
					Cursor.Current = Cursors.Hand;
					m.Result = (IntPtr)1;
					return;
				}
			}
			
			base.WndProc(ref m);
		}
	}
}
