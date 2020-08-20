using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class MethodsWithReturnValandParams
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(Add(1, 2), Add(3, 4)));//Would be 3 + 7 = 10 
            Console.WriteLine(Add(15, 31));//Using Method as Argument when printing to console
            Console.WriteLine(Multiply(56, 5));
            Console.WriteLine(Divide(56, 13));
            Console.Read();
        }

        //Method to add two ints together
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        //Method to multiply two ints together
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        //Method to Divide two ints 
        public static double Divide(double num1, double num2)//Params have to be doubles as well if int will just return int value
        {
            return num1 / num2;
        }
    }
}
