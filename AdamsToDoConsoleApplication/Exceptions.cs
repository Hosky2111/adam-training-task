using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamsToDoConsoleApplication
{
    class Exceptions
    {

        public static void errorMessage(string Issue, Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Issue + " : " + ex.Message.ToString());
            Console.ResetColor();

        }
    }
}
