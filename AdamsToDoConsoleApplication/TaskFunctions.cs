using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamsToDoConsoleApplication
{
    public static class TaskFunctions
    {
        public static void CreateTask(List<Task> taskCollection)
        {
            Console.WriteLine("Type in the Title:\n");
            var inputTitle = Console.ReadLine();

            Console.WriteLine("Type in the Description:\n");
            var inputDescription = Console.ReadLine();

            var task = new Task(inputTitle, inputDescription);

            taskCollection.Add(task);
        }
    }
}
