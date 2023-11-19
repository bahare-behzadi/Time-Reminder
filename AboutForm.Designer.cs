namespace ToDo_Reminder
{
    partial class AboutForm
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
            pictureBox1 = new PictureBox();
            aboutInfoRichTextBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(575, 398);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // aboutInfoRichTextBox
            // 
            aboutInfoRichTextBox.BackColor = SystemColors.ButtonFace;
            aboutInfoRichTextBox.Enabled = false;
            aboutInfoRichTextBox.Font = new Font("Ravie", 9F, FontStyle.Regular, GraphicsUnit.Point);
            aboutInfoRichTextBox.ForeColor = SystemColors.MenuText;
            aboutInfoRichTextBox.Location = new Point(579, 12);
            aboutInfoRichTextBox.Name = "aboutInfoRichTextBox";
            aboutInfoRichTextBox.ReadOnly = true;
            aboutInfoRichTextBox.ScrollBars = RichTextBoxScrollBars.None;
            aboutInfoRichTextBox.Size = new Size(301, 367);
            aboutInfoRichTextBox.TabIndex = 1;
            aboutInfoRichTextBox.Text = "\n\n\nToDo Reminder\n\nVersion:\n 1.0.0\n\nAuthor: \nBahareh Behzadi";
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 391);
            Controls.Add(aboutInfoRichTextBox);
            Controls.Add(pictureBox1);
            Name = "AboutForm";
            Text = "AboutForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox aboutInfoRichTextBox;
        private PictureBox pictureBox1;

    }
}