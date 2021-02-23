using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        // the PlayField
        static char[,] playField =
        {
            {'1', '2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'}
        };


        static void Main(string[] args)
        {
            SetField();//Calls SetField();
            Console.ReadLine();
        }

        /// <summary>
        /// Defines the look of the field to be used for the tic tac toe game
        /// </summary>
        public static void SetField()
        {
            Console.WriteLine("      |      |      ");
            //TODO Replace numbers with variables
            Console.WriteLine("   {0}  |   {1}  |   {2}", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("______|______|______");

            Console.WriteLine("      |      |      ");
            //TODO Replace numbers with variables
            Console.WriteLine("   {0}  |   {1}  |   {2}", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("______|______|______");

            Console.WriteLine("      |      |      ");
            //TODO Replace numbers with variables
            Console.WriteLine("   {0}  |   {1}  |   {2}", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("      |      |      ");
        }
    }
}
