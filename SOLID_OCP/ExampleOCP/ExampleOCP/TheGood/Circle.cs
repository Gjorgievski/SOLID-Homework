using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOCP.TheGood
{
    public class Circle:IShape
    {
        /// <summary>
        /// Circle radius
        /// </summary>
        public double Radius { get; set; }
        /// <summary>
        /// Calculating area of cicrle
        /// </summary>
        /// <returns>area of cirlce</returns>
        public double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
