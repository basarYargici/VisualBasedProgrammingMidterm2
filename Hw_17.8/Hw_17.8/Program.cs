using System;
using System.Collections.Generic;

namespace Hw_17._8
{
    class Program
    {
        private const string FILE_NAME = "hardware.dat";

        static void Main(string[] args)
        {
            // creating StoreFileSystem to manage file processes, StoreToolSystem for editing the file
            StoreFileSystem storeFileSystem = new StoreFileSystem(FILE_NAME);
            StoreToolSystem storeToolSystem = new StoreToolSystem(storeFileSystem);

            // creating Tool instances
            Tool electricSander = new Tool("Electric sander", 18, 35.99f);
            Tool hammer = new Tool("Hammer", 128, 10.00f);
            Tool jigSaw = new Tool("Jig saw", 16, 14.25f);
            Tool lawnMower = new Tool("Lawn mower", 10, 79.50f);
            Tool powerSaw = new Tool("Power saw", 8, 89.99f);
            Tool screwdriver = new Tool("Screwdriver", 236, 4.99f);
            Tool sledgehammer = new Tool("Sledge hammer", 32, 19.75f);
            Tool wrench = new Tool("Wrench", 65, 6.48f);
            Tool newTool = new Tool("New Tool", 9999, 99.99f);
            Tool updatedNewTool = new Tool("Updated Tool", 12345, 1.11f);

            List<Tool> toolList = new List<Tool>()
            {
                electricSander,
                hammer,
                jigSaw,
                lawnMower,
                powerSaw,
                screwdriver,
                sledgehammer,
                wrench
            };

            storeFileSystem.CreateFile();

            // saving toolList into hardware.dat file
            storeToolSystem.SaveTool(toolList);

            // newTool will be saved to hardware.dat file but before toolList list
            toolList.Add(newTool);
            storeToolSystem.SaveTool(newTool);

            // deleting an element of toolList
            storeToolSystem.DeleteTool(electricSander);

            // finding an element of toolList    
            // Console.WriteLine(storeFileSystem.FindInFile(wrench));

            // updating tool which is added by SaveTool() method
            storeToolSystem.UpdateTool(newTool, updatedNewTool);

            // read content of hardware.dat file
            storeFileSystem.ReadFile();

            // to hold console 
            Console.ReadKey();
        }
    }
}



