using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borwell_Software_Challenge
{
    /// <summary>
    /// Used to perform calculations.
    /// Calculation logic stored in classes of type 'PerformCalculation'.
    /// </summary>
    class Calculator : ICalculator
    {
        private PerformCalculation calculation;
        /// <summary>
        /// Constructor: Sets calculation to passes parameter.
        /// </summary>
        /// <param name="pCalculation"></param>
        public Calculator(PerformCalculation pCalculation)
        {
            calculation = pCalculation;
        }
        /// <summary>
        /// Performs a calculation on room dimensions using the current strategy
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public double Calculate(double length, double width, double height)
        {
            // If dimensions are greater than or equal to '0'
            if (length >= 0 && width >= 0 && height >= 0)
            {
                // Perform and return calculation
                return calculation.Execute(length, width, height);
            }
            // Throw ArgumentOutOfRangeException exception
            else throw new ArgumentOutOfRangeException("Dimensions must not be negative");
        }
    }
}