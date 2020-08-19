using System;
using System.Collections.Generic;
using System.Text;

namespace Examples
{
    public class Strings
    {
        static void Main(string[] args)
        {
            string myName = "Dennis";//Coding standard to use string instead of String

            string message = "My name is " + myName;

            string capsMessage = message.ToUpper();//Converts text of string message to all uppercase

            string lowerMessage = message.ToLower();//Converts text of string message to all lowercase.

            Console.WriteLine(message.Length);//Prints out length of message string
            Console.WriteLine(lowerMessage);
            Console.WriteLine(capsMessage);
            Console.WriteLine("My name is " + myName);
            Console.Read();
        }
    }
}
