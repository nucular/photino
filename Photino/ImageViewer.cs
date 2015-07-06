using System;
using System.Drawing;
using System.Windows.Forms;

namespace Photino
{
	/// <summary>
	/// Description of ImageViewer.
	/// </summary>
	public class ImageViewer : PictureBox
	{
		public ImageViewer() : base()
		{
			this.SizeMode = PictureBoxSizeMode.Zoom;
		}
		
		public void LoadFromPath(string path) {
			this.Image = new Bitmap(path);
		}
		
		public Size CalcSize() {
			int maxW = SystemInformation.VirtualScreen.Width
				- Properties.Settings.Default.Padding * 2;
			int maxH = SystemInformation.VirtualScreen.Height
				- Properties.Settings.Default.Padding * 2;
			
			if (this.Image.Width > maxW || this.Image.Height > maxH) {
				double ratio = Math.Min(
					(double)maxW / this.Image.Width,
					(double)maxH / this.Image.Height
				);
				return new Size(
					(int)Math.Floor(this.Image.Width * ratio),
					(int)Math.Floor(this.Image.Height * ratio)
				);
			}
			return this.Image.Size;
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
