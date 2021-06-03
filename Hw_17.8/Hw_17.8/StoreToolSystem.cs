using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hw_17._8
{
    class StoreToolSystem
    {
        StoreFileSystem storeFileSystem;

        /// <summary>
        ///     Constructor for initializing StoreToolSystem
        /// </summary>
        /// <param name="storeFileSystem"> to access file processes</param>
        public StoreToolSystem(StoreFileSystem storeFileSystem)
        {
            this.storeFileSystem = storeFileSystem;
        }


        /// <summary>
        ///     Saves given tool into hardware.dat file via storeFileSystem instance
        /// </summary>
        /// <param name="tool"> is a Tool object that will be saved </param>
        public void SaveTool(Tool tool)
        {
            if (tool is null)
            {
                throw new ArgumentNullException(nameof(tool));
            }

            storeFileSystem.WriteFile(tool);
        }

        /// <summary>
        ///     Saves given list of tools into hardware.dat file via storeFileSystem instance
        /// </summary>
        /// <param name="toolList"> is a list of Tool objects that will be saved </param>
        public void SaveTool(List<Tool> toolList)
        {
            toolList.ForEach(l => SaveTool(l));
        }

        /// <summary>
        ///     Deletes given tool from hardware.dat file via storeFileSystem instance
        /// </summary>
        /// <param name="tool"> is a Tool object that will be deleted </param>
        public void DeleteTool(Tool tool)
        {
            if (tool is null)
            {
                throw new ArgumentNullException(nameof(tool));
            }

            String record = storeFileSystem.FindInFile(tool);

            // create temporary file, make the changes and restore main file
            if (record != null)
            {
                var tempFile = Path.GetTempFileName();
                var linesToKeep = File.ReadLines(storeFileSystem.FileName).Where(l => l.Substring(0, 5) != record.Substring(0, 5));
                File.WriteAllLines(tempFile, linesToKeep);
                File.Delete(storeFileSystem.FileName);
                File.Move(tempFile, storeFileSystem.FileName);
            }

        }

        /// <summary>
        ///     Updates given originalTool to updatedTool via storeFileSystem instance
        /// </summary>
        /// <param name="originalTool"> original instance </param>
        /// <param name="updatedTool"> the form of updated instance </param>
        public void UpdateTool(Tool originalTool, Tool updatedTool)
        {
            Tool t = storeFileSystem.FindToolInFile(originalTool);

            if (t != null)
            {
                t.Name = updatedTool.Name;
                t.Quantity = updatedTool.Quantity;
                t.Price = updatedTool.Price;

                // read all content of hardware.dat and replace required places
                string str = File.ReadAllText(storeFileSystem.FileName);
                File.ReadLines(storeFileSystem.FileName).ToList().ForEach(l =>
                {
                    string subString = l.Substring(0, 5).Trim();

                    if (subString.Equals(t.RecordId.ToString()))
                    {
                        File.WriteAllText(storeFileSystem.FileName, str.Replace(l.ToString(), t.ToString()));
                    }
                });
            }

        }
    }
}