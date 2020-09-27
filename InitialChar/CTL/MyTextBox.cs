using System.Drawing;
using System.Windows.Forms;

namespace InitialChars
{
	public partial class MyTextBox : TextBox
	{
		private bool bControlKey = false;

		public MyTextBox() : base()
		{
			MouseWheel += textBox1_MouseWheel;
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);

			if (e.KeyCode == Keys.ControlKey)
			{
				bControlKey = true;
			}
		}

		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			base.OnKeyPress(e);
		}

		protected override void OnKeyUp(KeyEventArgs e)
		{
			base.OnKeyUp(e);

			if (e.KeyCode == Keys.ControlKey)
			{
				bControlKey = false;
			}
		}



		private void textBox1_MouseWheel(object sender, MouseEventArgs e)
		{
			if (bControlKey == false)
			{
				return;
			}

			if (e.Delta > 0)
			{
				using (Font newFont = new Font(Font.FontFamily, Font.Size + 1))
				{
					Font = newFont;
				}
			}
			else if (e.Delta < 0)
			{
				using (Font newFont = new Font(Font.FontFamily, Font.Size - 1))
				{
					Font = newFont;
				}
			}
		}
	}
}
