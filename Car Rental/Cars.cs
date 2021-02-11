using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    class Cars
    { 
        //Method for Calculating the Number of Days the user wishes to rent the car
        public static int NumDaysCalc()
        {
            string input = Console.ReadLine();
            int numDays = Int32.Parse(input);
            return numDays;
        }

        public static void CarType()
        {
            Console.WriteLine("Please enter the type of car you wish to rent, you can choose from the following");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Press 1 for Sports");
            Console.WriteLine("Press 2 for Luxury");
            Console.WriteLine("Press 3 for Utility");
            Console.WriteLine("Press 4 for Economy");
            string input = Console.ReadLine();
            int carTypeInput = Int32.Parse(input);
            if(carTypeInput == 1)
            {
                Console.WriteLine("You have chosen to rent a Sports Car");
                Console.Write("Please enter the number of days you wish to rent the car for = > ");
                SportsCar();
            }
            else if(carTypeInput == 2)
            {
                Console.WriteLine("You have chosen to rent a Luxury Car");
                Console.Write("Please enter the number of days you wish to rent the car for = > ");
                LuxuryCar();
            }
            else if(carTypeInput == 3)
            {
                Console.WriteLine("You have chosen to rent a Utility Car");
                Console.Write("Please enter the number of days you wish to rent the car for = > ");
                UtilityCar();
            }
            else if(carTypeInput == 4)
            {
                Console.WriteLine("You have chosen to rent a Economy Car");
                Console.Write("Please enter the number of days you wish to rent the car for = > ");
                EconomyCar();
            }
            else
            {
                Console.WriteLine("Please enter one of the above options, as those are the only cars we have available at this time, Thank you!");
            }
        }

        //Method for calculating Sports Car Rental Fees
        public static void SportsCar()
        {
            int value = NumDaysCalc();//Allows you to use the Method NumDaysCalc() and use the return value as a variable2                     
            Console.WriteLine("You have chosen to rent the car for {0} days ", value);
            double price = 52.25;
            double insuranceRate = 25.98;
            double total = (value *  price) + insuranceRate;
            Console.WriteLine("You're total is ${0} ", total);
        }

        //Method for calculating Luxury Car Rental Fees
        public static void LuxuryCar()
        {
            int value = NumDaysCalc();//Sets the int value to = what NumDaysCalc() returns in this case numDays
            Console.WriteLine("You have chosen to rent the car for {0} days ", value);
            double price = 98.63;
            double insuranceRate = 37.48;
            double total = (value * price) + insuranceRate;
            Console.WriteLine("You're total is ${0} ", total);
        }

        //Method for calculating Utility Car Rental Fees
        public static void UtilityCar()
        {
            int value = NumDaysCalc();
            Console.WriteLine("You have chosen to rent the car for {0} days ", value);
            double price = 72.25;
            double insuranceRate = 17.89;
            double total = (value * price) + insuranceRate;
            Console.WriteLine("You're total is ${0} ", total);
        }

        //Method for calculating Economy Car Rental Fees
        public static void EconomyCar()
        {
            int value = NumDaysCalc();
            Console.WriteLine("You have chosen to rent the car for {0} days ", value);
            double price = 35.52;
            double insuranceRate = 10.59;
            double total = (value * price) + insuranceRate;
            Console.WriteLine("You're total is ${0} ", total);
        }

        //TO DO: Output detailed Receipt, Clarify nonstring out put, allow user to run program again

        //static bool IsString(string value)
        //{
        //    foreach(char c in value)
        //    {
        //        if (!char.IsLetter(c))
        //            return false;
        //    }
        //    return true;
        //}

        public Cars()
        {
        }
    }
}
