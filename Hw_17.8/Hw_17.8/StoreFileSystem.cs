using System;
using System.IO;
using System.Linq;

namespace Hw_17._8
{
    class StoreFileSystem
    {
        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        FileStream fs;

        /// <summary>
        ///     Constructor for initializing StoreFileSystem
        /// </summary>
        /// <param name="fileName"> name of .dat file </param>
        public StoreFileSystem(string fileName)
        {
            this.fileName = fileName;
        }

        /// <summary>
        ///     If given file with a fileName name does not exists, creates file and writes column names, 
        ///     otherwise truncates file and writes column names
        /// </summary>
        public void CreateFile()
        {
            if (fileName is null)
            {
                throw new ArgumentNullException(nameof(fileName));
            }
            string columnNames = string.Format("{0,-10} {1,-15} {2,-10} {3,-10}", "Record #", "Tool name", "Quantity", "Price");


            if (File.Exists(fileName))
            {
                fs = new FileStream(fileName, FileMode.Truncate, FileAccess.Write);
                Console.WriteLine(columnNames);
                fs.Close();
                return;
            }

            try
            {
                fs = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write);
                Console.WriteLine(columnNames);
                fs.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        ///     Writes given Tool into hardware.dat file
        /// </summary>
        /// <param name="tool"> is a Tool object that will be saved </param>
        public void WriteFile(Tool tool)
        {
            if (tool is null)
            {
                throw new ArgumentNullException(nameof(tool));
            }
            // formatted as written in hardware.dat file
            string text = string.Format("{0,-10} {1,-15} {2,-10} {3,-10}", tool.RecordId, tool.Name, tool.Quantity, tool.Price);

            using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter write = new StreamWriter(fs))
                {
                    write.WriteLine(text);
                }
                fs.Close();
            }
        }

        /// <summary>
        ///     Reaads all file and prints to the console
        /// </summary>
        public void ReadFile()
        {
            File.ReadLines(fileName).ToList().ForEach(l => Console.WriteLine(l));
        }

        /// <summary>
        ///     Finds given tool in hardware.dat file and returns its line as string
        /// </summary>
        /// <param name="tool"> is a Tool object that will be found </param>
        /// <returns> the line that tool is written </returns>
        public String FindInFile(Tool tool)
        {
            try
            {
                return File.ReadLines(fileName).First(l => Int32.Parse(l.Substring(0, 5)).Equals(tool.RecordId));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        /// <summary>
        ///     Finds given tool in hardware.dat file and returns it as Tool object
        /// </summary>
        /// <param name="tool"> is a Tool object that will be found </param>
        /// <returns> the tool in file </returns>
        public Tool FindToolInFile(Tool tool)
        {
            try
            {
                String foundTool = File.ReadLines(fileName).First(l => Int32.Parse(l.Substring(0, 5)).Equals(tool.RecordId));
                if (foundTool != null)
                {
                    int toolId = Int32.Parse(foundTool.Substring(0, 10));
                    string toolName = foundTool.Substring(11, 15);
                    int toolQuantity = Int32.Parse(foundTool.Substring(27, 10));
                    float toolPrice = float.Parse(foundTool.Substring(38, 10));
                    return new Tool(toolId, toolName, toolQuantity, toolPrice);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
}