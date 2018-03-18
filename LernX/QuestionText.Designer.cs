namespace LernX
{

    partial class QuestionText
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
            this.tbText = new System.Windows.Forms.TextBox();
            this.lText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(40, 57);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(525, 20);
            this.tbText.TabIndex = 3;
            // 
            // lText
            // 
            this.lText.AutoSize = true;
            this.lText.Location = new System.Drawing.Point(37, 41);
            this.lText.Name = "lText";
            this.lText.Size = new System.Drawing.Size(46, 13);
            this.lText.TabIndex = 2;
            this.lText.Text = "Antwort:";
            // 
            // QuestionText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.lText);
            this.Name = "QuestionText";
            this.Size = new System.Drawing.Size(603, 119);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbText;
        public System.Windows.Forms.Label lText;
    }
}
