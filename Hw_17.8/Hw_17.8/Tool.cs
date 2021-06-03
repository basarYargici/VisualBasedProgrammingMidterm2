using System.Threading;

namespace Hw_17._8
{
    /// <summary>
    ///     This class is an entity class which describes Tool objects
    /// </summary>
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

        /// <summary>
        ///     method formatted as written in hardware.dat file
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0,-10} {1,-15} {2,-10} {3,-10}", RecordId, Name, Quantity, Price);
        }
    }
}