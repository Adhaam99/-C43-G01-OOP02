using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Structs
{
    struct Recatngle
    {
        #region Attributes

        private double width;
        private double height;

        #endregion

        #region Properties
        public double Width

        {
            get { return width; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("The enterd value not correcrt");
                else
                    width = value;
            }

        }

        public double Height

        {
            get { return height; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("The enterd value not correcrt");
                else
                    height = value;
            }

        } 

        public double Area
        {
            get { return width * height; }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"Rectangle height is {height} , Width is {width} and area is { height * width}";
        }

        #endregion


    }
}
