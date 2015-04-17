using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLSP.TheGood
{
    /// <summary>
    /// Abstract class for shape
    /// </summary>
    public abstract class Shape
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
        public abstract double Area();
        
    }
}
