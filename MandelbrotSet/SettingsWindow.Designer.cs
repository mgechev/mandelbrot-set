namespace MandelbrotSet
{
    partial class SettingsWindow
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.iterationsTrackbar = new System.Windows.Forms.TrackBar();
            this.iterationsLabel = new System.Windows.Forms.Label();
            this.colorsCombobox = new System.Windows.Forms.ComboBox();
            this.colorsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(17, 104);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(115, 104);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButtonClick);
            // 
            // iterationsTrackbar
            // 
            this.iterationsTrackbar.Location = new System.Drawing.Point(75, 13);
            this.iterationsTrackbar.Maximum = 2000;
            this.iterationsTrackbar.Minimum = 50;
            this.iterationsTrackbar.Name = "iterationsTrackbar";
            this.iterationsTrackbar.Size = new System.Drawing.Size(213, 45);
            this.iterationsTrackbar.TabIndex = 2;
            this.iterationsTrackbar.TickFrequency = 50;
            this.iterationsTrackbar.Value = 256;
            // 
            // iterationsLabel
            // 
            this.iterationsLabel.AutoSize = true;
            this.iterationsLabel.Location = new System.Drawing.Point(17, 19);
            this.iterationsLabel.Name = "iterationsLabel";
            this.iterationsLabel.Size = new System.Drawing.Size(53, 13);
            this.iterationsLabel.TabIndex = 3;
            this.iterationsLabel.Text = "Iterations:";
            // 
            // colorsCombobox
            // 
            this.colorsCombobox.FormattingEnabled = true;
            this.colorsCombobox.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.colorsCombobox.Location = new System.Drawing.Point(83, 63);
            this.colorsCombobox.Name = "colorsCombobox";
            this.colorsCombobox.Size = new System.Drawing.Size(205, 21);
            this.colorsCombobox.TabIndex = 4;
            this.colorsCombobox.Text = "Green";
            // 
            // colorsLabel
            // 
            this.colorsLabel.AutoSize = true;
            this.colorsLabel.Location = new System.Drawing.Point(17, 68);
            this.colorsLabel.Name = "colorsLabel";
            this.colorsLabel.Size = new System.Drawing.Size(60, 13);
            this.colorsLabel.TabIndex = 5;
            this.colorsLabel.Text = "Base color:";
            // 
            // SettingsWindow
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(310, 136);
            this.Controls.Add(this.colorsLabel);
            this.Controls.Add(this.colorsCombobox);
            this.Controls.Add(this.iterationsLabel);
            this.Controls.Add(this.iterationsTrackbar);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Name = "SettingsWindow";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.iterationsTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TrackBar iterationsTrackbar;
        private System.Windows.Forms.Label iterationsLabel;
        private System.Windows.Forms.ComboBox colorsCombobox;
        private System.Windows.Forms.Label colorsLabel;
    }
}