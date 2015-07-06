﻿/*
 * Created by SharpDevelop.
 * Date: 04.07.2015
 * Time: 22:31
 */
namespace Photino
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
			this.imageViewer = new Photino.ImageViewer();
			this.mainMenu = new Photino.MainMenu();
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
			this.imageViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imageViewer.TabIndex = 0;
			this.imageViewer.TabStop = false;
			// 
			// mainMenu
			// 
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(137, 48);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.ContextMenuStrip = this.mainMenu;
			this.ControlBox = false;
			this.Controls.Add(this.imageViewer);
			this.Enabled = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.imageViewer)).EndInit();
			this.ResumeLayout(false);
		}
		private Photino.MainMenu mainMenu;
		private Photino.ImageViewer imageViewer;
	}
}
