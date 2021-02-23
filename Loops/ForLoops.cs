using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class ForLoops
    {
        static void Main(string[] args)
        {
            /*
            for(int counter = 0; counter < 50; counter+=5)
            {
                Console.WriteLine(counter + " is lower than 50");
            }
            Console.WriteLine("For Loop is Done");
            Console.Read();
            */

            ForLoopOdd();

            //For loop that only prints odd numbers from 1 - 20
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    //Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine(i + " is an odd number :)");
                }
            }
            Console.Read();
        }

        //Method to calculate odd numbers from 1-20 in a method
        public static void ForLoopOdd()
        {
            for (int i = 1; i < 20; i += 2)
            {
                Console.WriteLine(i);
            }
        }

    }
}
