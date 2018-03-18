using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LernX {
	public partial class AddDialog : Form {
		Action<string, bool> onfinishCallback;
		Func<string, bool> isStringCorect;

		public AddDialog(string name, Action<string, bool> finishCallback, Func<string,bool> stringCorrecter) {
			InitializeComponent();

			this.Text = $"{name} hinzufügen";

			onfinishCallback += finishCallback;
			isStringCorect = stringCorrecter;

			FormClosed += AddDialog_FormClosed;
		}

		private void AddDialog_FormClosed(object sender, FormClosedEventArgs e) {
			onfinishCallback("", false);
		}

		private void bAdd_Click(object sender, EventArgs e) {
			FormClosed -= AddDialog_FormClosed;
			onfinishCallback(tbName.Text.Trim(' '), true);
			Close();
		}

		private void bCancel_Click(object sender, EventArgs e) {
			Close();
		}

		private void tbName_TextChanged(object sender, EventArgs e) {
			if (isStringCorect(tbName.Text) && !(tbName.Text).Trim(' ').Equals("")) {
				lError.Visible = false;
				bAdd.Enabled = true;
			} else {
				lError.Visible = true;
				bAdd.Enabled = false;
			}
		}
	}
}
