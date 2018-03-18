namespace LernX {
	partial class AddDialog {
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
			this.tbName = new System.Windows.Forms.TextBox();
			this.bAdd = new System.Windows.Forms.Button();
			this.bCancel = new System.Windows.Forms.Button();
			this.lName = new System.Windows.Forms.Label();
			this.lError = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(15, 29);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(175, 20);
			this.tbName.TabIndex = 0;
			this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
			// 
			// bAdd
			// 
			this.bAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.bAdd.Enabled = false;
			this.bAdd.Location = new System.Drawing.Point(105, 86);
			this.bAdd.Name = "bAdd";
			this.bAdd.Size = new System.Drawing.Size(86, 23);
			this.bAdd.TabIndex = 1;
			this.bAdd.Text = "Hinzufügen";
			this.bAdd.UseVisualStyleBackColor = true;
			this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
			// 
			// bCancel
			// 
			this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bCancel.Location = new System.Drawing.Point(15, 86);
			this.bCancel.Name = "bCancel";
			this.bCancel.Size = new System.Drawing.Size(84, 22);
			this.bCancel.TabIndex = 2;
			this.bCancel.Text = "Abbrechen";
			this.bCancel.UseVisualStyleBackColor = true;
			this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
			// 
			// lName
			// 
			this.lName.AutoSize = true;
			this.lName.Location = new System.Drawing.Point(12, 9);
			this.lName.Name = "lName";
			this.lName.Size = new System.Drawing.Size(38, 13);
			this.lName.TabIndex = 3;
			this.lName.Text = "Name:";
			// 
			// lError
			// 
			this.lError.AutoSize = true;
			this.lError.ForeColor = System.Drawing.Color.DarkRed;
			this.lError.Location = new System.Drawing.Point(12, 52);
			this.lError.Name = "lError";
			this.lError.Size = new System.Drawing.Size(124, 13);
			this.lError.TabIndex = 4;
			this.lError.Text = "Name schon vorhanden!";
			// 
			// AddDialog
			// 
			this.AcceptButton = this.bAdd;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.bCancel;
			this.ClientSize = new System.Drawing.Size(202, 120);
			this.Controls.Add(this.lError);
			this.Controls.Add(this.lName);
			this.Controls.Add(this.bCancel);
			this.Controls.Add(this.bAdd);
			this.Controls.Add(this.tbName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "... hinzufügen";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Button bAdd;
		private System.Windows.Forms.Button bCancel;
		private System.Windows.Forms.Label lName;
		private System.Windows.Forms.Label lError;
	}
}