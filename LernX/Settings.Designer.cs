namespace LernX {
	partial class Settings {
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
			this.bClearDatabase = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bClearDatabase
			// 
			this.bClearDatabase.Location = new System.Drawing.Point(12, 12);
			this.bClearDatabase.Name = "bClearDatabase";
			this.bClearDatabase.Size = new System.Drawing.Size(143, 23);
			this.bClearDatabase.TabIndex = 0;
			this.bClearDatabase.Text = "Clear Question Database";
			this.bClearDatabase.UseVisualStyleBackColor = true;
			this.bClearDatabase.Click += new System.EventHandler(this.bClearDatabase_Click);
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 261);
			this.Controls.Add(this.bClearDatabase);
			this.Name = "Settings";
			this.Text = "LernX - Einstellungen";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button bClearDatabase;
	}
}