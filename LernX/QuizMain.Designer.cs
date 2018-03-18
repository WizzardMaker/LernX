namespace LernX {
	partial class QuizMain {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.bSettings = new System.Windows.Forms.Button();
			this.themeBox = new System.Windows.Forms.ComboBox();
			this.checkedChapterList = new System.Windows.Forms.CheckedListBox();
			this.themeLabel = new System.Windows.Forms.Label();
			this.chapterLabel = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.bStartQuiz = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bSettings
			// 
			this.bSettings.Location = new System.Drawing.Point(74, 12);
			this.bSettings.Name = "bSettings";
			this.bSettings.Size = new System.Drawing.Size(119, 23);
			this.bSettings.TabIndex = 0;
			this.bSettings.Text = "Einstellungen";
			this.bSettings.UseVisualStyleBackColor = true;
			this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
			// 
			// themeBox
			// 
			this.themeBox.FormattingEnabled = true;
			this.themeBox.Location = new System.Drawing.Point(12, 106);
			this.themeBox.Name = "themeBox";
			this.themeBox.Size = new System.Drawing.Size(234, 21);
			this.themeBox.TabIndex = 1;
			this.themeBox.SelectionChangeCommitted += new System.EventHandler(this.ThemeBox_SelectionChangeCommitted);
			// 
			// checkedChapterList
			// 
			this.checkedChapterList.CheckOnClick = true;
			this.checkedChapterList.Enabled = false;
			this.checkedChapterList.FormattingEnabled = true;
			this.checkedChapterList.HorizontalScrollbar = true;
			this.checkedChapterList.Location = new System.Drawing.Point(12, 147);
			this.checkedChapterList.Name = "checkedChapterList";
			this.checkedChapterList.Size = new System.Drawing.Size(234, 94);
			this.checkedChapterList.TabIndex = 2;
			this.checkedChapterList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedChapterList_ItemCheck);
			// 
			// themeLabel
			// 
			this.themeLabel.AutoSize = true;
			this.themeLabel.Location = new System.Drawing.Point(12, 87);
			this.themeLabel.Name = "themeLabel";
			this.themeLabel.Size = new System.Drawing.Size(84, 13);
			this.themeLabel.TabIndex = 3;
			this.themeLabel.Text = "Themenbereich:";
			// 
			// chapterLabel
			// 
			this.chapterLabel.AutoSize = true;
			this.chapterLabel.Location = new System.Drawing.Point(12, 130);
			this.chapterLabel.Name = "chapterLabel";
			this.chapterLabel.Size = new System.Drawing.Size(71, 13);
			this.chapterLabel.TabIndex = 4;
			this.chapterLabel.Text = "Unterbereich:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(74, 41);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(119, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Fragen Editor öffnen";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// bStartQuiz
			// 
			this.bStartQuiz.Enabled = false;
			this.bStartQuiz.Location = new System.Drawing.Point(12, 248);
			this.bStartQuiz.Name = "bStartQuiz";
			this.bStartQuiz.Size = new System.Drawing.Size(234, 23);
			this.bStartQuiz.TabIndex = 6;
			this.bStartQuiz.Text = "Quiz starten!";
			this.bStartQuiz.UseVisualStyleBackColor = true;
			this.bStartQuiz.Click += new System.EventHandler(this.bStartQuiz_Click);
			// 
			// QuizMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(258, 286);
			this.Controls.Add(this.bStartQuiz);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.chapterLabel);
			this.Controls.Add(this.themeLabel);
			this.Controls.Add(this.checkedChapterList);
			this.Controls.Add(this.themeBox);
			this.Controls.Add(this.bSettings);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "QuizMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LernX";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bSettings;
		private System.Windows.Forms.ComboBox themeBox;
		private System.Windows.Forms.CheckedListBox checkedChapterList;
		private System.Windows.Forms.Label themeLabel;
		private System.Windows.Forms.Label chapterLabel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button bStartQuiz;
	}
}