namespace TestForm2
{
    partial class WordNetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordNetForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopBar = new System.Windows.Forms.PictureBox();
            this.CrossButton = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.GenerateOutputButton = new System.Windows.Forms.Button();
            this.Heading = new System.Windows.Forms.Label();
            this.SaveToFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopBar.BackgroundImage")));
            this.TopBar.Location = new System.Drawing.Point(-3, -2);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(761, 35);
            this.TopBar.TabIndex = 0;
            this.TopBar.TabStop = false;
            this.TopBar.Click += new System.EventHandler(this.TopBar_Click);
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            // 
            // CrossButton
            // 
            this.CrossButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CrossButton.BackgroundImage")));
            this.CrossButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CrossButton.Location = new System.Drawing.Point(720, -2);
            this.CrossButton.Name = "CrossButton";
            this.CrossButton.Size = new System.Drawing.Size(38, 35);
            this.CrossButton.TabIndex = 1;
            this.CrossButton.TabStop = false;
            this.CrossButton.Click += new System.EventHandler(this.CrossButton_Click);
            this.CrossButton.MouseLeave += new System.EventHandler(this.CrossButton_MouseLeave);
            this.CrossButton.MouseHover += new System.EventHandler(this.CrossButton_MouseHover);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.BackColor = System.Drawing.Color.Transparent;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InputLabel.Location = new System.Drawing.Point(110, 55);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(78, 15);
            this.InputLabel.TabIndex = 3;
            this.InputLabel.Text = "Enter Word";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.Location = new System.Drawing.Point(30, 188);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv.Size = new System.Drawing.Size(695, 400);
            this.dgv.TabIndex = 4;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GenerateOutputButton
            // 
            this.GenerateOutputButton.BackColor = System.Drawing.Color.Red;
            this.GenerateOutputButton.Location = new System.Drawing.Point(113, 108);
            this.GenerateOutputButton.Name = "GenerateOutputButton";
            this.GenerateOutputButton.Size = new System.Drawing.Size(160, 32);
            this.GenerateOutputButton.TabIndex = 5;
            this.GenerateOutputButton.Text = "Generate Output";
            this.GenerateOutputButton.UseVisualStyleBackColor = false;
            this.GenerateOutputButton.Click += new System.EventHandler(this.GenerateOutputButton_Click);
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.BackColor = System.Drawing.SystemColors.Highlight;
            this.Heading.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Heading.Location = new System.Drawing.Point(216, -2);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(107, 33);
            this.Heading.TabIndex = 6;
            this.Heading.Text = "WordNet";
            this.Heading.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Heading_MouseDown);
            // 
            // SaveToFile
            // 
            this.SaveToFile.BackColor = System.Drawing.Color.Red;
            this.SaveToFile.Location = new System.Drawing.Point(558, 145);
            this.SaveToFile.Name = "SaveToFile";
            this.SaveToFile.Size = new System.Drawing.Size(167, 32);
            this.SaveToFile.TabIndex = 7;
            this.SaveToFile.Text = "Save Output To File";
            this.SaveToFile.UseVisualStyleBackColor = false;
            this.SaveToFile.Click += new System.EventHandler(this.SaveToFile_Click);
            // 
            // WordNetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(757, 600);
            this.Controls.Add(this.SaveToFile);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.GenerateOutputButton);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CrossButton);
            this.Controls.Add(this.TopBar);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WordNetForm";
            this.Text = "WordNetForm";
            this.Load += new System.EventHandler(this.WordNetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TopBar;
        private System.Windows.Forms.PictureBox CrossButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button GenerateOutputButton;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Button SaveToFile;
    }
}