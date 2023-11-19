namespace ToDo_Reminder
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newCrToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveDataFileToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitAltF4ToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            DateTimeLabel = new Label();
            dateTimePicker = new DateTimePicker();
            periorityLabel = new Label();
            periorityComboBox = new ComboBox();
            toDolabel = new Label();
            toDoRichTextBox1 = new RichTextBox();
            AddButton = new Button();
            toDoGroupBox = new GroupBox();
            listBoxOfTasks = new ListBox();
            descriptionLabel = new Label();
            PeriorityShowLabel = new Label();
            hourShowLlabel = new Label();
            dateShowLabel = new Label();
            changeButton = new Button();
            deleteButton = new Button();
            timeLabel = new Label();
            clockTimer = new System.Windows.Forms.Timer(components);
            clockLabel = new Label();
            TimePickerToolTip = new ToolTip(components);
            menuStrip1.SuspendLayout();
            toDoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1509, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newCrToolStripMenuItem, toolStripSeparator1, openToolStripMenuItem, saveDataFileToolStripMenuItem, toolStripSeparator2, exitAltF4ToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // newCrToolStripMenuItem
            // 
            newCrToolStripMenuItem.Name = "newCrToolStripMenuItem";
            newCrToolStripMenuItem.Size = new Size(304, 34);
            newCrToolStripMenuItem.Text = "New                 Ctrl + N";
            newCrToolStripMenuItem.Click += newCrToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(301, 6);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(304, 34);
            openToolStripMenuItem.Text = "Open data file";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveDataFileToolStripMenuItem
            // 
            saveDataFileToolStripMenuItem.Name = "saveDataFileToolStripMenuItem";
            saveDataFileToolStripMenuItem.Size = new Size(304, 34);
            saveDataFileToolStripMenuItem.Text = "Save data file";
            saveDataFileToolStripMenuItem.Click += saveDataFileToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(301, 6);
            // 
            // exitAltF4ToolStripMenuItem
            // 
            exitAltF4ToolStripMenuItem.Name = "exitAltF4ToolStripMenuItem";
            exitAltF4ToolStripMenuItem.Size = new Size(304, 34);
            exitAltF4ToolStripMenuItem.Text = "Exit                      Alt+F4";
            exitAltF4ToolStripMenuItem.Click += exitAltF4ToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { helpToolStripMenuItem1, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(164, 34);
            helpToolStripMenuItem1.Text = "Help";
            helpToolStripMenuItem1.Click += helpToolStripMenuItem1_Click_1;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(164, 34);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click_1;
            // 
            // DateTimeLabel
            // 
            DateTimeLabel.AutoSize = true;
            DateTimeLabel.Location = new Point(23, 85);
            DateTimeLabel.Name = "DateTimeLabel";
            DateTimeLabel.Size = new Size(124, 25);
            DateTimeLabel.TabIndex = 1;
            DateTimeLabel.Text = "Date and time";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(194, 83);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(544, 31);
            dateTimePicker.TabIndex = 2;
            TimePickerToolTip.SetToolTip(dateTimePicker, "Click the clander for date and write time here.");
            // 
            // periorityLabel
            // 
            periorityLabel.AutoSize = true;
            periorityLabel.Location = new Point(873, 83);
            periorityLabel.Name = "periorityLabel";
            periorityLabel.Size = new Size(76, 25);
            periorityLabel.TabIndex = 3;
            periorityLabel.Text = "Periority";
            // 
            // periorityComboBox
            // 
            periorityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            periorityComboBox.FormattingEnabled = true;
            periorityComboBox.Location = new Point(981, 82);
            periorityComboBox.Name = "periorityComboBox";
            periorityComboBox.Size = new Size(160, 33);
            periorityComboBox.TabIndex = 4;
            // 
            // toDolabel
            // 
            toDolabel.AutoSize = true;
            toDolabel.Location = new Point(80, 162);
            toDolabel.Name = "toDolabel";
            toDolabel.Size = new Size(57, 25);
            toDolabel.TabIndex = 5;
            toDolabel.Text = "To do";
            // 
            // toDoRichTextBox1
            // 
            toDoRichTextBox1.Location = new Point(194, 148);
            toDoRichTextBox1.Name = "toDoRichTextBox1";
            toDoRichTextBox1.Size = new Size(948, 56);
            toDoRichTextBox1.TabIndex = 6;
            toDoRichTextBox1.Text = "";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(1183, 148);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(274, 38);
            AddButton.TabIndex = 7;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click_1;
            // 
            // toDoGroupBox
            // 
            toDoGroupBox.Controls.Add(listBoxOfTasks);
            toDoGroupBox.Controls.Add(descriptionLabel);
            toDoGroupBox.Controls.Add(PeriorityShowLabel);
            toDoGroupBox.Controls.Add(hourShowLlabel);
            toDoGroupBox.Controls.Add(dateShowLabel);
            toDoGroupBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            toDoGroupBox.ForeColor = Color.Green;
            toDoGroupBox.Location = new Point(61, 230);
            toDoGroupBox.Name = "toDoGroupBox";
            toDoGroupBox.Size = new Size(1409, 371);
            toDoGroupBox.TabIndex = 8;
            toDoGroupBox.TabStop = false;
            toDoGroupBox.Text = "To do";
            // 
            // listBoxOfTasks
            // 
            listBoxOfTasks.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxOfTasks.FormattingEnabled = true;
            listBoxOfTasks.ItemHeight = 22;
            listBoxOfTasks.Location = new Point(40, 58);
            listBoxOfTasks.Name = "listBoxOfTasks";
            listBoxOfTasks.Size = new Size(1337, 268);
            listBoxOfTasks.TabIndex = 4;
            listBoxOfTasks.SelectedIndexChanged += listBoxOfTasks_SelectedIndexChanged;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            descriptionLabel.ForeColor = SystemColors.ActiveCaptionText;
            descriptionLabel.Location = new Point(858, 30);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(108, 25);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description";
            // 
            // PeriorityShowLabel
            // 
            PeriorityShowLabel.AutoSize = true;
            PeriorityShowLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PeriorityShowLabel.ForeColor = SystemColors.ActiveCaptionText;
            PeriorityShowLabel.Location = new Point(574, 30);
            PeriorityShowLabel.Name = "PeriorityShowLabel";
            PeriorityShowLabel.Size = new Size(83, 25);
            PeriorityShowLabel.TabIndex = 2;
            PeriorityShowLabel.Text = "Periority";
            // 
            // hourShowLlabel
            // 
            hourShowLlabel.AutoSize = true;
            hourShowLlabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            hourShowLlabel.ForeColor = SystemColors.ActiveCaptionText;
            hourShowLlabel.Location = new Point(417, 30);
            hourShowLlabel.Name = "hourShowLlabel";
            hourShowLlabel.Size = new Size(54, 25);
            hourShowLlabel.TabIndex = 1;
            hourShowLlabel.Text = "Hour";
            // 
            // dateShowLabel
            // 
            dateShowLabel.AutoSize = true;
            dateShowLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateShowLabel.ForeColor = SystemColors.ActiveCaptionText;
            dateShowLabel.Location = new Point(97, 30);
            dateShowLabel.Name = "dateShowLabel";
            dateShowLabel.Size = new Size(56, 25);
            dateShowLabel.TabIndex = 0;
            dateShowLabel.Text = "Date ";
            // 
            // changeButton
            // 
            changeButton.Location = new Point(174, 632);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(211, 46);
            changeButton.TabIndex = 9;
            changeButton.Text = "Change";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += changeButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(468, 632);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(211, 46);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "Delet";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            timeLabel.ForeColor = SystemColors.HotTrack;
            timeLabel.Location = new Point(1309, 678);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(0, 36);
            timeLabel.TabIndex = 11;
            // 
            // clockTimer
            // 
            clockTimer.Enabled = true;
            clockTimer.Interval = 1000;
            clockTimer.Tick += clockTimer_Tick;
            // 
            // clockLabel
            // 
            clockLabel.AutoSize = true;
            clockLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clockLabel.ForeColor = SystemColors.HotTrack;
            clockLabel.Location = new Point(1202, 632);
            clockLabel.Name = "clockLabel";
            clockLabel.Size = new Size(65, 25);
            clockLabel.TabIndex = 12;
            clockLabel.Text = "label1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1509, 732);
            Controls.Add(clockLabel);
            Controls.Add(timeLabel);
            Controls.Add(deleteButton);
            Controls.Add(changeButton);
            Controls.Add(toDoGroupBox);
            Controls.Add(AddButton);
            Controls.Add(toDoRichTextBox1);
            Controls.Add(toDolabel);
            Controls.Add(periorityComboBox);
            Controls.Add(periorityLabel);
            Controls.Add(dateTimePicker);
            Controls.Add(DateTimeLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toDoGroupBox.ResumeLayout(false);
            toDoGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem newCrToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveDataFileToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitAltF4ToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label DateTimeLabel;
        private DateTimePicker dateTimePicker;
        private Label periorityLabel;
        private ComboBox periorityComboBox;
        private Label toDolabel;
        private RichTextBox toDoRichTextBox1;
        private Button AddButton;
        private GroupBox toDoGroupBox;
        private Label PeriorityShowLabel;
        private Label hourShowLlabel;
        private Label dateShowLabel;
        private ListBox listBoxOfTasks;
        private Label descriptionLabel;
        private Button changeButton;
        private Button deleteButton;
        private Label timeLabel;
        private System.Windows.Forms.Timer clockTimer;
        private Label clockLabel;
        private ToolTip TimePickerToolTip;
    }
}