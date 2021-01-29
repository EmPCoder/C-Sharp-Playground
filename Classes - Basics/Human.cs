using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Basics
{
    //add two more member variables to "Human". eyeColor and age.
    //adjust the constructor, so it requires all of the four values to be used, when creating an object of Human.
    //create two objects of type human


    //this class is a blueprint for a datatype

    //create a public variable lastName of type string.
    //change the IntroduceMyself method, so it tells the whole name.
    //create two objects with full information about themself- firstName and lastName

    /*
     * The purpose of multiple constructors is to handle all cases that may come up such as users not entering certain data in the DB etc..
     */

    class Human
    {
        //member variable
        private string firstName;//by adding public allows outside class access
        private string lastName;
        private string eyeColor;
        private int age;

        //default constructor
        public Human() 
        {
            Console.WriteLine("Constructor called. Object created" );
        }

        //parameterized constructor to create a human object with params firstName, and lastName, eyeColor, and age
        public Human(string firstName, string myLastName, string eyeColor, int age) 
        {
            this.firstName = firstName;//Using the this.keyword assigns the current value to the appropriate object
            lastName = myLastName;//Can also do it this way by changing the var to match the current object
            this.eyeColor = eyeColor;
            this.age = age;
        }

         public Human(string firstName, string myLastName, int age) 
        {
            this.firstName = firstName;//Using the this.keyword assigns the current value to the appropriate object
            lastName = myLastName;//Can also do it this way by changing the var to match the current object
            this.age = age;
        }

        //parameterized constructor with FN, LN, and eyeColor
        public Human(string firstName, string myLastName, string eyeColor) 
        {
            this.firstName = firstName;//Using the this.keyword assigns the current value to the appropriate object
            lastName = myLastName;//Can also do it this way by changing the var to match the current object
            this.eyeColor = eyeColor;
        }

        //parameterized constructor with FN, LN
        public Human(string firstName, string myLastName) 
        {
            this.firstName = firstName;//Using the this.keyword assigns the current value to the appropriate object
            lastName = myLastName;//Can also do it this way by changing the var to match the current object
        }

        //parameterized constructor with FN only
        public Human(string firstName) 
        {
            this.firstName = firstName;//Using the this.keyword assigns the current value to the appropriate object
        }

        //member method
        public void IntroduceMyself()
        {
            if (age != 0 && lastName != null && firstName != null && eyeColor != null){//If there is a number in the age field then does this if no number in age field does below
                Console.WriteLine("Hi, I'm {0} {1}. My eye color is {2}, and I am {3} years old", firstName, lastName, eyeColor, age);
            }
            else if (age == 0 && lastName != null && firstName != null && eyeColor != null) {
               Console.WriteLine("Hi, I'm {0} {1}. My eye color is {2}", firstName, lastName, eyeColor);
            }
            else if (age == 0 && lastName != null && firstName != null && eyeColor == null){
               Console.WriteLine("Hi, I'm {0} {1}.", firstName, lastName);
            }
            else if (age != 0 && lastName != null && firstName != null && eyeColor == null){
               Console.WriteLine("Hi, I'm {0} {1}. I am {2} years old", firstName, lastName, age);
            }
            else{
               Console.WriteLine("Hi, I'm {0}.", firstName);
            }
        }
    }
}
