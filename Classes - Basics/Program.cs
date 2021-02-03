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
            Box box = new Box();

            //box.length = 3;
            //box.SetLength(4); Because set Set Method to private this doesnt work
            box.SetLength(-4);
            box.height = 4;
            box.width = 5;
            Console.WriteLine("The box length is => " + box.GetLength());
            Console.WriteLine("The box Volume is => " + box.GetVolume());
            box.DisplayInfo();
        }
    }
}
