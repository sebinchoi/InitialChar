using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InitialChar
{
	public partial class frmInput : MyForm
	{
		public frmInput()
		{
			InitializeComponent();
		}

		private void btnApply_Click(object sender, EventArgs e)
		{
			Form frm;
			string sInputText = txtInput.Text;
			string sSplitText = txtInput.SelectedText;

			if (rdoInit_Medial.Checked)
			{
				int iValue = decimal.ToInt32(numWeight.Value);
				frm = new frmOutput(sInputText, iValue);
			}
			else
			{
				frm = new frmOutput(sInputText);
			}

			frm.Show();

		}

		private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\n')
			{
				btnApply_Click(null, null);
			}
		}


		private void rdoVer1_CheckedChanged(object sender, EventArgs e)
		{
			lblWeight.Visible = false;
			numWeight.Visible = false;
		}
		private void rdoVer2_CheckedChanged(object sender, EventArgs e)
		{
			lblWeight.Visible = true;
			numWeight.Visible = true;
		}
	}
}
