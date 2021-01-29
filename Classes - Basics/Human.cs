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

    class Human
    {
        //member variable
        private string firstName;//by adding public allows outside class access
        private string lastName;
        private string eyeColor;
        private int age;

        //constructor to create a human object with params firstName, and lastName
        public Human(string firstName, string myLastName, string eyeColor, int age) 
        {
            this.firstName = firstName;//Using the this.keyword assigns the current value to the appropriate object
            lastName = myLastName;//Can also do it this way by changing the var to match the current object
            this.eyeColor = eyeColor;
            this.age = age;
        }

        //member method
        public void IntroduceMyself()
        {
            if (age == 1){
                Console.WriteLine("Hi, I'm {0} {1}. My eye color is {2}, and I am {3} year old", firstName, lastName, eyeColor, age);
            }
            else {
               Console.WriteLine("Hi, I'm {0} {1}. My eye color is {2}, and I am {3} years old", firstName, lastName, eyeColor, age);
            }
        }
    }
}
