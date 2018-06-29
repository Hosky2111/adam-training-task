using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamsToDoConsoleApplication
{
    public class Menu
    {
        public static void ShowMenu(List<Task> taskCollection)
        {
            //Console.SetCursorPosition(0, 0);
            if (taskCollection.Count() > 0)
            {
                Console.Write($"Main Menu\n" +
                $"\n1. Create\n" +
                $"2. Edit\n" +
                $"3. Delete\n" +
                $"4. List\n" +
                $"5. File\n" +
                $"6. Close\n");
            }
            if (taskCollection.Count() == 0)
            {
                Console.Write($"Main Menu\n" +
                $"\n1. Create\n");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(
                $"2. Edit\n" +
                $"3. Delete\n" +
                $"4. List\n");
                Console.ResetColor();
                Console.Write
                ($"5. File\n"+
                $"6. Close\n");
            }
        }

        public static void Line()
        {
            string lineyBoy = String.Concat(Enumerable.Repeat("_", Console.WindowWidth));
            Console.Write("\n{0}\n", lineyBoy);
        }
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
        public static void consoleTitle(List<Task> taskCollection)
        {
            string incompleteTasks = taskCollection.Where(task => !task.mCompletion).Count().ToString();
            string totalTasks = taskCollection.Count().ToString();
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string conTitle = (userName+"'s ToDo List " +incompleteTasks+ " / " + totalTasks+" Tasks Incomplete");// [{0}/{1}] Incomplete", incompleteTasks, totalTasks);
            Console.Title = conTitle;
        }
    }
}
