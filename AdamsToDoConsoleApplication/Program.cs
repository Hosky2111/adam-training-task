using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace AdamsToDoConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            //List<Task> taskCollection = new List<Task> { new Task("Example", "This is an example", false) };
            List<Task> taskCollection = new List<Task> {  };

            var input = "";

            bool Looping = true;

            while (Looping == true)
            {

                Menu.ShowMenu();
                Menu.ClearCurrentConsoleLine();
                input = Console.ReadLine().ToString();
                Menu.Line();

                if (input == "1")
                {
                    TaskFunctions.CreateTask(taskCollection);
                }
                if (input == "2")
                {
                    TaskFunctions.EditTaskIndex(taskCollection);
                }
                if (input == "3")
                {
                    Console.Write("Delete as:\n1. Index of Task\n2. Name of Task\n");
                    var deletionChoice = Console.ReadLine().ToString();
                    if (deletionChoice == "1")
                    {
                        TaskFunctions.RemoveTaskIndex(taskCollection);
                    }
                    if (deletionChoice == "2")
                    {
                        TaskFunctions.RemoveTaskName(taskCollection);
                    }

                }
                if (input == "4")
                {
                    TaskFunctions.ListTask(taskCollection);
                }
                if (input == "5")
                {
                    Console.Write("\n1. Open File\n2. Save File\n");
                    var saveChoice = Console.ReadLine().ToString();
                    if (saveChoice == "1")
                    {
                        FileManagement.ReadFiles(taskCollection);
                    }
                    if (saveChoice == "2")
                    {
                        FileManagement.WriteFiles(taskCollection);
                    }
                }

                if (input == "6")
                {
                    Looping = false;
                }

                input = null;
            }
        }
    }
}

