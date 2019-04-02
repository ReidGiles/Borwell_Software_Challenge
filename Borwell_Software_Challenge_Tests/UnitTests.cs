using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Borwell_Software_Challenge;
using System.Windows;
using System.Windows.Controls;

namespace Borwell_Software_Challenge_Tests
{
    [TestClass]
    public class UnitTests
    {
        /// <summary>
        /// Test condition Calculate(): throws ArgumentOutOfRangeException if doubles are negative
        /// </summary>
        [TestMethod]
        public void CalculateTest1()
        {
            // Arrange
            Boolean pass = false;
            PerformCalculation perfCalc = new CalculateArea();
            ICalculator calculator = new Calculator(perfCalc);

            // Act
            try
            {
                calculator.Calculate(-5, -5, -5);
            }
            catch (ArgumentOutOfRangeException)
            {
                pass = true;
            }

            // Assert
            Assert.IsTrue(pass, "ArgumentOutOfRangeException was not thrown when Calculate(-5,-5,-5) was called");
        }

        /// <summary>
        /// Test condition Calculate(): throws ArgumentOutOfRangeException if doubles are negative
        /// </summary>
        [TestMethod]
        public void CalculateTest2()
        {
            // Arrange
            Boolean pass = false;
            PerformCalculation perfCalc = new CalculateArea();
            ICalculator calculator = new Calculator(perfCalc);

            // Act
            try
            {
                calculator.Calculate(-50, -50, -50);
            }
            catch (ArgumentOutOfRangeException)
            {
                pass = true;
            }

            // Assert
            Assert.IsTrue(pass, "ArgumentOutOfRangeException was not thrown when Calculate(-50,-50,-50) was called");
        }

        /// <summary>
        /// Test condition Calculate(): Does not throw ArgumentOutOfRangeException if doubles are positive
        /// </summary>
        [TestMethod]
        public void CalculateTest3()
        {
            // Arrange
            Boolean pass = false;
            PerformCalculation perfCalc = new CalculateArea();
            ICalculator calculator = new Calculator(perfCalc);

            // Act
            try
            {
                calculator.Calculate(5, 5, 5);
            }
            catch (ArgumentOutOfRangeException)
            {
                pass = true;
            }

            // Assert
            Assert.IsFalse(pass, "ArgumentOutOfRangeException was thrown when Calculate(5, 5, 5) was called");
        }

        /// <summary>
        /// Test condition Calculate(): Does not throw ArgumentOutOfRangeException if doubles are positive
        /// </summary>
        [TestMethod]
        public void CalculateTest4()
        {
            // Arrange
            Boolean pass = false;
            PerformCalculation perfCalc = new CalculateArea();
            ICalculator calculator = new Calculator(perfCalc);
            // Act
            try
            {
                calculator.Calculate(50, 50, 50);
            }
            catch (ArgumentOutOfRangeException)
            {
                pass = true;
            }

            // Assert
            Assert.IsFalse(pass, "ArgumentOutOfRangeException was thrown when Calculate(50, 50, 50) was called");
        }

        /// <summary>
        /// Test condition Calculate(): Does not throw FormatException if user enters incorrect types
        /// </summary>
        [TestMethod]
        public void GetDimensionsTest1()
        {
            // Arrange
            MainWindow mainWindow = new MainWindow();

            // Act
            try
            {
                mainWindow.txtLength.Text = "f";
                mainWindow.txtWidth.Text = "f";
                mainWindow.txtHeight.Text = "f";
                mainWindow.btnCalculate.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            catch (FormatException)
            {
                // Assert
                Assert.Fail("Incorrect user input was not handled");
            }
        }
    }
}