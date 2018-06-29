using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamsToDoConsoleApplication
{
    public class CreateFunction
    {
        public static void CreateTask(List<Task> taskCollection)
        {
            try
            {
                string inputTitle ="";
                bool inputLoop = true;
                while (inputLoop)
                {
                    Console.WriteLine("\nType in the Title:\n");
                    inputTitle = InputHandler.uStrinput(Console.ReadLine());
                    if (taskCollection.Where(p => p.mTitle == inputTitle).Count() > 0)
                    {
                        Console.WriteLine("Name is already in use\n");
                    }
                    else { inputLoop = false; }
                }
                Console.WriteLine("Type in the Description:\n");
                var inputDescription = Console.ReadLine(); //allow empty descriptions

                var task = new Task(inputTitle, inputDescription, false);

                taskCollection.Add(task);
            }
            catch(Exception ex)
            {
                Exceptions.errorMessage("An Error has occured", ex);
            }
        }
    }
}
