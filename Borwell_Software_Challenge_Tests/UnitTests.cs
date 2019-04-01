using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Borwell_Software_Challenge;

namespace Borwell_Software_Challenge_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            PerformCalculation perfCalc = new CalculateArea();
            ICalculator calculator = new Calculator(perfCalc);

            //Act
            try
            {

            }
            catch (ArgumentOutOfRangeException e)
            {

            }

            //Assert

        }
    }
}