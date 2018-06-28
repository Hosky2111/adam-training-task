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
                    CreateFunction.CreateTask(taskCollection);
                }
                if (input == "2")
                {
                    EditFunction.EditTaskIndex(taskCollection);
                }
                if (input == "3")
                {
                    RemoveFunction.removelist(taskCollection);
                }
                if (input == "4")
                {
                    ListFunction.ListTask(taskCollection);
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
                        JsonFileManagement.JsonWriteFiles(taskCollection);
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

