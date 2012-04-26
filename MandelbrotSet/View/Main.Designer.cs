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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.fractalCanvas = new System.Windows.Forms.PictureBox();
            this.renderButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.interactionPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iterationsInput = new System.Windows.Forms.TrackBar();
            this.zoomOutButton = new System.Windows.Forms.Button();
            this.zoomInButton = new System.Windows.Forms.Button();
            this.topButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.bottomButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fractalCanvas)).BeginInit();
            this.interactionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsInput)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fractalCanvas
            // 
            this.fractalCanvas.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.fractalCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fractalCanvas.Location = new System.Drawing.Point(12, 12);
            this.fractalCanvas.Name = "fractalCanvas";
            this.fractalCanvas.Size = new System.Drawing.Size(500, 500);
            this.fractalCanvas.TabIndex = 0;
            this.fractalCanvas.TabStop = false;
            // 
            // renderButton
            // 
            this.renderButton.Location = new System.Drawing.Point(5, 6);
            this.renderButton.Name = "renderButton";
            this.renderButton.Size = new System.Drawing.Size(75, 23);
            this.renderButton.TabIndex = 0;
            this.renderButton.Text = "Render";
            this.renderButton.UseVisualStyleBackColor = true;
            this.renderButton.Click += new System.EventHandler(this.RenderButtonClick);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(5, 32);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(5, 58);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // interactionPanel
            // 
            this.interactionPanel.Controls.Add(this.label1);
            this.interactionPanel.Controls.Add(this.iterationsInput);
            this.interactionPanel.Controls.Add(this.zoomOutButton);
            this.interactionPanel.Controls.Add(this.zoomInButton);
            this.interactionPanel.Controls.Add(this.topButton);
            this.interactionPanel.Controls.Add(this.rightButton);
            this.interactionPanel.Controls.Add(this.bottomButton);
            this.interactionPanel.Controls.Add(this.leftButton);
            this.interactionPanel.Location = new System.Drawing.Point(518, 13);
            this.interactionPanel.Name = "interactionPanel";
            this.interactionPanel.Size = new System.Drawing.Size(87, 240);
            this.interactionPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Iterations";
            // 
            // iterationsInput
            // 
            this.iterationsInput.Location = new System.Drawing.Point(5, 123);
            this.iterationsInput.Maximum = 2048;
            this.iterationsInput.Minimum = 128;
            this.iterationsInput.Name = "iterationsInput";
            this.iterationsInput.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.iterationsInput.Size = new System.Drawing.Size(45, 114);
            this.iterationsInput.TabIndex = 9;
            this.iterationsInput.TickFrequency = 128;
            this.iterationsInput.Value = 256;
            this.iterationsInput.ValueChanged += new System.EventHandler(this.IterationsInputValueChanged);
            // 
            // zoomOutButton
            // 
            this.zoomOutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zoomOutButton.BackgroundImage")));
            this.zoomOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.zoomOutButton.Location = new System.Drawing.Point(54, 90);
            this.zoomOutButton.Name = "zoomOutButton";
            this.zoomOutButton.Size = new System.Drawing.Size(25, 25);
            this.zoomOutButton.TabIndex = 8;
            this.zoomOutButton.UseVisualStyleBackColor = true;
            this.zoomOutButton.Click += new System.EventHandler(this.ZoomOutButtonClick);
            // 
            // zoomInButton
            // 
            this.zoomInButton.BackgroundImage = global::MandelbrotSet.Properties.Resources.zoom_in;
            this.zoomInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.zoomInButton.Location = new System.Drawing.Point(8, 90);
            this.zoomInButton.Name = "zoomInButton";
            this.zoomInButton.Size = new System.Drawing.Size(25, 25);
            this.zoomInButton.TabIndex = 7;
            this.zoomInButton.UseVisualStyleBackColor = true;
            this.zoomInButton.Click += new System.EventHandler(this.ZoomInButtonClick);
            // 
            // topButton
            // 
            this.topButton.BackgroundImage = global::MandelbrotSet.Properties.Resources.arrow_top;
            this.topButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.topButton.Location = new System.Drawing.Point(31, 9);
            this.topButton.Name = "topButton";
            this.topButton.Size = new System.Drawing.Size(25, 25);
            this.topButton.TabIndex = 3;
            this.topButton.UseVisualStyleBackColor = true;
            this.topButton.Click += new System.EventHandler(this.TopButtonClick);
            // 
            // rightButton
            // 
            this.rightButton.BackgroundImage = global::MandelbrotSet.Properties.Resources.arrow_right;
            this.rightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rightButton.Location = new System.Drawing.Point(54, 32);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(25, 25);
            this.rightButton.TabIndex = 5;
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.RightButtonClick);
            // 
            // bottomButton
            // 
            this.bottomButton.BackgroundImage = global::MandelbrotSet.Properties.Resources.arrow_bottom;
            this.bottomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bottomButton.Location = new System.Drawing.Point(31, 55);
            this.bottomButton.Name = "bottomButton";
            this.bottomButton.Size = new System.Drawing.Size(25, 25);
            this.bottomButton.TabIndex = 6;
            this.bottomButton.UseVisualStyleBackColor = true;
            this.bottomButton.Click += new System.EventHandler(this.BottomButtonClick);
            // 
            // leftButton
            // 
            this.leftButton.BackgroundImage = global::MandelbrotSet.Properties.Resources.arrow_left;
            this.leftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.leftButton.Location = new System.Drawing.Point(8, 32);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(25, 25);
            this.leftButton.TabIndex = 4;
            this.leftButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.LeftButtonClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.renderButton);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Location = new System.Drawing.Point(518, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(87, 88);
            this.panel1.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.interactionPanel);
            this.Controls.Add(this.fractalCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Mandelbrot Set";
            ((System.ComponentModel.ISupportInitialize)(this.fractalCanvas)).EndInit();
            this.interactionPanel.ResumeLayout(false);
            this.interactionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsInput)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel interactionPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button bottomButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button topButton;
        private System.Windows.Forms.Button zoomInButton;
        private System.Windows.Forms.Button zoomOutButton;
        private System.Windows.Forms.TrackBar iterationsInput;
        private System.Windows.Forms.Label label1;
    }
}

