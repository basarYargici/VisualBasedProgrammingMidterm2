using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace Hw_17._8
{
    class Program
    {
        private const string FILE_NAME = "hardware.dat";

        static void Main(string[] args)
        {
            StoreFileSystem storeFileSystem = new StoreFileSystem(FILE_NAME);
            StoreToolSystem storeToolSystem = new StoreToolSystem(storeFileSystem);
            Tool a = new Tool("third tool", 4422, 4.578897f);
            Tool n = new Tool("fourth tool", 4454, 125);
            Tool b = new Tool("fifth tool", 1152, 6);

            storeFileSystem.CreateFile();
            storeToolSystem.SaveTool(a);
            storeToolSystem.SaveTool(n);
            //storeToolSystem.SaveTool(b);
            //storeToolSystem.DeleteTool(b);

            //storeFileSystem.ReadFile();
            //Tool x = storeFileSystem.FindInFile(a);
            //Console.WriteLine(x.RecordId.ToString() + " " + x.Name + " " + x.Quantity + " " + x.Price);
            Console.WriteLine(storeFileSystem.FindInFile(n));
            Console.ReadKey();
        }


    }

    class StoreToolSystem
    {
        StoreFileSystem storeFileSystem;
        FileStream fs;
        public StoreToolSystem(StoreFileSystem storeFileSystem)
        {
            this.storeFileSystem = storeFileSystem;
        }

        public void SaveTool(Tool tool)
        {
            if (tool is null)
            {
                throw new ArgumentNullException(nameof(tool));
            }

            storeFileSystem.WriteFile(tool);
        }

        public bool DeleteTool(Tool tool)
        {
            if (tool is null)
            {
                throw new ArgumentNullException(nameof(tool));
            }

            String record = storeFileSystem.FindInFile(tool);

            if (record != null)
            {
                var tempFile = Path.GetTempFileName();
                var linesToKeep = File.ReadLines(storeFileSystem.FileName).Where(l => l.Substring(0, 5) != record.Substring(0, 5));
                linesToKeep.ToList().ForEach(a => Console.WriteLine(a));
                File.WriteAllLines(tempFile, linesToKeep);
                File.Delete(storeFileSystem.FileName);
                File.Move(tempFile, storeFileSystem.FileName);
                return true;
            }
            return false;

        }
    }
    class StoreFileSystem
    {
        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        FileStream fs;
        public StoreFileSystem(string fileName)
        {
            this.fileName = fileName;
        }

        public void CreateFile()
        {
            if (fileName is null)
            {
                throw new ArgumentNullException(nameof(fileName));
            }


            if (File.Exists(fileName))
            {
                Console.WriteLine($"{fileName} already exists!");
                fs = new FileStream(fileName, FileMode.Truncate);
                fs.Close();
                return;
            }

            try
            {
                fs = new FileStream(fileName, FileMode.CreateNew);
                fs.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void WriteFile(Tool tool)
        {
            if (tool is null)
            {
                throw new ArgumentNullException(nameof(tool));
            }
            string text = string.Format("{0,-5} {1,-15} {2,-5} {3,-5}", tool.RecordId, tool.Name, tool.Quantity, tool.Price);

            using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter write = new StreamWriter(fs))
                {
                    write.WriteLine(text);
                }
            }
        }

        public void ReadFile()
        {
            File.ReadLines(fileName);
        }

        public String FindInFile(Tool tool)
        {

            String a = File.ReadLines(fileName).First(l => Int32.Parse(l.Substring(0, 5)).Equals(tool.RecordId));
            //using (fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            //{
            //    using (StreamReader read = new StreamReader(fs))
            //    {
            //        int id = -1;
            //        while (!read.EndOfStream && id != tool.RecordId)
            //        {
            //            string line = read.ReadLine();
            //            id = Int32.Parse(line.Substring(0, 5));
            //            if (id == tool.RecordId)
            //            {
            //                //int toolId = id;
            //                //string toolName = line.Substring(6, 15);
            //                //int toolQuantity = Int32.Parse(line.Substring(22, 5));
            //                //float toolPrice = float.Parse(line.Substring(28, 8));
            //
            //                //return new Tool(toolId, toolName, toolQuantity, toolPrice);
            //                fs.Close();
            //                return line;
            //            }
            //        }
            //        fs.Close();
            //        return null;
            //    }
            //}
            return a;
        }
    }


    class Tool
    {
        private int id = 0;
        private string name;
        private int quantity;
        private float price;
        public static int globalID;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int RecordId
        {
            get { return id; }
            set { id = value; }
        }

        public Tool(int id, string name, int quantity, float price)
        {
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }

        public Tool(string name, int quantity, float price)
        {
            id = Interlocked.Increment(ref globalID);
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }
    }
}



