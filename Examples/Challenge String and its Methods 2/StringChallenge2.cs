using System;

namespace Examples.Challenge_String_and_its_Methods_2
{
    public class StringChallenge2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string and press enter");
            string enteredString = Console.ReadLine();

            Console.WriteLine("Please enter the character you would like to search for from the above string and press enter");
            char enteredStringChar = Console.ReadLine()[0];//Defines a char to be searched from the above entered string to be found

            int searchIndex = enteredString.IndexOf(enteredStringChar);///Gets the index of the character from the string.
            Console.WriteLine("Index of character {0} in string is {1}", enteredStringChar, searchIndex);//{0} Referes to entered Char, {1} refers to the string?

            Console.WriteLine("Please Enter your First Name");//Prompts user for first Name
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your Last Name");//Prompts user for last Name
            string lastName = Console.ReadLine();

            string fullName = string.Concat(firstName, " ", lastName);//Concat the firstName and lastName var and assign to fullName

            Console.WriteLine("Your full name is {0}", fullName);//Prints the full name to the console
        }
    }
}
