using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace AdamsToDoConsoleApplication
{
    class FileManagement
    {
        public static void ReadFiles(List<Task> taskCollection)
        {
            try
            {
                Console.WriteLine("Enter File path: \n");
                var path = Console.ReadLine();
                string rawFileString = System.IO.File.ReadAllText(path);//System.IO.File.ReadAllText(@"C:\Users\AdamHoskinson\Documents\document.json");
                var deserialisedFileString = JsonConvert.DeserializeObject<FileTask>(rawFileString);

                taskCollection.Clear();

                foreach (var obj in deserialisedFileString.Tasks)
                {
                    var task = new Task(obj.mTitle.ToString(), obj.mDescription.ToString(), obj.mCompletion);
                    taskCollection.Add(task);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nFile Successfully Opened\n");
                Console.ResetColor();
            }
            catch (IOException ex)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("An Error has occured: " + ex.Message.ToString());
                Console.ResetColor();
            }
            catch (ArgumentNullException ex)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("An Error has occured: " + ex.Message.ToString());
                Console.ResetColor();
            }
            catch (Exception ex)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("An Error has occured: " + ex.Message.ToString());
                Console.ResetColor();
            }

        }
        public static void WriteFiles(List<Task> taskCollection)
        {
            try
            {
                TaskFunctions.ListTask(taskCollection);
                Console.WriteLine("Enter File path to save to: \n");
                var path = Console.ReadLine();
                Console.WriteLine("Enter File Name: \n");
                var fileName = Console.ReadLine();
                string fullFatFile = path + fileName + ".Json";//"C:\\Users\\AdamHoskinson\\Documents\\Doc2.Json"
                Path.ChangeExtension(path, ".json");
                string rawFileString = "{\"Tasks\":[";

                int k = 0;
                string addToString = "";
                foreach (Task i in taskCollection)
                {

                    addToString = "";
                    addToString += "{ \"mTitle\": \"" + taskCollection[k].mTitle + "\",\"mDescription\": \"" + taskCollection[k].mDescription + "\",\"mCompletion\": \"" + taskCollection[k].mCompletion + "\" },";
                    rawFileString += addToString;
                    k++;
                }
                rawFileString = rawFileString.Remove(rawFileString.Length - 1);
                rawFileString += "]}";
                System.IO.File.WriteAllText(fullFatFile, rawFileString);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nFile Successfully Saved\n");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("An Error has occured: " + ex.Message.ToString());
                Console.ResetColor();
            }
        }
    }
}
