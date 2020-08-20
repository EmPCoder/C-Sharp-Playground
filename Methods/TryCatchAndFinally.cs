using System;

namespace Methods
{
    public class TryCatchAndFinally
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            int num1 = 5;
            int num2 = 0;
            int result;
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't Divide by Zero!");
            }

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)//Catch with Exception = Very Generic Error
            {
                Console.WriteLine("Format Expection, Please enter only numbers next time!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Expection, Please enter a smaller number");
            }
            catch (ArgumentNullException) 
            { 
                Console.WriteLine("ArgumentNullException, the value was empty(null)");
            }
            finally//Code entered here will always be ran regardless
            {
                Console.WriteLine("This is called anyways");
            }

            Console.ReadKey();
        }
    }
}
