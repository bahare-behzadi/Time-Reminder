using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Reminder
{
    internal class FileManager
    {
        private const string numberOfFileVersion = "To_Do_Reminder_1";
        private const double version = 1;
        // Writes task data to a file
        public bool WriteDataToFile(List<Tasks> tasks, string fileName)
        {
            bool result = true;
           StreamWriter streamWriter = null;
            try
            {
                // Open a StreamWriter to the specified file
                streamWriter = new StreamWriter(fileName);

                // Write file version and task count
                streamWriter.WriteLine(numberOfFileVersion);
                streamWriter.WriteLine(version);
                streamWriter.WriteLine(tasks.Count);

                // Loop through tasks and write details to the file
                for ( int i = 0; i<tasks.Count; i++)
                {
                    streamWriter.WriteLine(tasks[i].Description);
                    streamWriter.WriteLine(tasks[i].Priority);
                    streamWriter.WriteLine(tasks[i].DateAndTime.Year);
                    streamWriter.WriteLine(tasks[i].DateAndTime.Month);
                    streamWriter.WriteLine(tasks[i].DateAndTime.Day);
                    streamWriter.WriteLine(tasks[i].DateAndTime.Hour);
                    streamWriter.WriteLine(tasks[i].DateAndTime.Minute);
                }
            }
            catch 
            {
                result = false;// An error occurred during writing
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();// Close the StreamWriter in a finally block to ensure it gets closed
                }
            }
            return result;
        }
        // Reads task data from a file
        public bool ReadTasksListsFromFile(List<Tasks> tasks, string fileName)
        {
            bool result = true;
            StreamReader streamReader = null;
            try
            {
                if (tasks.Count >= 0)
                    tasks.Clear();// Clear existing tasks or create a new list
                else
                    tasks = new List<Tasks>();

                // Open a StreamReader to the specified file
                streamReader = new StreamReader(fileName);

                // Read and validate file version
                string versionTestName = streamReader.ReadLine();
                double versiontest = double.Parse(streamReader.ReadLine());

                if (versionTestName == numberOfFileVersion && versiontest == version)
                {
                    // Read the number of lines/tasks in the file
                    int numberOfLines = int.Parse(streamReader.ReadLine());

                    // Loop through lines/tasks and create Tasks objects
                    for (int i = 0; i < numberOfLines; i++)
                    {
                        Tasks task = new Tasks();
                        task.Description = streamReader.ReadLine();
                        task.Priority = (PriorityType)Enum.Parse(typeof(PriorityType), streamReader.ReadLine());
                        int year = int.Parse(streamReader.ReadLine());
                        int month = int.Parse(streamReader.ReadLine());
                        int day = int.Parse(streamReader.ReadLine());
                        int hour = int.Parse(streamReader.ReadLine());
                        int minute = int.Parse(streamReader.ReadLine());


                        // Set the DateTime for the task
                        task.DateAndTime = new DateTime(year, month, day, hour, minute, 0);
                        tasks.Add(task);

                        
                    }
                }
                else
                    result = false;

            }
            catch // An error occurred during reading
            { result = false; }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();// Close the StreamReader in a finally block to ensure it gets closed
                }
            }
            return result; 
        }
        
    }
}
