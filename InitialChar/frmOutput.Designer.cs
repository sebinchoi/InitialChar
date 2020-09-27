using InitialChars;

namespace InitialChar
{
	partial class frmOutput
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOutput));
			this.txtOutput = new InitialChars.MyTextBox();
			this.SuspendLayout();
			// 
			// txtOutput
			// 
			this.txtOutput.BackColor = System.Drawing.Color.White;
			this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtOutput.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtOutput.Location = new System.Drawing.Point(0, 0);
			this.txtOutput.Multiline = true;
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtOutput.Size = new System.Drawing.Size(884, 561);
			this.txtOutput.TabIndex = 0;
			this.txtOutput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOutput_KeyDown);
			this.txtOutput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOutput_KeyUp);
			// 
			// frmOutput
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 561);
			this.Controls.Add(this.txtOutput);
			this.Name = "frmOutput";
			this.ShowIcon = true;
			this.Text = "";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MyTextBox txtOutput;
	}
}