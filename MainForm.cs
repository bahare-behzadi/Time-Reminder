using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;

namespace ToDo_Reminder
{
    public partial class MainForm : Form
    {
        TaskManager taskManager;
        private string fileName = Application.StartupPath + "\\Tasks.txt";
        // Constructor for the MainForm
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        // Initializes the GUI components and sets default values
        private void InitializeGUI()
        {
            this.Text = "To do reminder by Bahareh Behzadi";
            taskManager = new TaskManager();
            periorityComboBox.Items.Clear();
            periorityComboBox.Items.AddRange(Enum.GetNames(typeof(PriorityType)));
            periorityComboBox.SelectedItem = PriorityType.Normal;
            listBoxOfTasks.Items.Clear();
            timeLabel.Text = string.Empty;
            //ClockTimer.Start();
            toDoRichTextBox1.Text = string.Empty;
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd     HH:mm";
            deleteButton.Enabled = false;
            changeButton.Enabled = false;
            AddButton.Enabled = true;

        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }
        private Tasks ReadInput()
        {
            Tasks task = new Tasks();
            if (IsNullOrEmpty(toDoRichTextBox1.Text))
            {
                MessageBox.Show("You forgot to enter the description of date!", "Hello, ...");
                return null;
            }
            task.Description = toDoRichTextBox1.Text;
            task.DateAndTime = dateTimePicker.Value;
            if (periorityComboBox.SelectedItem != null)
            {
                if (Enum.TryParse(typeof(PriorityType), periorityComboBox.SelectedItem.ToString(), out object parsedPriority))
                {
                    task.Priority = (PriorityType)parsedPriority;
                }
                else
                {
                    MessageBox.Show("Invalid priority selected.", "Error");
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Please select a priority.", "Error");
                return null;
            }
            return task;

        }
        private void UpdateGUI()
        {
            toDoRichTextBox1.Text = string.Empty;
            periorityComboBox.SelectedIndex = -1;
            listBoxOfTasks.Items.Clear();
            string[] infotrings = taskManager.GetInfoToString();
            if (infotrings != null)
            {
                listBoxOfTasks.Items.AddRange(infotrings);
            }
            deleteButton.Enabled = false;
            changeButton.Enabled = false;
            AddButton.Enabled = true;
        }
        private bool IsNullOrEmpty(string text)
        {
            if (text == null || text == string.Empty)
                return true;
            return false;
        }
        // Event handler for the exit menu item
        private void exitAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Asks the user if they are sure they want to exit
            DialogResult result = MessageBox.Show("Are you sure you want to exit ToDo Reminder?",
                "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        // Event handler for the about menu item
        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Opens the AboutForm when the About menu item is clicked
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
        // Event handler for the help menu item
        private void helpToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            // Displays a help message to the user
            MessageBox.Show("Welcome to ToDo Reminder!\n\n" +
                    "This application helps you organize your time by managing tasks and setting reminders.\n" +
                    "To use:\n" +
                    "- Add new tasks with specific dates and priorities.\n" +
                    "- Edit or remove tasks as needed.\n" +
                    "- Stay organized and on top of your schedule!\n\n" +
                    "Enjoy using ToDo Reminder!", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Event handler for the new menu item
        private void newCrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGUI();// Initializes the GUI for a new session
        }
        // Event handler for the open menu item
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ok = taskManager.ReadDataFromFile(fileName);// Reads data from a file and updates the GUI
            if (!ok)
            {
                MessageBox.Show("Something is wrong with the file", "Error");
            }
            UpdateGUI();
        }
        // Event handler for the save menu item
        private void saveDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ok = taskManager.WriteDataToFile(fileName);// Writes data to a file and displays a message to the user
            if (!ok)
                MessageBox.Show("Something is wrong when saving the file", "Error");
            else
                MessageBox.Show($"Data is saved to file:\n{fileName}");
        }
        // Event handler for the change button click event
        private void changeButton_Click(object sender, EventArgs e)
        {
            // Changes a task based on user input and updates the GUI
            int index = listBoxOfTasks.SelectedIndex;
            if (index >= 0)
            {
                Tasks task = ReadInput();
                bool ok = taskManager.ChangeTask(task, index);
                if (ok)
                {
                    UpdateGUI();
                }
            }
            else
            {
                MessageBox.Show("Please select a task to change!!!");
            }
        }
        // Event handler for the AddButton click event
        private void AddButton_Click_1(object sender, EventArgs e)
        {
            // Adds a new task based on user input and updates the GUI
            Tasks task = ReadInput();
            if (taskManager.AddNewTask(task))
            {
                UpdateGUI();
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        // Event handler for the clock timer tick event
        private void clockTimer_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToLongTimeString();// Updates the clock label with the current time
        }
        // Event handler for the listBoxOfTasks selected index changed event
        private void listBoxOfTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Event handler for the listBoxOfTasks selected index changed event
            int index = (int)listBoxOfTasks.SelectedIndex;
            Tasks task = taskManager.GetTask(index);
            changeButton.Enabled = true;
            deleteButton.Enabled = true;
            AddButton.Enabled = false;
            toDoRichTextBox1.Text = task.Description;
            dateTimePicker.Value = task.DateAndTime;
            foreach (var item in periorityComboBox.Items)
            {
                if (item.ToString() == task.Priority.ToString())
                {
                    periorityComboBox.SelectedItem = item;
                    break;
                }
            }
        }
        // Event handler for the removing selected item in the list box
        private void deleteButton_Click(object sender, EventArgs e)
        {
            int index = listBoxOfTasks.SelectedIndex;  
            if (index >= 0)
            {
                bool ok = taskManager.RemoveATask(index);
                if (ok)
                {
                    UpdateGUI();
                }
            }
            else
            {
                MessageBox.Show("Please select a task to change!!!");
            }
        }
    }

}