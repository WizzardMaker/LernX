namespace LernX
{
	partial class QuizRun
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
			this.lTheme = new System.Windows.Forms.Label();
			this.lAllChapter = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pQuestionHolder = new System.Windows.Forms.Panel();
			this.lQuestion = new System.Windows.Forms.Label();
			this.bCancel = new System.Windows.Forms.Button();
			this.lThemeName = new System.Windows.Forms.Label();
			this.lChapterName = new System.Windows.Forms.Label();
			this.bBack = new System.Windows.Forms.Button();
			this.bNext = new System.Windows.Forms.Button();
			this.lAQuestion = new System.Windows.Forms.Label();
			this.lBChapters = new System.Windows.Forms.ListBox();
			this.lChapter = new System.Windows.Forms.Label();
			this.bSolve = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lTheme
			// 
			this.lTheme.AutoSize = true;
			this.lTheme.Location = new System.Drawing.Point(12, 17);
			this.lTheme.Name = "lTheme";
			this.lTheme.Size = new System.Drawing.Size(84, 13);
			this.lTheme.TabIndex = 0;
			this.lTheme.Text = "Themenbereich:";
			// 
			// lAllChapter
			// 
			this.lAllChapter.AutoSize = true;
			this.lAllChapter.Location = new System.Drawing.Point(214, 17);
			this.lAllChapter.Name = "lAllChapter";
			this.lAllChapter.Size = new System.Drawing.Size(77, 13);
			this.lAllChapter.TabIndex = 2;
			this.lAllChapter.Text = "Unterbereiche:";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.pQuestionHolder);
			this.panel1.Controls.Add(this.lQuestion);
			this.panel1.Location = new System.Drawing.Point(-1, 64);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(604, 156);
			this.panel1.TabIndex = 4;
			// 
			// pQuestionHolder
			// 
			this.pQuestionHolder.Location = new System.Drawing.Point(-1, 32);
			this.pQuestionHolder.Name = "pQuestionHolder";
			this.pQuestionHolder.Size = new System.Drawing.Size(603, 119);
			this.pQuestionHolder.TabIndex = 9;
			// 
			// lQuestion
			// 
			this.lQuestion.AutoSize = true;
			this.lQuestion.Location = new System.Drawing.Point(3, 8);
			this.lQuestion.Name = "lQuestion";
			this.lQuestion.Size = new System.Drawing.Size(49, 13);
			this.lQuestion.TabIndex = 3;
			this.lQuestion.Text = "!FRAGE!";
			// 
			// bCancel
			// 
			this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bCancel.Location = new System.Drawing.Point(609, 181);
			this.bCancel.Name = "bCancel";
			this.bCancel.Size = new System.Drawing.Size(91, 23);
			this.bCancel.TabIndex = 8;
			this.bCancel.Text = "Abbrechen";
			this.bCancel.UseVisualStyleBackColor = true;
			this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
			// 
			// lThemeName
			// 
			this.lThemeName.AutoSize = true;
			this.lThemeName.Location = new System.Drawing.Point(102, 17);
			this.lThemeName.Name = "lThemeName";
			this.lThemeName.Size = new System.Drawing.Size(106, 13);
			this.lThemeName.TabIndex = 10;
			this.lThemeName.Text = "!THEMENBEREICH!";
			// 
			// lChapterName
			// 
			this.lChapterName.AutoSize = true;
			this.lChapterName.Location = new System.Drawing.Point(102, 42);
			this.lChapterName.Name = "lChapterName";
			this.lChapterName.Size = new System.Drawing.Size(98, 13);
			this.lChapterName.TabIndex = 11;
			this.lChapterName.Text = "!UNTERBEREICH!";
			// 
			// bBack
			// 
			this.bBack.Location = new System.Drawing.Point(417, 22);
			this.bBack.Name = "bBack";
			this.bBack.Size = new System.Drawing.Size(32, 23);
			this.bBack.TabIndex = 12;
			this.bBack.Text = "<-";
			this.bBack.UseVisualStyleBackColor = true;
			this.bBack.Click += new System.EventHandler(this.bBack_Click);
			// 
			// bNext
			// 
			this.bNext.Location = new System.Drawing.Point(532, 22);
			this.bNext.Name = "bNext";
			this.bNext.Size = new System.Drawing.Size(32, 23);
			this.bNext.TabIndex = 13;
			this.bNext.Text = "->";
			this.bNext.UseVisualStyleBackColor = true;
			this.bNext.Click += new System.EventHandler(this.bNext_Click);
			// 
			// lAQuestion
			// 
			this.lAQuestion.Location = new System.Drawing.Point(455, 27);
			this.lAQuestion.Name = "lAQuestion";
			this.lAQuestion.Size = new System.Drawing.Size(71, 13);
			this.lAQuestion.TabIndex = 14;
			this.lAQuestion.Text = "FRAGE-NR/OF";
			this.lAQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lBChapters
			// 
			this.lBChapters.FormattingEnabled = true;
			this.lBChapters.Location = new System.Drawing.Point(291, 12);
			this.lBChapters.Name = "lBChapters";
			this.lBChapters.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.lBChapters.Size = new System.Drawing.Size(120, 43);
			this.lBChapters.TabIndex = 15;
			// 
			// lChapter
			// 
			this.lChapter.AutoSize = true;
			this.lChapter.Location = new System.Drawing.Point(12, 42);
			this.lChapter.Name = "lChapter";
			this.lChapter.Size = new System.Drawing.Size(77, 13);
			this.lChapter.TabIndex = 16;
			this.lChapter.Text = "Unterbereiche:";
			// 
			// bSolve
			// 
			this.bSolve.Location = new System.Drawing.Point(609, 152);
			this.bSolve.Name = "bSolve";
			this.bSolve.Size = new System.Drawing.Size(91, 23);
			this.bSolve.TabIndex = 17;
			this.bSolve.Text = "Lösen";
			this.bSolve.UseVisualStyleBackColor = true;
			this.bSolve.Click += new System.EventHandler(this.bSolve_Click);
			// 
			// QuizRun
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.bCancel;
			this.ClientSize = new System.Drawing.Size(708, 216);
			this.Controls.Add(this.bSolve);
			this.Controls.Add(this.lChapterName);
			this.Controls.Add(this.lChapter);
			this.Controls.Add(this.lBChapters);
			this.Controls.Add(this.lAQuestion);
			this.Controls.Add(this.bNext);
			this.Controls.Add(this.bBack);
			this.Controls.Add(this.lThemeName);
			this.Controls.Add(this.bCancel);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lAllChapter);
			this.Controls.Add(this.lTheme);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "QuizRun";
			this.Text = "LernX";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lTheme;
		private System.Windows.Forms.Label lAllChapter;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lQuestion;
		private System.Windows.Forms.Button bCancel;
		private System.Windows.Forms.Panel pQuestionHolder;
		private System.Windows.Forms.Label lThemeName;
		private System.Windows.Forms.Label lChapterName;
		private System.Windows.Forms.Button bBack;
		private System.Windows.Forms.Button bNext;
		private System.Windows.Forms.Label lAQuestion;
		private System.Windows.Forms.ListBox lBChapters;
		private System.Windows.Forms.Label lChapter;
        private System.Windows.Forms.Button bSolve;
    }
}