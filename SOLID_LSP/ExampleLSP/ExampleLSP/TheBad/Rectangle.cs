using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLSP.TheBad
{
    /// <summary>
    /// Class for rectangle
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Rectangle Width
        /// </summary>
        public virtual double Width { get; set; }
        /// <summary>
        /// Rectangle height
        /// </summary>
        public virtual double Height { get; set; }

        /// <summary>
        /// Calculate area of rectangle
        /// </summary>
        /// <returns></returns>
        public double Area()
        {
            double area = Width * Height;

            return area;
        }
    }
}
