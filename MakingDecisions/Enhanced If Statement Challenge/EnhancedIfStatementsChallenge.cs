using System;
using System.Collections.Generic;
using System.Text;

namespace MakingDecisions.Enhanced_If_Statement_Challenge
{
    /**
     * Enhanced If Statements - Ternary Operator - Challenge
We have studied ternary operators and their usage so here is a small challenge for you. Let's create a small application that takes a temperature value as input and checks if the input is an integer or not.

If the input value is not an integer value, it should print to the console "Not a valid Temperature".

And if the input value is the valid integer then it should work as mentioned below.

If input temperature value is <=15 it should write "it is too cold here" to the console.

If input temperature value is >= 16 and is <=28 it should write "it is ok" to the console.

If the input temperature value is > 28 it should write "it is hot here" to the console.

Make sure to use ternary operators and not if statements to check for the three conditions, however you can use if statement for the other conditions like to check if the entered value is a valid integer or not.


     */
    class EnhancedIfStatementsChallenge
    {
        static void Main(string[] args)
        {
            CheckNum();
        }

        public static void CheckNum()
        {
            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();//allows user input and stores as input.
            int tempNum;
            string tempStatus;

            if (!int.TryParse(input, out tempNum))//Takes in input string variable and checks if entered value is a number, if not prints "not an integer" if it is goes on
            {
                Console.WriteLine("Not an Integer");
            }
            else
            {
                tempStatus = tempNum <= 15 ? "Too Cold out here" : tempNum > 15 && tempNum <= 28 ? "It is okay" : "It is Hot out here";//Determines how the weather is outside if <= 15 (cold) between >15 <=28(Okay) > 28 Hot
                Console.WriteLine("The current status of the weather outside is {0}", tempStatus);
            }
        }
    }
}
