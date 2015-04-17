using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLSP.TheGood
{
    /// <summary>
    /// Class for square
    /// </summary>
    public class Square:Shape
    {
        /// <summary>
        /// Overrided propertu for square height
        /// </summary>
        public override double Height
        {
            get
            {
                return base.Height;
            }
            set
            {
                setWidthAndHeight(value);
            }
        }
        /// <summary>
        /// Overrided propertu for square width
        /// </summary>
        public override double Width
        {
            get
            {
                return base.Width;
            }
            set
            {
                setWidthAndHeight(value);
            }
        }

        /// <summary>
        /// Both sides of a square are equal.
        /// </summary>
        /// <param name="value">width or height</param>
        private void setWidthAndHeight(double value)
        {
            base.Height = value;
            base.Width = value;
        }

        /// <summary>
        /// Calculate square area
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return Height * Width;
        }
    }
}
