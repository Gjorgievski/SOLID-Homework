using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLSP.TheBad
{
    /// <summary>
    /// Class for Rectangle that extend Rectangle
    /// </summary>
    public class Square:Rectangle
    {
        /// <summary>
        /// Overrided property for height of square
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
        /// Overrided property for width of square
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
    }
}
