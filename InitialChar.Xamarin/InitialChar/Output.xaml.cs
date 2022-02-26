using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace InitialChar
{
    public partial class Output : ContentPage
    {
		private string sNewString = "";
		public string InputString { get; private set; }
		public int SelIndex
		{
			get { return txtOutput.CursorPosition; }
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

		public Output()
        {
            InitializeComponent();
		}

		public Output(string sInputString) : this()
        {
			txtOutput.Text = ComHangeul.GetInitialsString(sInputString);
			this.InputString = sInputString;
		}

		public Output(string sInputString, double dWeight) : this()
		{
			txtOutput.Text = ComHangeul.GetOneSyllableString(sInputString, dWeight);
			this.InputString = sInputString;
		}

		public Output(string sInputString, int iWeight) : this()
		{
			txtOutput.Text = ComHangeul.GetOneSyllableString(sInputString, iWeight);
			this.InputString = sInputString;
		}

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
			//fFontSize = txtOutput.FontSize;
		}

        void txtOutput_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
			
			string sOld = e.OldTextValue;
			string sNew = e.NewTextValue;
			if (string.IsNullOrEmpty(sOld) == true || string.IsNullOrEmpty(sNew) == true) return;
			if (sNewString == sOld) return;
			if (sOld?.Length >= sNew?.Length)
            {
				int iStart= GetDiffStart(sOld, sNew);
				int iLength = sOld.Length - sNew.Length + 1;
				if (iStart + iLength < sOld.Length - 1)
                {
					if (sOld[iStart + iLength] != sNew[iStart + 1]) return;
				}

				try
				{
					char[] cInitText = sOld.ToCharArray();
					int iMaxLength = (iStart + iLength < InputLength) ? iStart + iLength : InputLength;

					for (int i = iStart; i < iMaxLength; i++)
					{
						cInitText[i] = InputString[i];
					}
					sNewString = sNew;
					txtOutput.Text = new string(cInitText);
				}
				catch (Exception ex)
				{

				}
			}
			else
            {
				sNewString = e.NewTextValue;
				txtOutput.Text = e.OldTextValue;
            }
        }

		private int GetDiffStart(string sOld, string sNew)
        {
			int iStart = -1;

			for (int i = 0; i < sOld.Length; i++)
            {
				if(sOld[i] != sNew[i])
                {
					iStart = i;
					break;
                }
            }

			return iStart;
        }

        void txtOutput_KeyPressed(System.Object sender, InitialChar.KeyEventArgs e)
        {
			if (e.Key.Equals("\n"))
			{
				txtOutput.IsReadOnly = true;

				try
				{
					char[] cInitText = txtOutput.Text.ToCharArray();
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
		}
    }
}
