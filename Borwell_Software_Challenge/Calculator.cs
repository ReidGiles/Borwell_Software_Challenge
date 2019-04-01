using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borwell_Software_Challenge
{
    class Calculator : ICalculator
    {
        private PerformCalculation calculation;

        public Calculator(PerformCalculation pCalculation)
        {
            calculation = pCalculation;
        }

        public double Calculate(double length, double width, double height)
        {
            if (length >= 0 && width >= 0 && height >= 0)
            {
                return calculation.Execute(length, width, height);
            }
            else throw new ArgumentOutOfRangeException("Dimensions must not be negative");
        }
    }
}
