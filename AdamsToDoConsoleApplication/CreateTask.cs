using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamsToDoConsoleApplication
{
    class CreateFunction
    {
        public static void CreateTask(List<Task> taskCollection)
        {
            try
            {
                Console.WriteLine("\nType in the Title:\n");
                var inputTitle = Console.ReadLine();

                Console.WriteLine("Type in the Description:\n");
                var inputDescription = Console.ReadLine();

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
