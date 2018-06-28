using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamsToDoConsoleApplication
{
    class ListFunction
    {
        public static void ListTask(List<Task> taskCollection)
        {
            try
            {
                /*
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
                */
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Incomplete Tasks [{0}]\n", taskCollection.Where(task => !task.mCompletion).Count());
                foreach (Task currentTask in taskCollection.Where(task => !task.mCompletion))
                {
                    Console.Write("Title: {0}\nDescription: {1}\n", currentTask.mTitle, currentTask.mDescription);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nComplete Tasks [{0}]\n", taskCollection.Where(task => task.mCompletion).Count());
                foreach (Task currentTask in taskCollection.Where(task => task.mCompletion))
                {
                    Console.Write("Title: {0}\nDescription: {1}\n", currentTask.mTitle, currentTask.mDescription);
                }
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Exceptions.errorMessage("An Error has occured", ex);
            }
        }
    }
}