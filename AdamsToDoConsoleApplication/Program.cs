using System;
using System.Collections.Generic;

namespace AdamsToDoConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            var taskCollection = new List<Task> { new Task("Example", "This is an example") };

            Console.Write($"Main Menu\n" +
                $"1. Create\n" +
                $"2. Edit\n" +
                $"3. Delete\n");

            var input = Console.ReadLine().ToString();

            Menu.ShowMenu(input);

            if (input == "0")
            {
                TaskFunctions.CreateTask(taskCollection);
            }

            Console.WriteLine("Do you want to exit?  y/n");

            input = Console.ReadLine().ToString();

            if (input == "y")
            {
                Environment.Exit(0);
            }

            input = null;

            Menu.ShowMenu(input);
        }
    }

    public static class Menu
    {
        public static void ShowMenu(string input)
        {
            while (input != "0" && input != "1" && input != "2")
            {
                Console.Write($"Main Menu\n" +
                $"1. Create\n" +
                $"2. Edit\n" +
                $"3. Delete\n");

                input = Console.ReadLine().ToString();
            }
        }
}
}

