using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Foreach_Loops_and_Switch_Statement_Challenge
{
    class ForeachLoopsandSwitchStatementChallengeCorrected
    {
        public static void Main(string[] args)
        {

            Boolean valid = false;
            string inputValueType;

            Console.WriteLine("Enter a value => ");
            string inputValue = Console.ReadLine();

            Console.WriteLine("Please enter the type of the input value");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Press 1 for string");
            Console.WriteLine("Press 2 for int");
            Console.WriteLine("Press 3 for boolean");

            Console.Write("Enter :");
            int inputType = Convert.ToInt32(Console.ReadLine());

            switch (inputType)
            {
                case 1:
                    //check for string
                    valid = IsAllAlphabetic(inputValue);//Passing in user entered string
                    inputValueType = "String";
                    break;
                case 2:
                    int retValue = 0;
                    //check for integer
                    valid = int.TryParse(inputValue, out retValue);//Takes in inputValue and returns retValue
                    inputValueType = "Integer";
                    break;
                case 3:
                    bool retFlag = false;
                    //check for boolean
                    valid = bool.TryParse(inputValue, out retFlag);//Passing in user entered string
                    inputValueType = "Booleans";
                    break;

                default:
                    inputValueType = "Unknown";
                    Console.WriteLine("Not able to detect input type, something is wrong");
                    break;
            }

            Console.WriteLine("You have entered a value : {0}", inputValue);
            if (valid)
            {
                Console.WriteLine("It is valid : {0}", inputValueType);
            }
            else
            {
                Console.WriteLine("It is an invalid : {0}", inputValueType);
            }

            Console.ReadKey();

        }

        //HELLO WORLD will go through each letter and checks if it is a letter
        //function to check if the input string is a pure letter string
        static bool IsAllAlphabetic(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                    return false;
            }

            return true;
        }
    }
}
