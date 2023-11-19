using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Reminder
{
    internal class Tasks
    {
        private DateTime date; // date and time of the task
        private string description; // the task explanation
        private PriorityType priority;

        #region CUNSTRUCTORS
        // Default constructor sets priority to Normal
        public Tasks()
        {
            priority = PriorityType.Normal;// setting the periority as normal
        }
        // Constructor with date parameter, sets description to empty and priority to Normal
        public Tasks(DateTime date) : this (date, string.Empty, PriorityType.Normal)
        { }
        // Constructor with date and description parameters, sets priority to Normal
        public Tasks(DateTime date, string description): this(date, description, PriorityType.Normal)
        { }
        // Full constructor with date, description, and priority parameters
        public Tasks(DateTime date, string description, PriorityType priority)
        {
            this.date = date;
            this.description = description;
            this.priority = priority;
        }
        #endregion
        #region PEROPERTIES
        // Property for getting and setting the DateAndTime
        public DateTime DateAndTime
        { 
            get { return date; }
            set { date = value; }
        }
        // Property for getting and setting the Priority
        public PriorityType Priority
        { get { return priority; } 
            set {  priority = value; }
        }
        // Property for getting and setting the Description
        public string Description
        {
            get { return description; }
            set
            {
               description = value; 
            }
        }
        #endregion
        #region OTHER METHODS
        // Private method to format the time as a string
        private string GetTimeString()
        {
            string time = string.Format("{0}:{1}", date.Hour.ToString("00"), date.Minute.ToString("00"));
            return time;
        }
        // Method to get the priority as a string, replacing underscores with spaces
        public string GetPriorityString()
        {
            string textOut = Enum.GetName(typeof(PriorityType), priority);
            textOut = textOut.Replace("_", " ");
            return textOut;
        }
        // Override ToString method to format the task information as a string
        public override string ToString()
        {
            string textOut = string.Format("{0,-30} {1,-10} {2,-18} {3}", date.ToLongDateString(), GetTimeString(), GetPriorityString(), description);
            return textOut;
        }
        #endregion
    }
}
