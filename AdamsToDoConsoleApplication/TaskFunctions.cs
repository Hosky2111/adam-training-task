using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace AdamsToDoConsoleApplication
{
    public static class TaskFunctions
    {
        public static void CreateTask(List<Task> taskCollection)
        {
            Console.WriteLine("\nType in the Title:\n");
            var inputTitle = Console.ReadLine();

            Console.WriteLine("Type in the Description:\n");
            var inputDescription = Console.ReadLine();

            var task = new Task(inputTitle, inputDescription, false);

            taskCollection.Add(task);
        }

        public static void ListTask(List<Task> taskCollection)
        {
            string incompleteTasks = "";
            string CompleteTasks = "";
            string addToString = "";
            foreach (Task currentTask in taskCollection)
            {
                addToString = "";
                addToString += "\nTitle: " + currentTask.mTitle + "\nDescription: " + currentTask.mDescription + "\n";
                if (currentTask.mCompletion == false)
                {
                    incompleteTasks += addToString;
                }
                if (currentTask.mCompletion == true)
                {
                    CompleteTasks += addToString;
                }
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
            int indexer = 0;
            Console.Write("\nEnter index of task you would like to Delete\n");
            foreach (Task currentTask in taskCollection)
            {
                Console.Write("{0}. {1}\n", indexer, currentTask.mTitle);
                indexer++;
            }
            int taskIndex = Convert.ToInt32(Console.ReadLine());

            taskCollection.RemoveAt(taskIndex);
        }

        public static void EditTaskIndex(List<Task> taskCollection)
        {
            int indexer = 0;
            foreach (Task i in taskCollection)
            {
                Console.Write("{0}. {1}\n", indexer, i.mTitle);
                indexer++;
            }

            Console.Write("\nEnter index of task you would like to Edit\n");
            int taskIndex = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n1. Edit Task \n2. Change Tag\n");
            var editChoice = Console.ReadLine().ToString();

            string currentTitle = taskCollection[taskIndex].mTitle;
            string currentDescription = taskCollection[taskIndex].mDescription;
            bool currentCompletion = taskCollection[taskIndex].mCompletion;

            if (editChoice == "1")
            {
                Console.Write("Current Description = {0}\nNew Description = ", currentDescription);
                var newDescription = Console.ReadLine();
                //Task newTask = new Task(currentTitle, newDescription, currentCompletion);
                //taskCollection.RemoveAt(taskIndex);
                //taskCollection.Insert(taskIndex, newTask);
                taskCollection[taskIndex].mDescription = newDescription;
            }
            if (editChoice == "2")
            {
                if (currentCompletion)
                {
                    //Task nTask = new Task(currentTitle, currentDescription, false);
                    //taskCollection.RemoveAt(taskIndex);
                    //taskCollection.Insert(taskIndex, nTask);
                    taskCollection[taskIndex].mCompletion = false;
                }
                if (!currentCompletion)
                {
                    //Task nTask = new Task(currentTitle, currentDescription, true);
                    //taskCollection.RemoveAt(taskIndex);
                    //taskCollection.Insert(taskIndex, nTask);
                    taskCollection[taskIndex].mCompletion = true;
                }
            }
        }
    }
}
*/