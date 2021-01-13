using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class BreakContinue
    {
        static void Main(string[] args)
        {
            for(int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
                if(counter %2 == 0)
                {
                    Console.WriteLine("Now comes an odd number");
                    continue;
                    //break;//Exits loop at given condition
                }
                Console.WriteLine(counter);
            }
            Console.Read();
        }
    }
}
