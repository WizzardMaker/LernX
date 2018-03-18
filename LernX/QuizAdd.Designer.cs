namespace LernX {
	partial class QuizAdd {
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
            this.lTheme = new System.Windows.Forms.Label();
            this.cbTheme = new System.Windows.Forms.ComboBox();
            this.cbChapter = new System.Windows.Forms.ComboBox();
            this.lChapter = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.bDelTheme = new System.Windows.Forms.Button();
            this.bDelChapter = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lA = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.lB = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.lC = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.lD = new System.Windows.Forms.Label();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.cbA = new System.Windows.Forms.CheckBox();
            this.cbB = new System.Windows.Forms.CheckBox();
            this.cbC = new System.Windows.Forms.CheckBox();
            this.cbD = new System.Windows.Forms.CheckBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lText = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.tType = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTheme
            // 
            this.lTheme.AutoSize = true;
            this.lTheme.Location = new System.Drawing.Point(12, 17);
            this.lTheme.Name = "lTheme";
            this.lTheme.Size = new System.Drawing.Size(81, 13);
            this.lTheme.TabIndex = 0;
            this.lTheme.Text = "Themenbereich";
            // 
            // cbTheme
            // 
            this.cbTheme.FormattingEnabled = true;
            this.cbTheme.Items.AddRange(new object[] {
            "Italien",
            "Neu..."});
            this.cbTheme.Location = new System.Drawing.Point(99, 14);
            this.cbTheme.Name = "cbTheme";
            this.cbTheme.Size = new System.Drawing.Size(121, 21);
            this.cbTheme.TabIndex = 1;
            this.cbTheme.SelectionChangeCommitted += new System.EventHandler(this.cbTheme_SelectionChangeCommitted);
            // 
            // cbChapter
            // 
            this.cbChapter.FormattingEnabled = true;
            this.cbChapter.Items.AddRange(new object[] {
            "Neu..."});
            this.cbChapter.Location = new System.Drawing.Point(327, 14);
            this.cbChapter.Name = "cbChapter";
            this.cbChapter.Size = new System.Drawing.Size(121, 21);
            this.cbChapter.TabIndex = 3;
            this.cbChapter.SelectionChangeCommitted += new System.EventHandler(this.cbChapter_SelectionChangeCommitted);
            // 
            // lChapter
            // 
            this.lChapter.AutoSize = true;
            this.lChapter.Location = new System.Drawing.Point(253, 17);
            this.lChapter.Name = "lChapter";
            this.lChapter.Size = new System.Drawing.Size(68, 13);
            this.lChapter.TabIndex = 2;
            this.lChapter.Text = "Unterbereich";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lInfo);
            this.panel1.Controls.Add(this.tType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 220);
            this.panel1.TabIndex = 4;
            // 
            // lInfo
            // 
            this.lInfo.AutoSize = true;
            this.lInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lInfo.Location = new System.Drawing.Point(466, 70);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(127, 13);
            this.lInfo.TabIndex = 8;
            this.lInfo.Text = "Nur eine Auswahl möglich";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Antwortmöglichkeit:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(62, 15);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(523, 20);
            this.tbName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aufgabe:";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(604, 202);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(91, 23);
            this.bAdd.TabIndex = 5;
            this.bAdd.Text = "Hinzufügen";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bDelTheme
            // 
            this.bDelTheme.Location = new System.Drawing.Point(226, 12);
            this.bDelTheme.Name = "bDelTheme";
            this.bDelTheme.Size = new System.Drawing.Size(23, 23);
            this.bDelTheme.TabIndex = 6;
            this.bDelTheme.Text = "X";
            this.bDelTheme.UseVisualStyleBackColor = true;
            this.bDelTheme.Click += new System.EventHandler(this.bDelTheme_Click);
            // 
            // bDelChapter
            // 
            this.bDelChapter.Location = new System.Drawing.Point(454, 12);
            this.bDelChapter.Name = "bDelChapter";
            this.bDelChapter.Size = new System.Drawing.Size(23, 23);
            this.bDelChapter.TabIndex = 7;
            this.bDelChapter.Text = "X";
            this.bDelChapter.UseVisualStyleBackColor = true;
            this.bDelChapter.Click += new System.EventHandler(this.bDelChapter_Click);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(604, 231);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(91, 23);
            this.bCancel.TabIndex = 8;
            this.bCancel.Text = "Zurück";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(604, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Bearbeiten";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(650, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Neu..."});
            this.comboBox1.Location = new System.Drawing.Point(523, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Neue...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Frage";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbD);
            this.tabPage2.Controls.Add(this.cbC);
            this.tabPage2.Controls.Add(this.cbB);
            this.tabPage2.Controls.Add(this.cbA);
            this.tabPage2.Controls.Add(this.textBoxD);
            this.tabPage2.Controls.Add(this.textBoxC);
            this.tabPage2.Controls.Add(this.textBoxB);
            this.tabPage2.Controls.Add(this.textBoxA);
            this.tabPage2.Controls.Add(this.lD);
            this.tabPage2.Controls.Add(this.lC);
            this.tabPage2.Controls.Add(this.lB);
            this.tabPage2.Controls.Add(this.lA);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(603, 119);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ABCD";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lA
            // 
            this.lA.AutoSize = true;
            this.lA.Location = new System.Drawing.Point(21, 7);
            this.lA.Name = "lA";
            this.lA.Size = new System.Drawing.Size(17, 13);
            this.lA.TabIndex = 0;
            this.lA.Text = "A:";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(24, 23);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(221, 20);
            this.textBoxA.TabIndex = 1;
            // 
            // lB
            // 
            this.lB.AutoSize = true;
            this.lB.Location = new System.Drawing.Point(21, 58);
            this.lB.Name = "lB";
            this.lB.Size = new System.Drawing.Size(17, 13);
            this.lB.TabIndex = 2;
            this.lB.Text = "B:";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(24, 74);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(221, 20);
            this.textBoxB.TabIndex = 3;
            // 
            // lC
            // 
            this.lC.AutoSize = true;
            this.lC.Location = new System.Drawing.Point(319, 7);
            this.lC.Name = "lC";
            this.lC.Size = new System.Drawing.Size(17, 13);
            this.lC.TabIndex = 4;
            this.lC.Text = "C:";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(322, 23);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(221, 20);
            this.textBoxC.TabIndex = 5;
            // 
            // lD
            // 
            this.lD.AutoSize = true;
            this.lD.Location = new System.Drawing.Point(319, 58);
            this.lD.Name = "lD";
            this.lD.Size = new System.Drawing.Size(18, 13);
            this.lD.TabIndex = 6;
            this.lD.Text = "D:";
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(322, 74);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(221, 20);
            this.textBoxD.TabIndex = 7;
            // 
            // cbA
            // 
            this.cbA.AutoSize = true;
            this.cbA.ForeColor = System.Drawing.Color.Green;
            this.cbA.Location = new System.Drawing.Point(251, 25);
            this.cbA.Name = "cbA";
            this.cbA.Size = new System.Drawing.Size(35, 17);
            this.cbA.TabIndex = 8;
            this.cbA.Text = "✔";
            this.cbA.UseVisualStyleBackColor = true;
            // 
            // cbB
            // 
            this.cbB.AutoSize = true;
            this.cbB.ForeColor = System.Drawing.Color.Green;
            this.cbB.Location = new System.Drawing.Point(251, 76);
            this.cbB.Name = "cbB";
            this.cbB.Size = new System.Drawing.Size(35, 17);
            this.cbB.TabIndex = 9;
            this.cbB.Text = "✔";
            this.cbB.UseVisualStyleBackColor = true;
            // 
            // cbC
            // 
            this.cbC.AutoSize = true;
            this.cbC.ForeColor = System.Drawing.Color.Green;
            this.cbC.Location = new System.Drawing.Point(549, 25);
            this.cbC.Name = "cbC";
            this.cbC.Size = new System.Drawing.Size(35, 17);
            this.cbC.TabIndex = 10;
            this.cbC.Text = "✔";
            this.cbC.UseVisualStyleBackColor = true;
            // 
            // cbD
            // 
            this.cbD.AutoSize = true;
            this.cbD.ForeColor = System.Drawing.Color.Green;
            this.cbD.Location = new System.Drawing.Point(549, 76);
            this.cbD.Name = "cbD";
            this.cbD.Size = new System.Drawing.Size(35, 17);
            this.cbD.TabIndex = 11;
            this.cbD.Text = "✔";
            this.cbD.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbText);
            this.tabPage1.Controls.Add(this.lText);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(603, 119);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Text";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lText
            // 
            this.lText.AutoSize = true;
            this.lText.Location = new System.Drawing.Point(15, 35);
            this.lText.Name = "lText";
            this.lText.Size = new System.Drawing.Size(46, 13);
            this.lText.TabIndex = 0;
            this.lText.Text = "Antwort:";
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(18, 51);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(525, 20);
            this.tbText.TabIndex = 1;
            // 
            // tType
            // 
            this.tType.Controls.Add(this.tabPage1);
            this.tType.Controls.Add(this.tabPage2);
            this.tType.Location = new System.Drawing.Point(3, 68);
            this.tType.Name = "tType";
            this.tType.SelectedIndex = 0;
            this.tType.Size = new System.Drawing.Size(611, 145);
            this.tType.TabIndex = 4;
            // 
            // QuizAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(705, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bDelChapter);
            this.Controls.Add(this.bDelTheme);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbChapter);
            this.Controls.Add(this.lChapter);
            this.Controls.Add(this.cbTheme);
            this.Controls.Add(this.lTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QuizAdd";
            this.Text = "LernX - Hinzufügen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tType.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lTheme;
		private System.Windows.Forms.ComboBox cbTheme;
		private System.Windows.Forms.ComboBox cbChapter;
		private System.Windows.Forms.Label lChapter;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button bAdd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lInfo;
		private System.Windows.Forms.Button bDelTheme;
		private System.Windows.Forms.Button bDelChapter;
		private System.Windows.Forms.Button bCancel;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tType;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label lText;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cbD;
        private System.Windows.Forms.CheckBox cbC;
        private System.Windows.Forms.CheckBox cbB;
        private System.Windows.Forms.CheckBox cbA;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label lD;
        private System.Windows.Forms.Label lC;
        private System.Windows.Forms.Label lB;
        private System.Windows.Forms.Label lA;
    }
}