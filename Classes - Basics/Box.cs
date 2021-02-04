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
        private int height; // Making Private allows only for adjustment inside this class
        //public int width;
        private int volume;

        public int Width { get; set; }

        public int Volume
        {
            get
            {
                return this.length * this.height * this.Width;
            }
            //Set doesnt make sense because it is calculated
            //set
            //{
            //    this.Volume = value;
            //}
        }

        //This below is the same as the above just short hand tab prop tab, tab creates this
        //public int Width
        //{
        //    get
        //    {
        //        return this.Width;
        //    }
        //    set
        //    {
        //        this.Width = value;
        //    }
        //}

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if(value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
                height = value;
            }
        }

        //If we wish to creat a box object then it will need these values
        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;

            //does not work (length = this.length);
        }

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

        //public void CalcFrontSurface()
        //{
        //    int frontSurface =  this.height * this.length;
        //    Console.WriteLine("The height is {0} and the length is {1} so the front surface is {2}", height, length, frontSurface);
        //}

        public int FrontSurface
        {
            get { return length * height; }
        }

        //public int GetVolume()
        //{
        //    return this.length * this.height * this.Width;
        //}

        //Method to display the information of the box and calculate volume
        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is => {3}", 
                length, height, Width, volume = length*height*Width);
            Console.ReadKey();
        }

    }
}
