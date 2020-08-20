using System;

namespace Methods.Methods_Challenge
{
    public class MethodChallenge
    {
        /// <summary>
        /// The purpose of this class is to create a method that takes in a stored string var and prints it to the console with predefined text
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string friend = "Matthew";
            string friend1 = "Becca";
            string friend2 = "Brandon";
            
            GreetFriend(friend);
            GreetFriend(friend1);
            GreetFriend(friend2);
            Console.Read();

        }

        public static void GreetFriend(string f)//Void so we dont need return statement
        {
            Console.WriteLine("Hi " + f + ", my friend!");
        }
    }
}
