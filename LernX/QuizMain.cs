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
	public partial class QuizMain : Form {
		public QuizMain() {
			InitializeComponent();

			themeBox.MouseWheel += (s, e) => ((HandledMouseEventArgs)e).Handled = true;
			themeBox.DropDownStyle = ComboBoxStyle.DropDownList;

			RefreshControlBoxes();
		}

		void RefreshControlBoxes()
		{
			if (themeBox.Items.Count - 1 != QuestionDatabase.GetThemes().Length)
			{
				themeBox.Items.Clear();
				themeBox.Items.AddRange(QuestionDatabase.GetThemes());
				themeBox.Items.Add("Neu...");
				themeBox.SelectedIndex = themeBox.Items.Count == 1 ? -1 : 0;
			}

			if (QuestionDatabase.ThemeExist(themeBox.Text))
			{
				if (checkedChapterList.Items.Count != QuestionDatabase.GetChapters(themeBox.Text).Length || checkedChapterList.Items.Cast<string>().ToArray() != QuestionDatabase.GetChapters(themeBox.Text))
				{
					checkedChapterList.Items.Clear();
					checkedChapterList.Items.AddRange(QuestionDatabase.GetChapters(themeBox.Text));
				}
			}

			checkedChapterList.Enabled = themeBox.Items.Count != 0 || themeBox.SelectedIndex != themeBox.Items.Count - 1;
			bStartQuiz.Enabled = checkedChapterList.CheckedItems.Count != 0;
		}

		private void ThemeBox_SelectionChangeCommitted(object sender, EventArgs e) {
			RefreshControlBoxes();
			if (themeBox.SelectedIndex == themeBox.Items.Count - 1) {
				AddDialog a = new AddDialog(
					"Thema",
					(v, s) => { QuestionDatabase.AddTheme(v); OnAddFinish(s); },
					(s) => !QuestionDatabase.ThemeExist(s)
				);

				a.ShowDialog();
			} else {
				RefreshControlBoxes();
			}
		}

		private void checkedChapterList_ItemCheck(object sender, ItemCheckEventArgs e) {
			bStartQuiz.Enabled = checkedChapterList.CheckedItems.Count == 0;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			QuizAdd q = new QuizAdd();
			q.FormClosed += (s, ev) => RefreshControlBoxes();
			q.ShowDialog(this);

		}

		void OnAddFinish(bool success) {
			if (success) {
				RefreshControlBoxes();
			}

		}

		private void bStartQuiz_Click(object sender, EventArgs e)
		{
			QuizRun q = new QuizRun(themeBox.Text, false, checkedChapterList.CheckedItems.Cast<string>().ToArray());
			q.FormClosed += (s, ev) => RefreshControlBoxes();
			q.ShowDialog(this);
		}

		private void bSettings_Click(object sender, EventArgs e) {
			Settings s = new Settings();//new QuizRun(themeBox.Text, false, checkedChapterList.CheckedItems.Cast<string>().ToArray());
			s.FormClosed += (se, ev) => RefreshControlBoxes();
			s.ShowDialog(this);
		}
	}
}
