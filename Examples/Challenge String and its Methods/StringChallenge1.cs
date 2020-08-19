using System;

namespace Examples.Challenge_String_and_its_Methods
{
    public class StringChallenge1
    {
        /// <summary>
        /// The purpose of this challenge was to familiarize with storing user input into a var and using various string methods to manipulate the data (i.e. ToUpper,ToLower,Trim,and Substring)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string userEnteredString;
            Console.WriteLine("Please enter your name and press enter");
            userEnteredString = Console.ReadLine();//Defines a string userEnteredString and assigns the value of whatever string the user enters above

            Console.WriteLine("The string that you entered is => " + userEnteredString);

            Console.WriteLine("Upper Case : {0}", userEnteredString.ToUpper());//Takes the user entered string and converts it to uppercase
            Console.WriteLine("Lower Case : {0}", userEnteredString.ToLower());//Takes the user entered string and converts it to lowercase
            Console.WriteLine("Trimmed Value : {0}", userEnteredString.Trim());//Takes the user entered string and gets rid of any extra whitespace
            Console.WriteLine("Substring Value : {0}", userEnteredString.Substring(0,5));//string will display chars 0-5 (first 6)
        }
    }
}
