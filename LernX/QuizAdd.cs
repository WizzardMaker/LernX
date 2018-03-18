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
	public partial class QuizAdd : Form {
		string theme, chapter;

		public QuizAdd() {
			InitializeComponent();

			cbTheme.MouseWheel += (s, e) => ((HandledMouseEventArgs)e).Handled = true;
			cbTheme.DropDownStyle = ComboBoxStyle.DropDownList;
			cbChapter.MouseWheel += (s, e) => ((HandledMouseEventArgs)e).Handled = true;
			cbChapter.DropDownStyle = ComboBoxStyle.DropDownList;

			cbTheme.Items.Clear();
			cbChapter.Items.Clear();

			RefreshControlBoxes();

			//data = new Question();
		}

		void RefreshControlBoxes() {
			if (cbTheme.Items.Count - 1 != QuestionDatabase.GetThemes().Length) {
				cbTheme.Items.Clear();
				cbTheme.Items.AddRange(QuestionDatabase.GetThemes());
				cbTheme.Items.Add("Neu...");
				cbTheme.SelectedIndex = cbTheme.Items.Count == 1 ? -1 : 0;
				cbChapter.SelectedIndex = cbChapter.Items.Count <= 1 ? -1 : 0;
			}

			if (QuestionDatabase.ThemeExist(cbTheme.Text)) {
				if (cbChapter.Items.Count - 1 != QuestionDatabase.GetChapters(cbTheme.Text).Length || cbChapter.Items.Cast<string>().ToArray() != QuestionDatabase.GetChapters(cbTheme.Text)){
					cbChapter.Items.Clear();
					cbChapter.Items.AddRange(QuestionDatabase.GetChapters(cbTheme.Text));
					cbChapter.Items.Add("Neu...");
					cbChapter.SelectedIndex = cbChapter.Items.Count <= 1 ? -1 : 0;
				}
			}

			bDelChapter.Enabled = cbChapter.SelectedIndex != cbChapter.Items.Count - 1;
			bDelTheme.Enabled = cbTheme.SelectedIndex != cbTheme.Items.Count - 1;
			bAdd.Enabled = (cbTheme.SelectedIndex != cbTheme.Items.Count - 1 && cbTheme.SelectedIndex != -1) && (cbChapter.SelectedIndex != cbChapter.Items.Count - 1 && cbChapter.SelectedIndex != -1);
		}

		private void cbTheme_SelectionChangeCommitted(object sender, EventArgs e) {
			if (cbTheme.SelectedIndex == cbTheme.Items.Count - 1) {
				AddDialog a = new AddDialog(
					"Thema",
					(v, s) => { QuestionDatabase.AddTheme(v); OnAddFinish(s); },
					(s) => !QuestionDatabase.ThemeExist(s)
				);

				a.ShowDialog();
			} else {
				RefreshControlBoxes();
				
				bDelTheme.Enabled = cbTheme.SelectedIndex != cbTheme.Items.Count - 1;
			}
		}

		private void cbChapter_SelectionChangeCommitted(object sender, EventArgs e) {
			if (cbChapter.SelectedIndex == cbChapter.Items.Count - 1) {
				AddDialog a = new AddDialog(
					"Kapitel",
					(v, s) => { QuestionDatabase.AddChapter(cbTheme.Text, v); OnAddFinish(s); },
					(s) => !QuestionDatabase.ChapterExist(cbTheme.Text, s)
				);

				a.ShowDialog();
			} else {
				bDelChapter.Enabled = cbChapter.SelectedIndex != cbChapter.Items.Count - 1;
			}
		}

		private void bDelTheme_Click(object sender, EventArgs e) {
			MessageBox.Show("Alle Kapitel und die dazugehörigen Fragen werden gelöscht! Möchten sie fortfahren?", "Bestätigung", MessageBoxButtons.YesNo);
		}

		private void bDelChapter_Click(object sender, EventArgs e) {

		}

		private void bCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        public void ValidateOptions()
        {
            Assert(() => tbName.Text.Trim(' ', '\t').Length != 0, "Die Frage braucht einen Namen!");
        }

        public string CleanInput(string input)
        {
            return input.Trim(' ', '\t', '\n', '\0');
        }

		private TextQuestion FeedTextInput(){
            //throw new NotImplementedException();
            ValidateOptions();

            Assert(() => CleanInput(tbText.Text) != "", "Das Textfeld darf nicht leer sein!");

            return new TextQuestion(CleanInput(tbName.Text), CleanInput(tbText.Text));
		}

		private ABCDQuestion FeedABCDInput(){
            //string name = ;
            //throw new NotImplementedException();
            ValidateOptions();

			Assert(() => !(cbA.Checked && cbB.Checked && cbC.Checked && cbD.Checked), "Es dürfen nicht alle Antworten richtig sein!");
			Assert(() => (cbA.Checked || cbB.Checked || cbC.Checked || cbD.Checked), "Es muss mindestens eine Antwort richtig sein!");
			Assert(
				() => (
				textBoxA.Text.Trim(' ', '\t').Length != 0 &&
				textBoxB.Text.Trim(' ', '\t').Length != 0 &&
				textBoxC.Text.Trim(' ', '\t').Length != 0 &&
				textBoxD.Text.Trim(' ', '\t').Length != 0),
				"Es müssen alle 4 Antwortmöglichkeiten ausgefüllt werden!");

			return new ABCDQuestion(
                CleanInput(tbName.Text),
                CleanInput(textBoxA.Text),
                CleanInput(textBoxB.Text),
                CleanInput(textBoxC.Text),
                CleanInput(textBoxD.Text),
				cbA.Checked,
				cbB.Checked,
				cbC.Checked,
				cbD.Checked);
		}

		/// <summary>
		/// If action returns false it will throw a EvaluateException.
		/// DONT FORGET TO CATCH IT, YOU MORON!
		/// </summary>
		/// <param name="action"></param>
		/// <param name="error"></param>
		private void Assert(Func<bool> action, string error){
			if (!action())
				throw new EvaluateException(error);
		}

		private void Error(string error){
			MessageBox.Show(this, error, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		void ClearInput() {
			tbName.Text = "";
			textBoxA.Text = "";
			textBoxB.Text = "";
			textBoxC.Text = "";
			textBoxD.Text = "";
			cbA.Checked = false;
			cbB.Checked = false;
			cbC.Checked = false;
			cbD.Checked = false;
		}

		private void bAdd_Click(object sender, EventArgs e) {
			Question b = null;

			try {
				switch (tType.SelectedIndex) {
					case (0):
						b = FeedTextInput();
						break;
					case (1):
						b = FeedABCDInput();
						break;
					default:
						throw new NotImplementedException();
				}
			}catch(EvaluateException er){
				Error(er.Message);
				return;
			}

			QuestionDatabase.AddQuestion(cbTheme.Text, cbChapter.Text, b);

			ClearInput();
		}

		void OnAddFinish(bool success) {
			if (success) {
				RefreshControlBoxes();
			} else {
				bDelChapter.Enabled = cbChapter.SelectedIndex != cbChapter.Items.Count - 1;
				bDelTheme.Enabled = cbTheme.SelectedIndex != cbTheme.Items.Count - 1;
			}

		}
	}
}
