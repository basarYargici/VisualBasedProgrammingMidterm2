using System;

namespace HW_8._8
{
    class SquareTest
    {
        static void Main(string[] args)
        {
            // test square class without argument
            Square firstSquare = new Square();
            firstSquare.Side = 3.5;
            Console.WriteLine(firstSquare.ToString());

            // test square class side argument
            Square secondSquare = new Square(34);
            Console.WriteLine(secondSquare.ToString());

            // to stop console disappearing in debug mode
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
