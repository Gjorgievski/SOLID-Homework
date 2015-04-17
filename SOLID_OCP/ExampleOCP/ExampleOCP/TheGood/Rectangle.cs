using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOCP.TheGood
{
    public class Rectangle:IShape
    {
        /// <summary>
        /// Rectangle width
        /// </summary>
        public double Width { get; set; }
        /// <summary>
        /// Rectangle height
        /// </summary>
        public double Height { get; set; }
        /// <summary>
        /// Calculating area of rectangle
        /// </summary>
        /// <returns>area of rectangle</returns>
        public double Area()
        {
            return Width * Height;
        }
    }
}
