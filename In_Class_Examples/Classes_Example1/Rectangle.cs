using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Example1
{
    public class Rectangle
    {

        //private double _Width;

        //public double GetWidth()
        //{
        //    return _Width;
        //}

        //public void SetWidth(double width)
        //{
        //    _Width = width;
        //}

        public double Width { get; set; }
        public double Length { get; set; }

        /// <summary>
        /// Overloaded constructor, where we know what values we want to start the width and length to
        /// </summary>
        /// <param name="width">Width of this rectangle</param>
        /// <param name="length">Length of this rectangle</param>
        public Rectangle(double width, double length)
        {
            this.Width = width;
            Length = length;
        }

        /// <summary>
        /// Default/Empty constructor that sets this instance of a Rectangle to starting values
        /// </summary>
        public Rectangle()
        {
            Width = 5;
            Length = 5;
        }

        /// <summary>
        /// Calculates the Area of this Rectangle
        /// </summary>
        /// <returns>The area of this Rectangle</returns>
        public double CalculateArea()
        {
            return Length * Width;
        }

        /// <summary>
        /// Calculates the Perimeter of this Rectangle
        /// </summary>
        /// <returns>The perimeter of this Rectangle</returns>
        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }
    }
}
