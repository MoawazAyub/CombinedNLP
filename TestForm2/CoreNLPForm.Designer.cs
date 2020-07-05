namespace TestForm2
{
    partial class CoreNLPForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoreNLPForm));
            this.TopBar = new System.Windows.Forms.PictureBox();
            this.Cross = new System.Windows.Forms.PictureBox();
            this.Heading = new System.Windows.Forms.Label();
            this.InputText = new System.Windows.Forms.TextBox();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OutputType = new System.Windows.Forms.ComboBox();
            this.OutputButton = new System.Windows.Forms.Button();
            this.FormatLabel = new System.Windows.Forms.Label();
            this.FileInput = new System.Windows.Forms.Button();
            this.SaveToFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cross)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopBar.BackgroundImage")));
            this.TopBar.Location = new System.Drawing.Point(-2, -2);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(729, 35);
            this.TopBar.TabIndex = 0;
            this.TopBar.TabStop = false;
            this.TopBar.Click += new System.EventHandler(this.TopBar_Click);
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            // 
            // Cross
            // 
            this.Cross.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cross.BackgroundImage")));
            this.Cross.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cross.Location = new System.Drawing.Point(689, -2);
            this.Cross.Name = "Cross";
            this.Cross.Size = new System.Drawing.Size(38, 35);
            this.Cross.TabIndex = 1;
            this.Cross.TabStop = false;
            this.Cross.Click += new System.EventHandler(this.Cross_Click);
            this.Cross.MouseLeave += new System.EventHandler(this.Cross_MouseLeave);
            this.Cross.MouseHover += new System.EventHandler(this.Cross_MouseHover);
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Heading.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(165, -2);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(107, 33);
            this.Heading.TabIndex = 2;
            this.Heading.Text = "CoreNLP";
            this.Heading.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Heading_MouseDown);
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(30, 72);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(445, 42);
            this.InputText.TabIndex = 3;
            this.InputText.TextChanged += new System.EventHandler(this.InputText_TextChanged);
            // 
            // OutputText
            // 
            this.OutputText.BackColor = System.Drawing.SystemColors.Info;
            this.OutputText.ForeColor = System.Drawing.SystemColors.InfoText;
            this.OutputText.Location = new System.Drawing.Point(30, 181);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.ReadOnly = true;
            this.OutputText.Size = new System.Drawing.Size(665, 167);
            this.OutputText.TabIndex = 4;
            this.OutputText.TextChanged += new System.EventHandler(this.OutputText_TextChanged);
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.Location = new System.Drawing.Point(121, 54);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(39, 15);
            this.InputLabel.TabIndex = 5;
            this.InputLabel.Text = "Input";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(168, 163);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(173, 15);
            this.OutputLabel.TabIndex = 6;
            this.OutputLabel.Text = "Output will be shown here";
            // 
            // OutputType
            // 
            this.OutputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OutputType.FormattingEnabled = true;
            this.OutputType.Location = new System.Drawing.Point(522, 72);
            this.OutputType.Name = "OutputType";
            this.OutputType.Size = new System.Drawing.Size(173, 21);
            this.OutputType.TabIndex = 7;
            this.OutputType.SelectedIndexChanged += new System.EventHandler(this.OutputType_SelectedIndexChanged);
            // 
            // OutputButton
            // 
            this.OutputButton.BackColor = System.Drawing.Color.Red;
            this.OutputButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OutputButton.Location = new System.Drawing.Point(30, 120);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(168, 38);
            this.OutputButton.TabIndex = 8;
            this.OutputButton.Text = "Generate Output";
            this.OutputButton.UseVisualStyleBackColor = false;
            this.OutputButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormatLabel
            // 
            this.FormatLabel.AutoSize = true;
            this.FormatLabel.BackColor = System.Drawing.Color.Transparent;
            this.FormatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormatLabel.Location = new System.Drawing.Point(519, 56);
            this.FormatLabel.Name = "FormatLabel";
            this.FormatLabel.Size = new System.Drawing.Size(52, 15);
            this.FormatLabel.TabIndex = 9;
            this.FormatLabel.Text = "Format";
            // 
            // FileInput
            // 
            this.FileInput.BackColor = System.Drawing.Color.Red;
            this.FileInput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FileInput.Location = new System.Drawing.Point(224, 122);
            this.FileInput.Name = "FileInput";
            this.FileInput.Size = new System.Drawing.Size(169, 36);
            this.FileInput.TabIndex = 10;
            this.FileInput.Text = "FileInput";
            this.FileInput.UseVisualStyleBackColor = false;
            this.FileInput.Click += new System.EventHandler(this.FileInput_Click);
            // 
            // SaveToFile
            // 
            this.SaveToFile.BackColor = System.Drawing.Color.Red;
            this.SaveToFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveToFile.Location = new System.Drawing.Point(30, 354);
            this.SaveToFile.Name = "SaveToFile";
            this.SaveToFile.Size = new System.Drawing.Size(168, 42);
            this.SaveToFile.TabIndex = 11;
            this.SaveToFile.Text = "Save Output to File";
            this.SaveToFile.UseVisualStyleBackColor = false;
            this.SaveToFile.Click += new System.EventHandler(this.SaveToFile_Click);
            // 
            // CoreNLPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(725, 405);
            this.Controls.Add(this.SaveToFile);
            this.Controls.Add(this.FileInput);
            this.Controls.Add(this.FormatLabel);
            this.Controls.Add(this.OutputButton);
            this.Controls.Add(this.OutputType);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.Cross);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CoreNLPForm";
            this.Text = "CoreNLPForm";
            this.Load += new System.EventHandler(this.CoreNLPForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cross)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TopBar;
        private System.Windows.Forms.PictureBox Cross;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.ComboBox OutputType;
        private System.Windows.Forms.Button OutputButton;
        private System.Windows.Forms.Label FormatLabel;
        private System.Windows.Forms.Button FileInput;
        private System.Windows.Forms.Button SaveToFile;
    }
}