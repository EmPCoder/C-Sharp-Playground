using System;

namespace Examples
{
    //Constants are immutable values which are known
    //At compile time and do not change for the life of the program.
    public class Constants
    {
        //constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;

        //Create a constant of type string with your birthday as its value
        const string birthDay = "02/15/1995";

        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is always going to be: {0}", birthDay);
        }
    }
}
