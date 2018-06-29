using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamsToDoConsoleApplication
{
    class EditFunction
    {
        public static void EditTaskIndex(List<Task> taskCollection)
        {
            try
            {
                int indexer = 0;
                foreach (Task task in taskCollection)
                {
                    Console.Write("{0}. {1}\n", indexer, task.mTitle);
                    indexer++;
                }

                Console.Write("\nEnter index of task you would like to Edit\n");
                int taskIndex = InputHandler.uIntput(Console.ReadLine());

                Console.Write("\n1. Edit Task \n2. Change Tag\n");
                var editChoice = InputHandler.uStrinput(Console.ReadLine());

                Task currentTask = taskCollection[taskIndex];

                if (editChoice == "1")
                {
                    Console.Write("Current Description = {0}\nNew Description = ", currentTask.mDescription);
                    var newDescription = Console.ReadLine();
                    //Not handled by input handler as the description should be allowed to be an empty string
                    currentTask.mDescription = newDescription;
                }
                if (editChoice == "2")
                {
                    currentTask.mCompletion = !currentTask.mCompletion;

                    //if (currentCompletion)
                    //{
                    //    taskCollection[taskIndex].mCompletion = false;
                    //}
                    //if (!currentCompletion)
                    //{
                    //    taskCollection[taskIndex].mCompletion = true;
                    //}
                }
            }
            catch(Exception ex)
            {
                Exceptions.errorMessage("An Error has occured", ex);
            }
        }
    }
}
