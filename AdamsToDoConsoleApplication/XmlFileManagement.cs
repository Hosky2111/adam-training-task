using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace AdamsToDoConsoleApplication
{
    class XmlFileManagement
    {
        public static void XmlReadFiles(string path, List<Task> taskCollection)
        {
            System.Xml.Serialization.XmlSerializer reader =
            new System.Xml.Serialization.XmlSerializer(typeof(Task));
            System.IO.StreamReader file = new System.IO.StreamReader(
                path);
            Task newtask = (Task)reader.Deserialize(file);
            file.Close();
            Console.WriteLine(newtask.ToString());
            //try
            //{
            //string rawFileString = System.IO.File.ReadAllText(path);
            //var serializer = new XmlSerializer(Typeof (path));
            //var deserialisedFileString = serializer.Deserialize(rawFileString);
            //XmlDocument doc = new XmlDocument;
            //doc.Load(path);

            //for (XmlNode item in )
            //Console.WriteLine(doc.DocumentElement.ToString);

            //}

        }
        public static void XmlWriteFiles(string path, List<Task> taskCollection)
        {
            XElement newTaskCollection = new XElement("Tasks",
                from task in taskCollection
                select new XElement("Task",
                    new XElement("mTitle", task.mTitle),
                    new XElement("mDescription", task.mDescription),
                    new XElement("mCompletion", task.mCompletion)
                    ));
            Console.WriteLine(newTaskCollection);
        }
    }
}
