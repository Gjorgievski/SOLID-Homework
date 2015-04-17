using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLSP.TheGood
{
    /// <summary>
    /// Class for rectangle
    /// </summary>
    public class Rectangle:Shape
    {
        /// <summary>
        /// Calculate rectangle area
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            double area = Width * Height;

            return area;
        }
    }
}
