using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.IO;

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
        public static void XmlWriteFiles(List<Task> taskCollection)
        {
            Console.WriteLine("Enter File path to save to: \n");
            var wpath = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(wpath) == true)
            {
                Console.WriteLine("As no path was entered, the default path will be used : \\user\\documents\\Todo");
                wpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Todo\\";
                Directory.CreateDirectory(wpath); // will only create if it doesn't exist
            }
            if (wpath.Substring((wpath.Length - 1), 1) != "\\")
            {
                Console.WriteLine("Backslash added to end of path, path now " + wpath + "\\");
                wpath += "\\";
            }
            Console.WriteLine("Enter File Name: \n");
            var fileName = Console.ReadLine();
            string fullFatFile = wpath + fileName;//"C:\\Users\\AdamHoskinson\\Documents\\Doc2.Json"
            if (Path.HasExtension(fullFatFile) == false)
            {
                Console.WriteLine("No File Extension given, Filename set to " + fileName + ".xml");
                fullFatFile += ".xml";
            }
            Path.ChangeExtension(wpath, ".xml");

            XElement newTaskCollection = new XElement("Tasks",
                from task in taskCollection
                select new XElement("Task",
                    new XElement("mTitle", task.mTitle),
                    new XElement("mDescription", task.mDescription),
                    new XElement("mCompletion", task.mCompletion)
                    ));

            Console.WriteLine(newTaskCollection.ToString());
            System.IO.File.WriteAllText(fullFatFile, newTaskCollection.ToString());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nFile Successfully Saved\n");
            Console.ResetColor();
        }
    }
}
