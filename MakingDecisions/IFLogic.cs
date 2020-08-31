using System;
using System.Collections.Generic;
using System.Text;

namespace MakingDecisions
{
    class IFLogic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats the temperature like? => ");

            string temp = Console.ReadLine();
            int temperature = Int32.Parse(temp);

            if (temperature < 10)
            {
                Console.WriteLine("Take the coat!");
            }

            if (temperature == 10)
            {
                Console.WriteLine("It's 10 degrees C");
            }

            if (temperature > 10)
            {
                Console.WriteLine("cozy warm!");
            }

            Console.Read();
        }
    }
}
