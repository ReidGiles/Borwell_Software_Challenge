using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borwell_Software_Challenge
{
    class CalculatePaintRequired : PerformCalculation
    {
        /// <summary>
        /// Takes dimensions, returns paint required.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public double Execute(double length, double width, double height)
        {
            // Calculate and return paint required using dimensions
            double ceilingPaint = height * width;
            double wallPaint = (length *2 + width * 2) * height;
            double roomPaint = ceilingPaint + wallPaint;
            double gallons = (double)roomPaint / 350;
            gallons = Math.Round(gallons, 4);
            return gallons;
        }
    }
}