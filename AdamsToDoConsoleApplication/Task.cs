using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamsToDoConsoleApplication
{
    public class Task
    {
        private string mTitle;
        private string mDescription;

        public Task(string title, string description)
        {
            mTitle = title;
            mDescription = description;
        }
    }
}
