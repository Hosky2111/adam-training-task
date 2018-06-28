using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamsToDoConsoleApplication
{
    public class Task
    {
        public string mTitle;
        public string mDescription;
        public bool mCompletion;

        public List<taskCollection> Tasks;
        public class taskCollection
        {
            public string mTitle;
            public string mDescription;
            public bool mCompletion;
        }

        public Task(string title, string description, bool completion)
        {
            mTitle = title;
            mDescription = description;
            mCompletion = completion;
        }
    }
    //public class FileTask
    //{
        //public List<TaskList> Tasks;
        //public class TaskList
        //{
           // public string mTitle;
            //public string mDescription;
           // public bool mCompletion;
        //}
    //}
}
