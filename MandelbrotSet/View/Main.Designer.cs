namespace MandelbrotSet
{
    partial class Main
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
            this.fractalCanvas = new System.Windows.Forms.PictureBox();
            this.renderButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fractalCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // fractalCanvas
            // 
            this.fractalCanvas.Location = new System.Drawing.Point(12, 12);
            this.fractalCanvas.Name = "fractalCanvas";
            this.fractalCanvas.Size = new System.Drawing.Size(495, 473);
            this.fractalCanvas.TabIndex = 0;
            this.fractalCanvas.TabStop = false;
            // 
            // renderButton
            // 
            this.renderButton.Location = new System.Drawing.Point(12, 491);
            this.renderButton.Name = "renderButton";
            this.renderButton.Size = new System.Drawing.Size(75, 23);
            this.renderButton.TabIndex = 1;
            this.renderButton.Text = "Render";
            this.renderButton.UseVisualStyleBackColor = true;
            this.renderButton.Click += new System.EventHandler(this.renderButtonClick);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(104, 491);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButtonClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 526);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.renderButton);
            this.Controls.Add(this.fractalCanvas);
            this.Name = "Main";
            this.Text = "Mandelbrot Set";
            ((System.ComponentModel.ISupportInitialize)(this.fractalCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox FractalCanvas
        {
            get
            {
                return fractalCanvas;
            }
        }

        private System.Windows.Forms.PictureBox fractalCanvas;
        private System.Windows.Forms.Button renderButton;
        private System.Windows.Forms.Button clearButton;
    }
}

