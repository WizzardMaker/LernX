using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LernX
{
	public partial class QuizRun : Form
	{
		Dictionary<Question, string> questions;
		Question current;

		string theme;
		string[] chapters;
		int _questionIndex = 0;
		int questionIndex {
			get => _questionIndex;
			set {
				value = value.Clamp(0, questions.Count);
				_questionIndex = value;
				SetQuestion();
			}
		}
		bool learnMode;

		public QuizRun(string theme, bool learn, params string[] chapters) {
			InitializeComponent();
			this.theme = theme;
			//lChapterName.Text = chapter;
			lBChapters.Items.AddRange(chapters);
			lThemeName.Text = theme;

			questions = new Dictionary<Question, string>();

			foreach (string c in chapters)
				foreach (Question q in QuestionDatabase.GetQuestions(theme, c, 15, shuffle: true))
					questions.Add(q, c);

			if (learn) {
				this.Text += " - Lern Modus";
				foreach (string c in chapters)
					foreach (Question q in QuestionDatabase.GetQuestions(theme, c, shuffle: true))
						questions.Add(q, c);
			}

			SetQuestion();
			//data = new Question();
		}

		private void bNext_Click(object sender, EventArgs e) {
			questionIndex++;
		}

		private void bBack_Click(object sender, EventArgs e) {
			questionIndex--;
		}

		private void SetQuestion() {
			if (questions.Count <= questionIndex)
				return;

			current = questions.ElementAt(questionIndex).Key;
			lQuestion.Text = current.name;
			lChapterName.Text = questions.ElementAt(questionIndex).Value;

			SuspendLayout();
			pQuestionHolder.SuspendLayout();
			foreach (Control c in pQuestionHolder.Controls) {
				c.Dispose();
			}
			pQuestionHolder.Controls.Clear();

			pQuestionHolder.Controls.AddRange(current.PrepareControls());
			current.PrepareRender();

			pQuestionHolder.ResumeLayout();
			ResumeLayout();
		}

		private void bCancel_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void bSolve_Click(object sender, EventArgs e) {
			if (current.IsAnsweredCorrectly()) {

			}
		}
	}
}
