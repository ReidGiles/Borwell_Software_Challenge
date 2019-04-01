using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borwell_Software_Challenge
{
    class CalculatePaintRequired : PerformCalculation
    {
        public double Execute(double length, double width, double height)
        {
            double ceilingPaint = height * width;
            double wallPaint = (length + width) * height;
            double roomPaint = ceilingPaint + wallPaint;
            double gallons = (double)roomPaint / 350;
            gallons = Math.Round(gallons, 4);
            return gallons;
        }
    }
}
