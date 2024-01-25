namespace OpenPW
{
	partial class Form_BAR
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox_BAR = new System.Windows.Forms.PictureBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_BAR)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox_BAR
			// 
			this.pictureBox_BAR.Location = new System.Drawing.Point(12, 12);
			this.pictureBox_BAR.Name = "pictureBox_BAR";
			this.pictureBox_BAR.Size = new System.Drawing.Size(776, 50);
			this.pictureBox_BAR.TabIndex = 0;
			this.pictureBox_BAR.TabStop = false;
			// 
			// progressBar1
			// 
			this.progressBar1.BackColor = System.Drawing.Color.Black;
			this.progressBar1.ForeColor = System.Drawing.Color.Red;
			this.progressBar1.Location = new System.Drawing.Point(12, 94);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.progressBar1.Size = new System.Drawing.Size(785, 57);
			this.progressBar1.TabIndex = 1;
			// 
			// Form_BAR
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 180);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.pictureBox_BAR);
			this.Name = "Form_BAR";
			this.Text = "Form_BAR";
			this.Load += new System.EventHandler(this.Form_BAR_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_BAR)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox_BAR;
		private System.Windows.Forms.ProgressBar progressBar1;
	}
}