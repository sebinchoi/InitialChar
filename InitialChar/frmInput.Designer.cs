using InitialChars;

namespace InitialChar
{
	partial class frmInput
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.txtInput = new InitialChars.MyTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.numWeight = new System.Windows.Forms.NumericUpDown();
			this.lblWeight = new System.Windows.Forms.Label();
			this.rdoInit_Medial = new System.Windows.Forms.RadioButton();
			this.rdoInit = new System.Windows.Forms.RadioButton();
			this.btnApply = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.txtInput, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 361);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// txtInput
			// 
			this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtInput.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtInput.Location = new System.Drawing.Point(3, 38);
			this.txtInput.Multiline = true;
			this.txtInput.Name = "txtInput";
			this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtInput.Size = new System.Drawing.Size(578, 320);
			this.txtInput.TabIndex = 0;
			this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.numWeight);
			this.panel1.Controls.Add(this.lblWeight);
			this.panel1.Controls.Add(this.rdoInit_Medial);
			this.panel1.Controls.Add(this.rdoInit);
			this.panel1.Controls.Add(this.btnApply);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(584, 35);
			this.panel1.TabIndex = 2;
			// 
			// numWeight
			// 
			this.numWeight.Location = new System.Drawing.Point(295, 9);
			this.numWeight.Name = "numWeight";
			this.numWeight.Size = new System.Drawing.Size(41, 21);
			this.numWeight.TabIndex = 4;
			this.numWeight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numWeight.Visible = false;
			// 
			// lblWeight
			// 
			this.lblWeight.AutoSize = true;
			this.lblWeight.Location = new System.Drawing.Point(194, 12);
			this.lblWeight.Name = "lblWeight";
			this.lblWeight.Size = new System.Drawing.Size(99, 12);
			this.lblWeight.TabIndex = 3;
			this.lblWeight.Text = "* 자음 비중(%) : ";
			this.lblWeight.Visible = false;
			// 
			// rdoInit_Medial
			// 
			this.rdoInit_Medial.AutoSize = true;
			this.rdoInit_Medial.Location = new System.Drawing.Point(76, 10);
			this.rdoInit_Medial.Name = "rdoInit_Medial";
			this.rdoInit_Medial.Size = new System.Drawing.Size(77, 16);
			this.rdoInit_Medial.TabIndex = 2;
			this.rdoInit_Medial.Text = "자음+모음";
			this.rdoInit_Medial.UseVisualStyleBackColor = true;
			this.rdoInit_Medial.CheckedChanged += new System.EventHandler(this.rdoVer2_CheckedChanged);
			// 
			// rdoInit
			// 
			this.rdoInit.AutoSize = true;
			this.rdoInit.Checked = true;
			this.rdoInit.Location = new System.Drawing.Point(12, 10);
			this.rdoInit.Name = "rdoInit";
			this.rdoInit.Size = new System.Drawing.Size(47, 16);
			this.rdoInit.TabIndex = 2;
			this.rdoInit.TabStop = true;
			this.rdoInit.Text = "자음";
			this.rdoInit.UseVisualStyleBackColor = true;
			this.rdoInit.CheckedChanged += new System.EventHandler(this.rdoVer1_CheckedChanged);
			// 
			// btnApply
			// 
			this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnApply.Location = new System.Drawing.Point(521, 7);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(60, 22);
			this.btnApply.TabIndex = 1;
			this.btnApply.Text = "적용";
			this.btnApply.UseVisualStyleBackColor = true;
			this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
			// 
			// frmInput
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "frmInput";
			this.Text = "초성 입력";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MyTextBox txtInput;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnApply;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.NumericUpDown numWeight;
		private System.Windows.Forms.Label lblWeight;
		private System.Windows.Forms.RadioButton rdoInit_Medial;
		private System.Windows.Forms.RadioButton rdoInit;
	}
}