using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Reminder
{
    internal class TaskManager
    {
        List <Tasks> taskslist;
        // Constructor for TaskManager
        #region CUNSTRUCTOR
        public TaskManager()
        {  taskslist = new List <Tasks>(); }
        #endregion
        // Retrieves a task at the specified index
        public Tasks GetTask(int index)
        {
            if (CheckIndex(index))
                return taskslist[index];
            else
                return null;
        }
        // Checks if the given index is within the valid range
        private bool CheckIndex(int index)
        {
            if(index<0 ||  index>=taskslist.Count)
                return false;
            return true;
        }
        // Adds a new task to the task list
        public bool AddNewTask(Tasks newTask)
        {
            bool ok=true;
            if (newTask != null)
            {
                taskslist.Add(newTask);
            }
            else 
                ok = false;
            return ok;
        }
        // Adds a new task to the task list
        public bool AddNewTask(DateTime newTime, string description, PriorityType priority)
        {
            if (!string.IsNullOrEmpty(description))
            {
                Tasks newTask = new Tasks(newTime, description, priority);
                taskslist.Add(newTask);
                return true;
            }
            return false;
        }

        // Changes an existing task at the specified index
        public bool ChangeTask(Tasks newTask, int index)
        {
            if (newTask != null && CheckIndex(index))
            {
                taskslist[index] = newTask;
                return true;
            }
            return false;
        }
        // Removes a task at the specified index
        public bool RemoveATask(int index)
        {
            if (CheckIndex(index))
            { 
                taskslist.RemoveAt(index);
                return true;
            }
            return false;
        }
        // Converts task information to an array of strings
        public string[] GetInfoToString()
        {
            string[] infostrings = new string[taskslist.Count];
            for (int i= 0; i< infostrings.Length; i++)
            {
                infostrings[i] = taskslist[i].ToString();
            }
            return infostrings;
        }
        // Writes task data to a file
        public bool WriteDataToFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            return fileManager.WriteDataToFile(taskslist, fileName);
        }
        // Reads task data from a file
        public bool ReadDataFromFile(string fileName)
        {
            FileManager fileManager = new FileManager();            
            return fileManager.ReadTasksListsFromFile(taskslist, fileName);
        }

    }
}
