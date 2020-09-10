using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MakingDecisions.IF_Statement_Challenge_2
{
    class HighScoreCorrected
    {

        static int highscore = 300;
        static string highscorePlayer = "Matt";

        static void Main(string[] args)
        {
            CheckHighScore(250, "Maria");
            CheckHighScore(315, "Michael");
            CheckHighScore(350, "Matt");

            Console.Read();
        }

        public static void CheckHighScore(int score, string playerName)
        {
            if(score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;

                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("It is now held by " + playerName);

            }
            else
            {
                Console.WriteLine("The old highscore could not be broken it is still " + highscore + " and held by " + highscorePlayer);
            }
        }
    }
}
