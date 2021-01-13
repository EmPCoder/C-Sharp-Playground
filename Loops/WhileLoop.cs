using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class WhileLoop
    {
        static void Main(string[] args)
        {
            PeopleCounter();

            int counter = 0;
            //While Condition met runs code in loop
            while(counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }
            Console.Read();
        }

        //While loop that allows user to press enter for an empty string and adds to the count per times pressed entered if user enters anything besides empty string ends program
        public static void PeopleCounter()
        {
            int counter = 0;
            string enteredText = "";

            while(enteredText.Equals(""))
            {
                Console.WriteLine("Please press enter to increase amount by one and anything else + enter if you want to finish");
                enteredText = Console.ReadLine();
                counter++;
                Console.WriteLine("current people count is {0}", counter);//{0} placeholder for counter var
            }
            Console.WriteLine("{0} people are inside the bus. Press enter to close the program", counter);
            Console.Read();
        }
    }
}
