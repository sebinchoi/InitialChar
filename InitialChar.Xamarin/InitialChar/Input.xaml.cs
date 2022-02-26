using System;
using System.Linq;
using System.Collections.Generic;

using Xamarin.Forms;

namespace InitialChar
{
    public partial class Input : ContentPage
    {
        public Input()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

			rdoInit.IsChecked = true;
        }

        private async void btnApply_Clicked(object sender, EventArgs e)
		{
			Page page;
			string sInputText = txtInput.Text;
			//string sSplitText = txtInput.SelectedText;

			if (rdoInit_Medial.IsChecked)
			{
				if(int.TryParse(txtWeight.Text, out int iValue) == true)
                {
					page = new Output(sInputText, iValue);
					await Navigation.PushAsync(page);
				}
			}
			else
			{
				page = new Output(sInputText);
				await Navigation.PushAsync(page);
			}

		}

		private void rdoInit_CheckedChanged(object sender, CheckedChangedEventArgs e)
		{
			lblWeight.IsVisible = false;
			grdWeight.IsVisible = false;
		}
		private void rdoInit_Medial_CheckedChanged(object sender, CheckedChangedEventArgs e)
		{
			lblWeight.IsVisible = true;
			grdWeight.IsVisible = true;
		}

		private void txtWeight_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
			Entry entry = sender as Entry;
			if (entry?.Text == null) return;

			string sDigit = new string(entry.Text.Where(char.IsDigit).ToArray());
			entry.Text = sDigit;
		}

		private void txtInput_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
			if (e.NewTextValue == "\n")
			{
				btnApply_Clicked(null, null);
			}
		}

		private void btnDecWeight_Clicked(System.Object sender, System.EventArgs e)
        {
			if (int.TryParse(txtWeight.Text, out int iValue) == true)
            {
				txtWeight.Text = (iValue - 1).ToString();
            }
		}

		private void btnIncWeight_Clicked(System.Object sender, System.EventArgs e)
        {
			if (int.TryParse(txtWeight.Text, out int iValue) == true)
            {
				txtWeight.Text = (iValue + 1).ToString();
			}

		}
    }
}
