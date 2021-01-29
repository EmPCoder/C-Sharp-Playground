using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Basics
{
    //this class is a blueprint for a datatype

    //create a public variable lastName of type string.
    //change the IntroduceMyself method, so it tells the whole name.
    //create two objects with full information about themself- firstName and lastName

    class Human
    {
        //member variable
        public string firstName;//by adding public allows outside class access

        public string lastName;

        //member
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0}", firstName + lastName);
        }
    }
}
