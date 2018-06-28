using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamsToDoConsoleApplication
{
    class InputHandler
    {
        public static string Reader (string option)
        {
            var uInput = Console.ReadLine();
            if (uInput.Equals(typeof(int)) && option == "string")
            {
                uInput = (uInput.ToString());
            }
            if (uInput.Equals(typeof(string)) && option == "int")
            {
                //uInput = (Convert.ToInt32(uInput));
            }

            return uInput;
        }

        //public static bool isInputInteger (string input)
        //{
        //    if()
        //}

    }
}
