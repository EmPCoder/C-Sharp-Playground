using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Basics
{
    class Box
    {
        //Member variables
        private int length = 3;
        public int height;
        public int width;
        public int volume;

        //changes the length to the current object and sets it to length by keeping public allows anyone to set this, if private on classes that inherit from this
        public void SetLength(int length)
        {
            if(length < 0)
            {
                throw new Exception("Length should be higher than 0");
            }
            this.length = length;
        }

        //Gets the length that is set using the Set above
        public int GetLength()
        {
            return this.length;
        }

        public int GetVolume()
        {
            return this.length * this.height * this.width;
        }

        //Method to display the information of the box and calculate volume
        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is => {3}", 
                length, height, width, volume = length*height*width);
            Console.ReadKey();
        }

    }
}
