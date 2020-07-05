namespace TestForm2
{
    partial class FirstForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstForm));
            this.TopBar = new System.Windows.Forms.PictureBox();
            this.CrossSign = new System.Windows.Forms.PictureBox();
            this.CoreNLPButton = new System.Windows.Forms.PictureBox();
            this.OpenNLPButton = new System.Windows.Forms.PictureBox();
            this.WordNetButton = new System.Windows.Forms.PictureBox();
            this.MicroButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CoreNLPLabel = new System.Windows.Forms.Label();
            this.OpenNLPLabel = new System.Windows.Forms.Label();
            this.WordNetLabel = new System.Windows.Forms.Label();
            this.MicroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoreNLPButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenNLPButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WordNetButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MicroButton)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.Image = ((System.Drawing.Image)(resources.GetObject("TopBar.Image")));
            this.TopBar.Location = new System.Drawing.Point(-2, -2);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(518, 35);
            this.TopBar.TabIndex = 0;
            this.TopBar.TabStop = false;
            this.TopBar.Click += new System.EventHandler(this.TopBar_Click);
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            // 
            // CrossSign
            // 
            this.CrossSign.BackColor = System.Drawing.SystemColors.Highlight;
            this.CrossSign.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CrossSign.BackgroundImage")));
            this.CrossSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CrossSign.Location = new System.Drawing.Point(478, -2);
            this.CrossSign.Name = "CrossSign";
            this.CrossSign.Size = new System.Drawing.Size(38, 35);
            this.CrossSign.TabIndex = 1;
            this.CrossSign.TabStop = false;
            this.CrossSign.Click += new System.EventHandler(this.CrossSign_Click);
            this.CrossSign.MouseLeave += new System.EventHandler(this.CrossSign_MouseLeave);
            this.CrossSign.MouseHover += new System.EventHandler(this.CrossSign_MouseHover);
            // 
            // CoreNLPButton
            // 
            this.CoreNLPButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CoreNLPButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CoreNLPButton.Location = new System.Drawing.Point(171, 113);
            this.CoreNLPButton.Name = "CoreNLPButton";
            this.CoreNLPButton.Size = new System.Drawing.Size(100, 50);
            this.CoreNLPButton.TabIndex = 2;
            this.CoreNLPButton.TabStop = false;
            this.CoreNLPButton.Click += new System.EventHandler(this.CoreNLPButton_Click);
            this.CoreNLPButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CoreNLPButton_MouseClick);
            this.CoreNLPButton.MouseLeave += new System.EventHandler(this.CoreNLPButton_MouseLeave);
            this.CoreNLPButton.MouseHover += new System.EventHandler(this.CoreNLPButton_MouseHover);
            // 
            // OpenNLPButton
            // 
            this.OpenNLPButton.Location = new System.Drawing.Point(320, 112);
            this.OpenNLPButton.Name = "OpenNLPButton";
            this.OpenNLPButton.Size = new System.Drawing.Size(100, 50);
            this.OpenNLPButton.TabIndex = 3;
            this.OpenNLPButton.TabStop = false;
            this.OpenNLPButton.Click += new System.EventHandler(this.OpenNLPButton_Click);
            this.OpenNLPButton.MouseLeave += new System.EventHandler(this.OpenNLPButton_MouseLeave);
            this.OpenNLPButton.MouseHover += new System.EventHandler(this.OpenNLPButton_MouseHover);
            // 
            // WordNetButton
            // 
            this.WordNetButton.Location = new System.Drawing.Point(171, 191);
            this.WordNetButton.Name = "WordNetButton";
            this.WordNetButton.Size = new System.Drawing.Size(100, 50);
            this.WordNetButton.TabIndex = 4;
            this.WordNetButton.TabStop = false;
            this.WordNetButton.Click += new System.EventHandler(this.WordNetButton_Click);
            this.WordNetButton.MouseLeave += new System.EventHandler(this.WordNetButton_MouseLeave);
            this.WordNetButton.MouseHover += new System.EventHandler(this.WordNetButton_MouseHover);
            // 
            // MicroButton
            // 
            this.MicroButton.Location = new System.Drawing.Point(320, 191);
            this.MicroButton.Name = "MicroButton";
            this.MicroButton.Size = new System.Drawing.Size(100, 50);
            this.MicroButton.TabIndex = 5;
            this.MicroButton.TabStop = false;
            this.MicroButton.Click += new System.EventHandler(this.MicroButton_Click);
            this.MicroButton.MouseLeave += new System.EventHandler(this.MicroButton_MouseLeave);
            this.MicroButton.MouseHover += new System.EventHandler(this.MicroButton_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Combined NLP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // CoreNLPLabel
            // 
            this.CoreNLPLabel.AutoSize = true;
            this.CoreNLPLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CoreNLPLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CoreNLPLabel.Location = new System.Drawing.Point(194, 130);
            this.CoreNLPLabel.Name = "CoreNLPLabel";
            this.CoreNLPLabel.Size = new System.Drawing.Size(50, 13);
            this.CoreNLPLabel.TabIndex = 7;
            this.CoreNLPLabel.Text = "CoreNLP";
            this.CoreNLPLabel.Click += new System.EventHandler(this.CoreNLPLabel_Click);
            this.CoreNLPLabel.MouseLeave += new System.EventHandler(this.CoreNLPLabel_MouseLeave);
            this.CoreNLPLabel.MouseHover += new System.EventHandler(this.CoreNLPLabel_MouseHover);
            // 
            // OpenNLPLabel
            // 
            this.OpenNLPLabel.AutoSize = true;
            this.OpenNLPLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.OpenNLPLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OpenNLPLabel.Location = new System.Drawing.Point(342, 130);
            this.OpenNLPLabel.Name = "OpenNLPLabel";
            this.OpenNLPLabel.Size = new System.Drawing.Size(54, 13);
            this.OpenNLPLabel.TabIndex = 8;
            this.OpenNLPLabel.Text = "OpenNLP";
            this.OpenNLPLabel.Click += new System.EventHandler(this.OpenNLPLabel_Click);
            this.OpenNLPLabel.MouseLeave += new System.EventHandler(this.OpenNLPLabel_MouseLeave);
            this.OpenNLPLabel.MouseHover += new System.EventHandler(this.OpenNLPLabel_MouseHover);
            // 
            // WordNetLabel
            // 
            this.WordNetLabel.AutoSize = true;
            this.WordNetLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.WordNetLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WordNetLabel.Location = new System.Drawing.Point(194, 208);
            this.WordNetLabel.Name = "WordNetLabel";
            this.WordNetLabel.Size = new System.Drawing.Size(50, 13);
            this.WordNetLabel.TabIndex = 9;
            this.WordNetLabel.Text = "WordNet";
            this.WordNetLabel.Click += new System.EventHandler(this.WordNetLabel_Click);
            this.WordNetLabel.MouseLeave += new System.EventHandler(this.WordNetLabel_MouseLeave);
            this.WordNetLabel.MouseHover += new System.EventHandler(this.WordNetLabel_MouseHover);
            // 
            // MicroLabel
            // 
            this.MicroLabel.AutoSize = true;
            this.MicroLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.MicroLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MicroLabel.Location = new System.Drawing.Point(342, 208);
            this.MicroLabel.Name = "MicroLabel";
            this.MicroLabel.Size = new System.Drawing.Size(66, 26);
            this.MicroLabel.TabIndex = 10;
            this.MicroLabel.Text = "Microsoft\r\nRecognizers";
            this.MicroLabel.Click += new System.EventHandler(this.MicroLabel_Click);
            this.MicroLabel.MouseLeave += new System.EventHandler(this.MicroLabel_MouseLeave);
            this.MicroLabel.MouseHover += new System.EventHandler(this.MicroLabel_MouseHover);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(514, 352);
            this.Controls.Add(this.MicroLabel);
            this.Controls.Add(this.WordNetLabel);
            this.Controls.Add(this.OpenNLPLabel);
            this.Controls.Add(this.CoreNLPLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MicroButton);
            this.Controls.Add(this.WordNetButton);
            this.Controls.Add(this.OpenNLPButton);
            this.Controls.Add(this.CoreNLPButton);
            this.Controls.Add(this.CrossSign);
            this.Controls.Add(this.TopBar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstForm";
            this.Text = "My";
            this.Load += new System.EventHandler(this.FirstForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoreNLPButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenNLPButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WordNetButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MicroButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TopBar;
        private System.Windows.Forms.PictureBox CrossSign;
        private System.Windows.Forms.PictureBox CoreNLPButton;
        private System.Windows.Forms.PictureBox OpenNLPButton;
        private System.Windows.Forms.PictureBox WordNetButton;
        private System.Windows.Forms.PictureBox MicroButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CoreNLPLabel;
        private System.Windows.Forms.Label OpenNLPLabel;
        private System.Windows.Forms.Label WordNetLabel;
        private System.Windows.Forms.Label MicroLabel;
    }
}

