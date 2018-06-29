using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamsToDoConsoleApplication
{
    public static class EditFunction
    {
        public static void EditTaskIndex(List<Task> taskCollection)
        {
            try
            {
                int indexer = 0;
                foreach (Task i in taskCollection)
                {
                    Console.Write("{0}. {1}\n", indexer, i.mTitle);
                    indexer++;
                }

                Console.Write("\nEnter index of task you would like to Edit\n");
                int taskIndex = InputHandler.uIntput(Console.ReadLine());

                Console.Write("\n1. Edit Task \n2. Change Tag\n");
                var editChoice = InputHandler.uStrinput(Console.ReadLine());

                Task currentTask = taskCollection[taskIndex];
                string currentTitle = currentTask.mTitle;
                string currentDescription = currentTask.mDescription;
                bool currentCompletion = currentTask.mCompletion;

                if (editChoice == "1")
                {
                    Console.Write("Current Description = {0}\nNew Description = ", currentDescription);
                    var newDescription = Console.ReadLine();

                    taskCollection[taskIndex].mDescription = newDescription;
                }
                if (editChoice == "2")
                {
                    taskCollection[taskIndex].mCompletion = !taskCollection[taskIndex].mCompletion;

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
