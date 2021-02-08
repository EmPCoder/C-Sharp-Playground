using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class MultiDimensionalArraysProgram
    {
        static void Main(string[] args)
        {
            // declar 2d Array
            string[,] matrix;

            // 3D array
            int[,,] threeD;

            // two dimensional Array
            int[,] array2D = new int[,]
            {
                {1,2,3}, //row 0
                {4,5,6 }, //row 1
                {7,8,9 } //row 2
            };

            Console.WriteLine("Central value is {0}", array2D[1,1]);//prints 5 because index 1 within the row 1
            Console.WriteLine("Central value is {0}", array2D[2, 0]);//prints 7 because index 0 within the row 2

            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001"},
                    {"010", "011"},
                    {"Hi there", "Whats up"}
                },
                {
                    {"100", "101"},
                    {"110", "111"},
                    {"Another one", "Last entry"}
                }
            };

            Console.WriteLine("Central value is {0}", array3D[1, 1, 0]);
            Console.WriteLine("Central value is {0}", array3D[0, 2, 0]);//prints Hi there

            string[,] array2DString = new string[3, 2] { //specifies 3 rows with 2 points of data in each
                { "One", "Two" }, 
                { "Three", "Four" }, 
                { "Five", "Six" } 
            };

            array2DString[1, 1] = "Chicken";
            Console.WriteLine("Current Val = {0}", array2DString[1, 1]);

            int dimensions = array2DString.Rank;
            Console.WriteLine("Dimension value is {0}", dimensions);

            
            Console.ReadKey();
        }
    }
}
