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
            //Create an object of class Human
            //An instance of Human
            Human denis = new Human("Denis","Smith ", "Blue", 25);

            //access public variable from outside, and even change it
            //denis.firstName = "Denis ";
            //denis.lastName = "Smith";

            //call methods of the class
            denis.IntroduceMyself();

            Human matthew = new Human("Matthew", "Bob", "Green", 1);
            matthew.IntroduceMyself();

            /*
            Human michael = new Human();//Creating Human object, called michael

            michael.firstName = "Michael ";//Setting firstName var defined in human as michael
            michael.lastName = "Jones";
            
            michael.IntroduceMyself();//Calling IntroduceMyself method
            */

            Console.ReadKey();
        }
    }
}
