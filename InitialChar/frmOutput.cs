using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace InitialChar
{

public partial class frmOutput : MyForm
	{
		private static float fFontSize = 15;

		public string InputString { get; private set; }
		public int SelIndex
		{
			get { return txtOutput.SelectionStart; }
		}

		public int SelLength
		{
			get { return txtOutput.SelectionLength; }
		}

		public int Leftover
		{
			get { return InputLength - SelIndex; }
		}

		public int InputLength
		{
			get { return InputString.Length; }
		}

		public frmOutput()
		{
			InitializeComponent();

			txtOutput.Font = new Font(txtOutput.Font.FontFamily, fFontSize);
		}

		public frmOutput(string sInputString) : this()
		{
			txtOutput.Text = HangeulFunc.GetInitialsString(sInputString);
			this.InputString = sInputString;
		}

		public frmOutput(string sInputString, double dWeight) : this()
		{
			txtOutput.Text = HangeulFunc.GetOneSyllableString(sInputString, dWeight);
			this.InputString = sInputString;
		}

		public frmOutput(string sInputString, int iWeight) : this()
		{
			txtOutput.Text = HangeulFunc.GetOneSyllableString(sInputString, iWeight);
			this.InputString = sInputString;
		}

		private void txtOutput_KeyDown(object sender, KeyEventArgs e)
		{
			SetTextBoxProperty(e.KeyCode, (char)e.KeyValue);
		}

		private void txtOutput_KeyUp(object sender, KeyEventArgs e)
		{
			if (Leftover <= 0)
			{
				txtOutput.ReadOnly = false;
			}
		}

		private void SetTextBoxProperty(Keys key, char keyChar)
		{
			switch (Leftover)
			{
				case int n when (n > 0):

					txtOutput.ReadOnly = true;

					if (key == Keys.Enter)
					{
						try
						{
							char[] cInitText = txtOutput.Text.ToArray();
							int iMaxLength = (SelIndex + SelLength < InputLength) ? SelIndex + SelLength : InputLength;

							for (int i = SelIndex; i < iMaxLength; i++)
							{
								cInitText[i] = InputString[i];
							}

							txtOutput.Text = new string(cInitText);
						}
						catch (Exception ex)
						{

						}
					}
					else
					{
						//Pass
					}

					break;

				case int n when (n == 0):

					if (key == Keys.Enter || key == Keys.LineFeed)
					{
						//Pass
						//txtOutput.ReadOnly = false; //기본값
					}
					else if (txtOutput.Text.EndsWith(Environment.NewLine))
					{
						//Pass
						//txtOutput.ReadOnly = false; //기본값
					}
					else
					{
						txtOutput.ReadOnly = true;
					}

					break;

				case int n when (n < 0):

					//txtOutput.ReadOnly = false; //기본값
					break;

				default:
					//unexpected error
					break;
			}
		}

		private void frmOutput_FormClosing(object sender, FormClosingEventArgs e)
		{
			fFontSize = txtOutput.Font.Size;
		}
	}
}
