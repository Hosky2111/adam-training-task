using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamsToDoConsoleApplication
{
    public static class TaskFunctions
    {
        /// <summary>
        /// Function for creating a new task with user input for Title and Description, completion always set to false
        /// </summary>
        /// <param name="createTask"></param>
        public static void CreateTask(List<Task> taskCollection)
        {
            Console.WriteLine("\nType in the Title:\n");
            var inputTitle = Console.ReadLine();

            Console.WriteLine("Type in the Description:\n");
            var inputDescription = Console.ReadLine();

            var task = new Task(inputTitle, inputDescription, false);

            taskCollection.Add(task);
        }
        /// <summary>
        /// Function to Display all Tasks in a list
        /// </summary>
        /// <param name="taskCollection"></param>
        public static void ListTask(List<Task> taskCollection)
        {
            int k = 0;
            string incompleteTasks = "";
            string CompleteTasks = "";
            string addToString = "";
            foreach (Task i in taskCollection)
            {
                addToString = "";
                addToString += "\nTitle: " + taskCollection[k].mTitle + "\nDescription: " + taskCollection[k].mDescription + "\n";
                if (taskCollection[k].mCompletion == false)
                {
                    incompleteTasks += addToString;
                }
                if (taskCollection[k].mCompletion == true)
                {
                    CompleteTasks += addToString;
                }
                k++;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nIncomplete Tasks\n{0}\n", incompleteTasks);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Completed Tasks\n{0}", CompleteTasks);
            Console.ResetColor();
        }
        public static void RemoveTaskName(List<Task> taskCollection)
        {
            Console.Write("\nEnter name of task you would like to Delete\n");
            var taskTitle = Console.ReadLine().ToString();
            var taskToDelete = taskCollection.Where(t => t.mTitle.Equals(taskTitle, StringComparison.InvariantCultureIgnoreCase));
            taskCollection.Remove(taskToDelete.ElementAt(0));

        }
        public static void RemoveTaskIndex(List<Task> taskCollection)
        {
            int j = 0;
            Console.Write("\nEnter index of task you would like to Delete\n");
            foreach (Task i in taskCollection)
            {
                Console.Write("{0}. {1}\n", j, taskCollection[j].mTitle);
                j++;
            }
            int taskIndex = Convert.ToInt32(Console.ReadLine());

            taskCollection.RemoveAt(taskIndex);
        }
        public static void EditTaskIndex(List<Task> taskCollection)
        {
            int j = 0;
            foreach (Task i in taskCollection)
            {
                Console.Write("{0}. {1}\n", j, taskCollection[j].mTitle);
                j++;
            }

            Console.Write("\nEnter index of task you would like to Edit\n");
            int taskIndex = Convert.ToInt32(Console.ReadLine());


            Console.Write("\n1. Edit Task \n2. Change Tag\n");
            var editChoice = Console.ReadLine().ToString();
            if (editChoice == "1")
            {
                Console.Write("Current Description = {0}\nNew Description = ", taskCollection[taskIndex].mDescription);
                var nDescription = Console.ReadLine();
                Task nTask = new Task(taskCollection[taskIndex].mTitle, nDescription, taskCollection[taskIndex].mCompletion);
                taskCollection.RemoveAt(taskIndex);

                taskCollection.Insert(taskIndex, nTask);
            }
            if (editChoice == "2")
            {
                if (taskCollection[taskIndex].mCompletion == true)
                {
                    Task nTask = new Task(taskCollection[taskIndex].mTitle, taskCollection[taskIndex].mTitle, false);
                    taskCollection.RemoveAt(taskIndex);
                    taskCollection.Insert(taskIndex, nTask);

                }
                if (taskCollection[taskIndex].mCompletion == false)
                {
                    Task nTask = new Task(taskCollection[taskIndex].mTitle, taskCollection[taskIndex].mTitle, true);
                    taskCollection.RemoveAt(taskIndex);
                    taskCollection.Insert(taskIndex, nTask);

                }
            }
        }
    }


}
