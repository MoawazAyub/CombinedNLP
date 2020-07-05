namespace TestForm2
{
    partial class OpenNLPForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenNLPForm));
            this.TopBar = new System.Windows.Forms.PictureBox();
            this.CrossSign = new System.Windows.Forms.PictureBox();
            this.Heading = new System.Windows.Forms.Label();
            this.ToolField = new System.Windows.Forms.ComboBox();
            this.GenerateOutputButton = new System.Windows.Forms.Button();
            this.InputField = new System.Windows.Forms.TextBox();
            this.OutputField = new System.Windows.Forms.TextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.ToolLabel = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.InputFile = new System.Windows.Forms.Button();
            this.SaveToFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossSign)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopBar.BackgroundImage")));
            this.TopBar.Location = new System.Drawing.Point(-2, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(568, 35);
            this.TopBar.TabIndex = 0;
            this.TopBar.TabStop = false;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            // 
            // CrossSign
            // 
            this.CrossSign.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CrossSign.BackgroundImage")));
            this.CrossSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CrossSign.Location = new System.Drawing.Point(528, 0);
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
            this.Heading.Location = new System.Drawing.Point(142, 0);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(114, 33);
            this.Heading.TabIndex = 2;
            this.Heading.Text = "OpenNLP";
            this.Heading.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Heading_MouseDown);
            // 
            // ToolField
            // 
            this.ToolField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToolField.FormattingEnabled = true;
            this.ToolField.Location = new System.Drawing.Point(382, 82);
            this.ToolField.Name = "ToolField";
            this.ToolField.Size = new System.Drawing.Size(172, 21);
            this.ToolField.TabIndex = 5;
            // 
            // GenerateOutputButton
            // 
            this.GenerateOutputButton.BackColor = System.Drawing.Color.Red;
            this.GenerateOutputButton.ForeColor = System.Drawing.SystemColors.Control;
            this.GenerateOutputButton.Location = new System.Drawing.Point(12, 165);
            this.GenerateOutputButton.Name = "GenerateOutputButton";
            this.GenerateOutputButton.Size = new System.Drawing.Size(154, 44);
            this.GenerateOutputButton.TabIndex = 6;
            this.GenerateOutputButton.Text = "Generate Output";
            this.GenerateOutputButton.UseVisualStyleBackColor = false;
            this.GenerateOutputButton.Click += new System.EventHandler(this.GenerateOutputButton_Click);
            // 
            // InputField
            // 
            this.InputField.Location = new System.Drawing.Point(12, 82);
            this.InputField.Multiline = true;
            this.InputField.Name = "InputField";
            this.InputField.Size = new System.Drawing.Size(364, 67);
            this.InputField.TabIndex = 7;
            // 
            // OutputField
            // 
            this.OutputField.Location = new System.Drawing.Point(12, 247);
            this.OutputField.Multiline = true;
            this.OutputField.Name = "OutputField";
            this.OutputField.Size = new System.Drawing.Size(542, 78);
            this.OutputField.TabIndex = 8;
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.BackColor = System.Drawing.Color.Transparent;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.Location = new System.Drawing.Point(13, 63);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(39, 15);
            this.InputLabel.TabIndex = 9;
            this.InputLabel.Text = "Input";
            // 
            // ToolLabel
            // 
            this.ToolLabel.AutoSize = true;
            this.ToolLabel.BackColor = System.Drawing.Color.Transparent;
            this.ToolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolLabel.Location = new System.Drawing.Point(379, 63);
            this.ToolLabel.Name = "ToolLabel";
            this.ToolLabel.Size = new System.Drawing.Size(35, 15);
            this.ToolLabel.TabIndex = 10;
            this.ToolLabel.Text = "Tool";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(12, 228);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(49, 15);
            this.OutputLabel.TabIndex = 11;
            this.OutputLabel.Text = "Output";
            // 
            // InputFile
            // 
            this.InputFile.BackColor = System.Drawing.Color.Red;
            this.InputFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InputFile.Location = new System.Drawing.Point(198, 165);
            this.InputFile.Name = "InputFile";
            this.InputFile.Size = new System.Drawing.Size(145, 44);
            this.InputFile.TabIndex = 12;
            this.InputFile.Text = "Input File";
            this.InputFile.UseVisualStyleBackColor = false;
            this.InputFile.Click += new System.EventHandler(this.InputFile_Click);
            // 
            // SaveToFile
            // 
            this.SaveToFile.BackColor = System.Drawing.Color.Red;
            this.SaveToFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveToFile.Location = new System.Drawing.Point(16, 332);
            this.SaveToFile.Name = "SaveToFile";
            this.SaveToFile.Size = new System.Drawing.Size(150, 44);
            this.SaveToFile.TabIndex = 13;
            this.SaveToFile.Text = "Save Output To File";
            this.SaveToFile.UseVisualStyleBackColor = false;
            this.SaveToFile.Click += new System.EventHandler(this.SaveToFile_Click);
            // 
            // OpenNLPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(565, 388);
            this.Controls.Add(this.SaveToFile);
            this.Controls.Add(this.InputFile);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.ToolLabel);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.OutputField);
            this.Controls.Add(this.InputField);
            this.Controls.Add(this.GenerateOutputButton);
            this.Controls.Add(this.ToolField);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.CrossSign);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpenNLPForm";
            this.Text = "OpenNLPForm";
            this.Load += new System.EventHandler(this.OpenNLPForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossSign)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TopBar;
        private System.Windows.Forms.PictureBox CrossSign;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.ComboBox ToolField;
        private System.Windows.Forms.Button GenerateOutputButton;
        private System.Windows.Forms.TextBox InputField;
        private System.Windows.Forms.TextBox OutputField;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label ToolLabel;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button InputFile;
        private System.Windows.Forms.Button SaveToFile;
    }
}