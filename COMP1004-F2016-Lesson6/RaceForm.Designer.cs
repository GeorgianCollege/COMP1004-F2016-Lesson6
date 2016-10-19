namespace COMP1004_F2016_Lesson6
{
    partial class RaceForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.RaceListBox = new System.Windows.Forms.ListBox();
            this.RaceLabel = new System.Windows.Forms.Label();
            this.RaceSelectedLabel = new System.Windows.Forms.Label();
            this.RaceSelectedTextBox = new System.Windows.Forms.TextBox();
            this.RacePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RacePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 266);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(228, 44);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(261, 266);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(228, 44);
            this.NextButton.TabIndex = 15;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // RaceListBox
            // 
            this.RaceListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RaceListBox.FormattingEnabled = true;
            this.RaceListBox.ItemHeight = 32;
            this.RaceListBox.Items.AddRange(new object[] {
            "Dragon Born",
            "Dwarf",
            "Elf",
            "Half Elf",
            "Half Ogre",
            "Half Orc",
            "Halfling",
            "Human",
            "Tiefling"});
            this.RaceListBox.Location = new System.Drawing.Point(12, 82);
            this.RaceListBox.Name = "RaceListBox";
            this.RaceListBox.Size = new System.Drawing.Size(227, 130);
            this.RaceListBox.Sorted = true;
            this.RaceListBox.TabIndex = 16;
            this.RaceListBox.SelectedIndexChanged += new System.EventHandler(this.RaceListBox_SelectedIndexChanged);
            // 
            // RaceLabel
            // 
            this.RaceLabel.AutoSize = true;
            this.RaceLabel.Location = new System.Drawing.Point(12, 32);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(213, 32);
            this.RaceLabel.TabIndex = 17;
            this.RaceLabel.Text = "Pick Your Race";
            // 
            // RaceSelectedLabel
            // 
            this.RaceSelectedLabel.AutoSize = true;
            this.RaceSelectedLabel.Location = new System.Drawing.Point(275, 114);
            this.RaceSelectedLabel.Name = "RaceSelectedLabel";
            this.RaceSelectedLabel.Size = new System.Drawing.Size(194, 32);
            this.RaceSelectedLabel.TabIndex = 18;
            this.RaceSelectedLabel.Text = "Race Selected";
            // 
            // RaceSelectedTextBox
            // 
            this.RaceSelectedTextBox.Location = new System.Drawing.Point(281, 164);
            this.RaceSelectedTextBox.Name = "RaceSelectedTextBox";
            this.RaceSelectedTextBox.Size = new System.Drawing.Size(192, 39);
            this.RaceSelectedTextBox.TabIndex = 19;
            // 
            // RacePictureBox
            // 
            this.RacePictureBox.Location = new System.Drawing.Point(261, 12);
            this.RacePictureBox.Name = "RacePictureBox";
            this.RacePictureBox.Size = new System.Drawing.Size(228, 239);
            this.RacePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RacePictureBox.TabIndex = 20;
            this.RacePictureBox.TabStop = false;
            // 
            // RaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 322);
            this.Controls.Add(this.RaceSelectedTextBox);
            this.Controls.Add(this.RaceSelectedLabel);
            this.Controls.Add(this.RaceLabel);
            this.Controls.Add(this.RaceListBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RacePictureBox);
            this.Font = new System.Drawing.Font("Lucida Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "RaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Race Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RaceForm_FormClosing);
            this.Load += new System.EventHandler(this.RaceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RacePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.ListBox RaceListBox;
        private System.Windows.Forms.Label RaceLabel;
        private System.Windows.Forms.Label RaceSelectedLabel;
        private System.Windows.Forms.TextBox RaceSelectedTextBox;
        private System.Windows.Forms.PictureBox RacePictureBox;
    }
}