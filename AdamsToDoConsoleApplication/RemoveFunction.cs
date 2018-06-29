using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamsToDoConsoleApplication
{
    class RemoveFunction
    {
        public static void removelist(List<Task> taskCollection)
            {
                    Console.Write("Delete as:\n1. Index of Task\n2. Name of Task\n");
                    var deletionChoice = Console.ReadLine().ToString();
                    try
                    {


                    if (deletionChoice == "1")
                    {
                        RemoveFunction.RemoveTaskIndex(taskCollection);
                    }
                    if (deletionChoice == "2")
                    {
                        RemoveFunction.RemoveTaskName(taskCollection);

                    }
                    }
                    catch (Exception ex)
                    {
                        Exceptions.errorMessage("An Error has occured", ex);
                    }

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
            int taskIndex = InputHandler.uIntput(Console.ReadLine());

            taskCollection.RemoveAt(taskIndex);
        }

    }
}
