using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borwell_Software_Challenge
{
    class CalculateArea : PerformCalculation
    {
        /// <summary>
        /// Takes dimensions, returns area.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public double Execute(double length, double width, double height)
        {
            // Calculate and return area using dimensions
            return height * width;
        }
    }
}