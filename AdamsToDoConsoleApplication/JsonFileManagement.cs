using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AdamsToDoConsoleApplication
{
    class JsonFileManagement
    {
        public static void JsonReadFiles(string path, List<Task> taskCollection)
        {
            try
            {
                string rawFileString = System.IO.File.ReadAllText(path);//System.IO.File.ReadAllText(@"C:\Users\AdamHoskinson\Documents\document.json");
                JObject loadedObject = JObject.Parse(rawFileString);
                foreach (var obj in loadedObject["Tasks"])
                {
                    var task = new Task(obj["mTitle"].ToString(), obj["mDescription"].ToString(), Convert.ToBoolean(obj["mCompletion"]));
                    taskCollection.Add(task);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nFile Successfully Opened\n");
                Console.ResetColor();
                /*
                var deserialisedFileString = JsonConvert.DeserializeObject<Task>(rawFileString);
                taskCollection.Clear();

                foreach (var obj in deserialisedFileString.Tasks)
                {
                    var task = new Task(obj.mTitle.ToString(), obj.mDescription.ToString(), obj.mCompletion);
                    taskCollection.Add(task);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nFile Successfully Opened\n");
                Console.ResetColor();
                */
            }
            catch (IOException ex)
            {
                Exceptions.errorMessage("An Error has occured as the path was incorrect", ex);
            }
            catch (ArgumentNullException ex)
            {
                Exceptions.errorMessage("As no Path was Entered, The default path will be used", ex);
            }
            catch (Exception ex)
            {
                Exceptions.errorMessage("An Error has occured", ex);
            }
            

        }
       ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static void JsonWriteFiles(List<Task> taskCollection)
        {
            try
            {
                Console.WriteLine("Enter File path to save to: \n");
                var wpath = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(wpath) == true)
                {
                    Console.WriteLine("As no path was entered, the default path will be used : \\user\\documents\\Todo");
                    wpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString() + "\\Todo\\";
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
                    Console.WriteLine("No File Extension given, Filename set to " + fileName + ".Json");
                    fullFatFile += ".Json";
                }
                Path.ChangeExtension(wpath, ".json");


                JObject newJsonO = new JObject(
                    new JProperty("Tasks",
                        new JArray(
                            from i in taskCollection
                            select new JObject
                            (
                                new JProperty("mTitle", i.mTitle),
                                new JProperty("mDescription", i.mDescription),
                                new JProperty("mCompletion", i.mCompletion)
                            ))));

                Console.WriteLine(newJsonO.ToString());
                System.IO.File.WriteAllText(fullFatFile, newJsonO.ToString());
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nFile Successfully Saved\n");
                Console.ResetColor();
                /*
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
                */
            }
            catch (Exception ex)
            {
                Exceptions.errorMessage("An Error has occured", ex);
            }
        }
    }
}
