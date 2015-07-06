/*
 * Created by SharpDevelop.
 * Date: 04.07.2015
 * Time: 22:31
 */
namespace photino
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.imageViewer = new photino.ImageViewer();
			((System.ComponentModel.ISupportInitialize)(this.imageViewer)).BeginInit();
			this.SuspendLayout();
			// 
			// imageViewer
			// 
			this.imageViewer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.imageViewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.imageViewer.Location = new System.Drawing.Point(0, 0);
			this.imageViewer.Name = "imageViewer";
			this.imageViewer.Size = new System.Drawing.Size(284, 262);
			this.imageViewer.TabIndex = 0;
			this.imageViewer.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.ControlBox = false;
			this.Controls.Add(this.imageViewer);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			((System.ComponentModel.ISupportInitialize)(this.imageViewer)).EndInit();
			this.ResumeLayout(false);
		}
		private photino.ImageViewer imageViewer;
	}
}
