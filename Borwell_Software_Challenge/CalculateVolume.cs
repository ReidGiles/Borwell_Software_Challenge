using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borwell_Software_Challenge
{
    class CalculateVolume : PerformCalculation
    {
        /// <summary>
        /// Takes dimensions, returns volume.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public double Execute(double length, double width, double height)
        {
            // Calculate and return volume using dimensions
            return length * width * height;
        }
    }
}