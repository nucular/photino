using System;
using System.Drawing;
using System.Windows.Forms;

namespace photino
{
	/// <summary>
	/// Description of ImageViewer.
	/// </summary>
	public class ImageViewer : PictureBox
	{
		public ImageViewer() : base()
		{
		}
		
		public void LoadFromPath(string path) {
			this.Image = new Bitmap(path);
		}
		
		protected override void WndProc(ref Message m)
		{
			const int WM_NCHITTEST = 0x0084;
			const int HTTRANSPARENT = -1;
			
			if (m.Msg == WM_NCHITTEST) {
				m.Result = (IntPtr)HTTRANSPARENT;
			}
			else {
				base.WndProc(ref m);
			}
		}
	}
}
