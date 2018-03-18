using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LernX {

	[Serializable]
	abstract class Question {
		public string name;

        public abstract Control[] PrepareControls();
		public abstract void PrepareRender();
		public abstract bool IsAnsweredCorrectly();
        public abstract Question Load(string content);
		public new abstract string ToString();

		public static string ObjectToString(object obj) {
			using (MemoryStream ms = new MemoryStream()) {
				new BinaryFormatter().Serialize(ms, obj);
				return Convert.ToBase64String(ms.ToArray());
			}
		}

		public static object StringToObject(string base64String) {
			byte[] bytes = Convert.FromBase64String(base64String);
			using (MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length)) {
				ms.Write(bytes, 0, bytes.Length);
				ms.Position = 0;
				return new BinaryFormatter().Deserialize(ms);
			}
		}
	}

	[Serializable]
	sealed class TextQuestion : Question {
        string answer;

		[NonSerialized]
        private QuestionText control;

		public void Clone(TextQuestion clone) {
			this.name = clone.name;
			this.answer = clone.answer;
		}

        public TextQuestion()
        {

        }

        public TextQuestion(string name, string answer) {
            this.name = name;
            this.answer = answer;
        }

        public override bool IsAnsweredCorrectly()
        {
            return control.tbText.Text == answer;
        }


        public override Control[] PrepareControls()
        {
            if (control != null)
                control.Dispose();

            return new Control[]{/*
				checkBoxA = new CheckBox(),
				checkBoxB = new CheckBox(),
				checkBoxC = new CheckBox(),
				checkBoxD = new CheckBox(),
				lA = new Label(),
				lB = new Label(),
				lC = new Label(),
				lD = new Label(),*/
                control = new QuestionText()
            };
        }

        public override void PrepareRender()
        {
            return;
        }

		public override Question Load(string content) {
			Clone((TextQuestion)StringToObject(content));
			return this;
			//throw new NotImplementedException();
		}

		public override string ToString() {
			return ObjectToString(this);
		}
	}

	[Serializable]
	sealed class ABCDQuestion : Question {
		string a, b, c, d;
		bool aCorrect, bCorrect, cCorrect, dCorrect;

		[NonSerialized]
		private QuestionABCD control;

        //private CheckBox checkBoxA, checkBoxB, checkBoxC, checkBoxD;
        //private Label lA, lB, lC, lD;

        public ABCDQuestion()
        {

        }

		public ABCDQuestion(string name, string a, string b, string c, string d, bool aCorrect = false, bool bCorrect = false, bool cCorrect = false, bool dCorrect = false)
		{
			this.name = name;
			this.a = a;
			this.b = b;
			this.c = c;
			this.d = d;
			this.aCorrect = aCorrect;
			this.bCorrect = bCorrect;
			this.cCorrect = cCorrect;
			this.dCorrect = dCorrect;
		}

		private void Clone(ABCDQuestion clone) {
			this.a = clone.a;
			this.b = clone.b;
			this.c = clone.c;
			this.d = clone.d;
			this.aCorrect = clone.aCorrect;
			this.bCorrect = clone.bCorrect;
			this.cCorrect = clone.cCorrect;
			this.dCorrect = clone.dCorrect;
		}

		private ABCDQuestion(ABCDQuestion clone){
			this.a = clone.a;
			this.b = clone.b;
			this.c = clone.c;
			this.d = clone.d;
			this.aCorrect = clone.aCorrect;
			this.bCorrect = clone.bCorrect;
			this.cCorrect = clone.cCorrect;
			this.dCorrect = clone.dCorrect;
		}

		public override Control[] PrepareControls()
		{
            if (control != null)
                control.Dispose();

			return new Control[]{/*
				checkBoxA = new CheckBox(),
				checkBoxB = new CheckBox(),
				checkBoxC = new CheckBox(),
				checkBoxD = new CheckBox(),
				lA = new Label(),
				lB = new Label(),
				lC = new Label(),
				lD = new Label(),*/
                control = new QuestionABCD()
			};
		}

		public override void PrepareRender() {
            /*
            // 
            // checkBoxA
            // 
            control.checkBoxA.AutoSize = true;
            control.checkBoxA.ForeColor = System.Drawing.Color.Green;
            control.checkBoxA.Location = new System.Drawing.Point(549, 76);
            control.checkBoxA.Name = "checkBoxA";
            control.checkBoxA.Size = new System.Drawing.Size(35, 17);
            control.checkBoxA.TabIndex = 11;
            control.checkBoxA.UseVisualStyleBackColor = true;
            // 
            // checkBoxB
            // 
            control.checkBoxB.AutoSize = true;
            control.checkBoxB.ForeColor = System.Drawing.Color.Green;
            control.checkBoxB.Location = new System.Drawing.Point(549, 25);
			control.checkBoxB.Name = "checkBoxB";
			control.checkBoxB.Size = new System.Drawing.Size(35, 17);
			control.checkBoxB.TabIndex = 10;
			control.checkBoxB.UseVisualStyleBackColor = true;
			// 
			// checkBoxC
			// 
			control.checkBoxC.AutoSize = true;
			control.checkBoxC.ForeColor = System.Drawing.Color.Green;
			control.checkBoxC.Location = new System.Drawing.Point(251, 76);
			control.checkBoxC.Name = "checkBoxC";
			control.checkBoxC.Size = new System.Drawing.Size(35, 17);
			control.checkBoxC.TabIndex = 9;
			control.checkBoxC.UseVisualStyleBackColor = true;
			// 
			// checkBoxD
			// 
			control.checkBoxD.AutoSize = true;
			control.checkBoxD.ForeColor = System.Drawing.Color.Green;
			control.checkBoxD.Location = new System.Drawing.Point(251, 25);
			control.checkBoxD.Name = "checkBoxD";
			control.checkBoxD.Size = new System.Drawing.Size(35, 17);
			control.checkBoxD.TabIndex = 8;
			control.checkBoxD.UseVisualStyleBackColor = true;
			// 
			// lA
			// 
			control.lA.AutoSize = true;
			control.lA.Location = new System.Drawing.Point(24, 23);
			control.lA.Name = "lA";
			control.lA.Size = new System.Drawing.Size(221, 20);
			control.lA.TabIndex = 0;
			control.lA.Text = "A:";
			// 
			// lB
			// 
			control.lB.AutoSize = true;
			control.lB.Location = new System.Drawing.Point(24, 74);
			control.lB.Name = "lB";
			control.lB.Size = new System.Drawing.Size(221, 20);
			control.lB.TabIndex = 2;
			control.lB.Text = "B:";
			// 
			// lC
			// 
			control.lC.AutoSize = true;
			control.lC.Location = new System.Drawing.Point(322, 23);
			control.lC.Name = "lC";
			control.lC.Size = new System.Drawing.Size(221, 20);
			control.lC.TabIndex = 4;
			control.lC.Text = "C:";
			// 
			// lD
			// 
			control.lD.AutoSize = true;
			control.lD.Location = new System.Drawing.Point(322, 74);
			control.lD.Name = "lD";
			control.lD.Size = new System.Drawing.Size(221, 20);
			control.lD.TabIndex = 6;
			control.lD.Text = "D:";*/

            control.lA.Text = "A: " + a;
            control.lB.Text = "B: " + b;
            control.lC.Text = "C: " + c;
            control.lD.Text = "D: " + d;
        }

		public bool MarkError(Control c, bool isCorrect) {
			c.BackColor = isCorrect ? c.BackColor = Control.DefaultBackColor : c.BackColor = Color.DarkRed;
			return isCorrect;
		}

		public override bool IsAnsweredCorrectly() {
			bool isCorrect = true;

			isCorrect = MarkError(control.checkBoxA, control.checkBoxA.Checked == aCorrect) && isCorrect;
			isCorrect = MarkError(control.checkBoxB, control.checkBoxB.Checked == bCorrect) && isCorrect;
			isCorrect = MarkError(control.checkBoxC, control.checkBoxC.Checked == cCorrect) && isCorrect;
			isCorrect = MarkError(control.checkBoxD, control.checkBoxD.Checked == dCorrect) && isCorrect;
			/*if (control.checkBoxB.Checked && !bCorrect)
                return false;
            if (control.checkBoxC.Checked && !cCorrect)
                return false;
            if (control.checkBoxD.Checked && !dCorrect)
                return false;*/

            return isCorrect;
        }

        public override Question Load(string content)
        {
			Clone((ABCDQuestion)StringToObject(content));
			return this;//throw new NotImplementedException();
        }

		public override string ToString() {
			return ObjectToString(this);
			//throw new NotImplementedException();
		}
	}
}
