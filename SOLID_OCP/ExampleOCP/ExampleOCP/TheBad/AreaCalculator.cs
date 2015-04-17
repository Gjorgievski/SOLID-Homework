using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOCP.TheBad
{
    /// <summary>
    /// Class for calculating total area of array of geometric shapes
    /// if we want to calculate aren of other kind of shape we must change this class and add specific functionality
    /// AreaCalculator isn’t closed for modification as we need to change it in order to extend it,
    /// it isn’t open for extension
    /// </summary>
    public class AreaCalculator
    {
        /// <summary>
        /// Calculating total area of a array of shapes
        /// </summary>
        /// <param name="shapes">array of geometric shapes</param>
        /// <returns>total area of this shapes</returns>
        public double Area(object[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                if (shape is Rectangle)
                {
                    Rectangle rectangle = (Rectangle)shape;
                    area += rectangle.Width * rectangle.Height;
                }
                else if(shape is Circle)
                {
                    Circle circle = (Circle)shape;
                    area += circle.Radius * circle.Radius * Math.PI;
                }
            }

            return area;
        }
    }
}
