using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOCP.TheGood
{
    /// <summary>
    /// Class for calculating total area of array of geometric shapes
    /// it is now much simpler and robust as it can handle any type of Shape that we throw at it
    /// we’ve closed it for modification by opening it up for extension
    /// </summary>
    public class AreaCalculator
    {
        /// <summary>
        /// Calculating total area for array of shapes
        /// </summary>
        /// <param name="shapes">array of shapes</param>
        /// <returns>total area</returns>
        public double Area(IShape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }

            return area;
        }
    }
}
