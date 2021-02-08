using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];//declares an array of type int with 5 values

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 7;

            //Console.WriteLine("grades at index 0 : {0}", grades [0]);
            //Console.ReadLine();

            Console.Write("Please enter an integer => ");
            // assign value to array grades at index 0
            string input = Console.ReadLine();//Allows for input of an int
            grades[0] = int.Parse(input);
            Console.WriteLine("grades at index 0 : {0}", grades[0]);
            

            // another way of initializing an array
            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            // third way of initializing an array
            int[] gradesOfMathStudentsB = new int[] { 15, 20, 3, 17, 15 };

            Console.WriteLine("Length of gradesOfMathStudentsA: {0}", gradesOfMathStudentsA.Length);

            Console.ReadKey();
        }
    }
}
