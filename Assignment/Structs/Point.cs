using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Structs
{
    struct Point
    {
        

        #region Properties

        public int X { get; set; }
        public int Y { get; set; }

        #endregion

        #region Constructors

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static double distance(Point p1 , Point p2)
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

        }

        #endregion
    }
}
