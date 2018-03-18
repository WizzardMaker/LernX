using System.Windows.Forms;

namespace LernX
{
    partial class QuestionABCD
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
			this.checkBoxD = new System.Windows.Forms.CheckBox();
			this.checkBoxC = new System.Windows.Forms.CheckBox();
			this.checkBoxB = new System.Windows.Forms.CheckBox();
			this.checkBoxA = new System.Windows.Forms.CheckBox();
			this.lA = new System.Windows.Forms.Label();
			this.lB = new System.Windows.Forms.Label();
			this.lC = new System.Windows.Forms.Label();
			this.lD = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// checkBoxD
			// 
			this.checkBoxD.AutoSize = true;
			this.checkBoxD.ForeColor = System.Drawing.Color.Green;
			this.checkBoxD.Location = new System.Drawing.Point(549, 76);
			this.checkBoxD.Name = "checkBoxD";
			this.checkBoxD.Size = new System.Drawing.Size(15, 14);
			this.checkBoxD.TabIndex = 11;
			this.checkBoxD.UseVisualStyleBackColor = true;
			// 
			// checkBoxC
			// 
			this.checkBoxC.AutoSize = true;
			this.checkBoxC.ForeColor = System.Drawing.Color.Green;
			this.checkBoxC.Location = new System.Drawing.Point(549, 25);
			this.checkBoxC.Name = "checkBoxC";
			this.checkBoxC.Size = new System.Drawing.Size(15, 14);
			this.checkBoxC.TabIndex = 10;
			this.checkBoxC.UseVisualStyleBackColor = true;
			// 
			// checkBoxB
			// 
			this.checkBoxB.AutoSize = true;
			this.checkBoxB.ForeColor = System.Drawing.Color.Green;
			this.checkBoxB.Location = new System.Drawing.Point(251, 76);
			this.checkBoxB.Name = "checkBoxB";
			this.checkBoxB.Size = new System.Drawing.Size(15, 14);
			this.checkBoxB.TabIndex = 9;
			this.checkBoxB.UseVisualStyleBackColor = true;
			// 
			// checkBoxA
			// 
			this.checkBoxA.AutoSize = true;
			this.checkBoxA.ForeColor = System.Drawing.Color.Green;
			this.checkBoxA.Location = new System.Drawing.Point(251, 25);
			this.checkBoxA.Name = "checkBoxA";
			this.checkBoxA.Size = new System.Drawing.Size(15, 14);
			this.checkBoxA.TabIndex = 8;
			this.checkBoxA.UseVisualStyleBackColor = true;
			// 
			// lA
			// 
			this.lA.AutoSize = true;
			this.lA.Location = new System.Drawing.Point(24, 23);
			this.lA.Name = "lA";
			this.lA.Size = new System.Drawing.Size(17, 13);
			this.lA.TabIndex = 0;
			this.lA.Text = "A:";
			// 
			// lB
			// 
			this.lB.AutoSize = true;
			this.lB.Location = new System.Drawing.Point(24, 74);
			this.lB.Name = "lB";
			this.lB.Size = new System.Drawing.Size(17, 13);
			this.lB.TabIndex = 2;
			this.lB.Text = "B:";
			// 
			// lC
			// 
			this.lC.AutoSize = true;
			this.lC.Location = new System.Drawing.Point(322, 23);
			this.lC.Name = "lC";
			this.lC.Size = new System.Drawing.Size(17, 13);
			this.lC.TabIndex = 4;
			this.lC.Text = "C:";
			// 
			// lD
			// 
			this.lD.AutoSize = true;
			this.lD.Location = new System.Drawing.Point(322, 74);
			this.lD.Name = "lD";
			this.lD.Size = new System.Drawing.Size(18, 13);
			this.lD.TabIndex = 6;
			this.lD.Text = "D:";
			// 
			// QuestionABCD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.checkBoxD);
			this.Controls.Add(this.checkBoxC);
			this.Controls.Add(this.checkBoxB);
			this.Controls.Add(this.checkBoxA);
			this.Controls.Add(this.lA);
			this.Controls.Add(this.lB);
			this.Controls.Add(this.lC);
			this.Controls.Add(this.lD);
			this.Name = "QuestionABCD";
			this.Size = new System.Drawing.Size(603, 119);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public CheckBox checkBoxD, checkBoxC, checkBoxB, checkBoxA;
        public Label lA, lB, lC, lD;
    }
}
