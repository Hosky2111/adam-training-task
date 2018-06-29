using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamsToDoConsoleApplication
{
    class InputHandler
    {
        public static int uIntput (string uInput)
        {
            bool inputLoop = true;
            while (inputLoop == true)
            {
                try
                {
                    int uIntput = Int32.Parse(uInput);
                    inputLoop = false;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("No number was entered\n");
                    inputLoop = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Number is not in integer format: [{0}]\n", uInput);
                    inputLoop = true;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number is greater than the maximum value: [{0}]\n", uInput);
                    inputLoop = true;
                }
                if (inputLoop)
                {
                    uInput = Console.ReadLine();
                }
            }
            return (Int32.Parse(uInput));
        }
        public static string uStrinput(string uInput)
        {
            bool inputLoop = true;
            while (inputLoop == true)
            {
                if (String.IsNullOrWhiteSpace(uInput))
                {
                    Console.WriteLine("The text you entered was empty\n");
                    uInput = Console.ReadLine();
                }
                else { inputLoop = false; }
            }
            return (uInput);
        }
    }
}
