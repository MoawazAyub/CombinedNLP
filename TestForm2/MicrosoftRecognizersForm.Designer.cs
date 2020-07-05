namespace TestForm2
{
    partial class MicrosoftRecognizersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MicrosoftRecognizersForm));
            this.TopBar = new System.Windows.Forms.PictureBox();
            this.CrossSign = new System.Windows.Forms.PictureBox();
            this.Heading = new System.Windows.Forms.Label();
            this.InputField = new System.Windows.Forms.TextBox();
            this.LanguageField = new System.Windows.Forms.ComboBox();
            this.RecognizerField = new System.Windows.Forms.ComboBox();
            this.OutputButton = new System.Windows.Forms.Button();
            this.InputLabel = new System.Windows.Forms.Label();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.RecognizerLabel = new System.Windows.Forms.Label();
            this.InputFile = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SaveToFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossSign)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopBar.BackgroundImage")));
            this.TopBar.Location = new System.Drawing.Point(-1, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(563, 35);
            this.TopBar.TabIndex = 0;
            this.TopBar.TabStop = false;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            // 
            // CrossSign
            // 
            this.CrossSign.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CrossSign.BackgroundImage")));
            this.CrossSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CrossSign.Location = new System.Drawing.Point(524, 0);
            this.CrossSign.Name = "CrossSign";
            this.CrossSign.Size = new System.Drawing.Size(38, 35);
            this.CrossSign.TabIndex = 1;
            this.CrossSign.TabStop = false;
            this.CrossSign.Click += new System.EventHandler(this.CrossSign_Click);
            this.CrossSign.MouseLeave += new System.EventHandler(this.CrossSign_MouseLeave);
            this.CrossSign.MouseHover += new System.EventHandler(this.CrossSign_MouseHover);
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.BackColor = System.Drawing.SystemColors.Highlight;
            this.Heading.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(108, 0);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(230, 33);
            this.Heading.TabIndex = 2;
            this.Heading.Text = "Microsoft Recognizers";
            this.Heading.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Heading_MouseDown);
            // 
            // InputField
            // 
            this.InputField.Location = new System.Drawing.Point(12, 75);
            this.InputField.Multiline = true;
            this.InputField.Name = "InputField";
            this.InputField.Size = new System.Drawing.Size(234, 82);
            this.InputField.TabIndex = 3;
            // 
            // LanguageField
            // 
            this.LanguageField.FormattingEnabled = true;
            this.LanguageField.Location = new System.Drawing.Point(267, 74);
            this.LanguageField.Name = "LanguageField";
            this.LanguageField.Size = new System.Drawing.Size(121, 21);
            this.LanguageField.TabIndex = 4;
            // 
            // RecognizerField
            // 
            this.RecognizerField.FormattingEnabled = true;
            this.RecognizerField.Location = new System.Drawing.Point(398, 74);
            this.RecognizerField.Name = "RecognizerField";
            this.RecognizerField.Size = new System.Drawing.Size(152, 21);
            this.RecognizerField.TabIndex = 8;
            // 
            // OutputButton
            // 
            this.OutputButton.BackColor = System.Drawing.Color.Red;
            this.OutputButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OutputButton.Location = new System.Drawing.Point(12, 163);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(160, 39);
            this.OutputButton.TabIndex = 9;
            this.OutputButton.Text = "Generate Output";
            this.OutputButton.UseVisualStyleBackColor = false;
            this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.BackColor = System.Drawing.Color.Transparent;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.Location = new System.Drawing.Point(12, 59);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(39, 15);
            this.InputLabel.TabIndex = 11;
            this.InputLabel.Text = "Input";
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.BackColor = System.Drawing.Color.Transparent;
            this.LanguageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LanguageLabel.Location = new System.Drawing.Point(267, 56);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(71, 15);
            this.LanguageLabel.TabIndex = 12;
            this.LanguageLabel.Text = "Language";
            // 
            // RecognizerLabel
            // 
            this.RecognizerLabel.AutoSize = true;
            this.RecognizerLabel.BackColor = System.Drawing.Color.Transparent;
            this.RecognizerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecognizerLabel.Location = new System.Drawing.Point(398, 55);
            this.RecognizerLabel.Name = "RecognizerLabel";
            this.RecognizerLabel.Size = new System.Drawing.Size(80, 15);
            this.RecognizerLabel.TabIndex = 13;
            this.RecognizerLabel.Text = "Recognizer";
            // 
            // InputFile
            // 
            this.InputFile.BackColor = System.Drawing.Color.Red;
            this.InputFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InputFile.Location = new System.Drawing.Point(202, 163);
            this.InputFile.Name = "InputFile";
            this.InputFile.Size = new System.Drawing.Size(156, 39);
            this.InputFile.TabIndex = 18;
            this.InputFile.Text = "Input File";
            this.InputFile.UseVisualStyleBackColor = false;
            this.InputFile.Click += new System.EventHandler(this.InputFile_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(15, 208);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(536, 133);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // SaveToFile
            // 
            this.SaveToFile.BackColor = System.Drawing.Color.Red;
            this.SaveToFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveToFile.Location = new System.Drawing.Point(15, 348);
            this.SaveToFile.Name = "SaveToFile";
            this.SaveToFile.Size = new System.Drawing.Size(157, 40);
            this.SaveToFile.TabIndex = 20;
            this.SaveToFile.Text = "Save Output To File";
            this.SaveToFile.UseVisualStyleBackColor = false;
            this.SaveToFile.Click += new System.EventHandler(this.SaveToFile_Click);
            // 
            // MicrosoftRecognizersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(561, 393);
            this.Controls.Add(this.SaveToFile);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.InputFile);
            this.Controls.Add(this.RecognizerLabel);
            this.Controls.Add(this.LanguageLabel);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.OutputButton);
            this.Controls.Add(this.RecognizerField);
            this.Controls.Add(this.LanguageField);
            this.Controls.Add(this.InputField);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.CrossSign);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MicrosoftRecognizersForm";
            this.Text = "MicrosoftRecognizersForm";
            this.Load += new System.EventHandler(this.MicrosoftRecognizersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossSign)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TopBar;
        private System.Windows.Forms.PictureBox CrossSign;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.TextBox InputField;
        private System.Windows.Forms.ComboBox LanguageField;
        private System.Windows.Forms.ComboBox RecognizerField;
        private System.Windows.Forms.Button OutputButton;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.Label RecognizerLabel;
        private System.Windows.Forms.Button InputFile;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button SaveToFile;
    }
}