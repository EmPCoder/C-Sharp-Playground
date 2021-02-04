using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(3,4,5);

            ////box.length = 3;
            ////box.SetLength(4); Because set Set Method to private this doesnt work
            //box.SetLength(4);
            ////box.height = 4;
            //box.Height = 96;
            //box.Width = 5;
            Console.WriteLine("The box length is => " + box.GetLength());
            Console.WriteLine("The box width is => " + box.Width);
            box.Width = 10;//Updates the width
            Console.WriteLine("The box width is => " + box.Width);
            Console.WriteLine("The box Volume is => " + box.Volume);
            Console.WriteLine("Front surface of the box is {0}", box.FrontSurface);

            //box.CalcFrontSurface();
            box.DisplayInfo();

        }
    }
}
