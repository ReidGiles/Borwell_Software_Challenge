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
        /// Test condition Calculator(): throws ArgumentOutOfRangeException if doubles are negative
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
        /// Test condition Calculator(): throws ArgumentOutOfRangeException if doubles are negative
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
        /// Test condition Calculator(): Does not throw ArgumentOutOfRangeException if doubles are positive
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
        /// Test condition Calculator(): Does not throw ArgumentOutOfRangeException if doubles are positive
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
        /// Test condition MainWindow(): Does not throw FormatException if user enters incorrect types
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

        /// <summary>
        /// Test condition CalculateArea(): Accurately returns area using room dimensions
        /// </summary>
        [TestMethod]
        public void CalculateAreaTest1()
        {
            // Arrange
            Boolean pass = false;
            CalculateArea calcArea = new CalculateArea();
            double length = 20;
            double width = 30;
            double height = 50;

            // Act
            double area = calcArea.Execute(length, width, height);
            if (area == width * height)
            {
                pass = true;
            }

            // Assert
            Assert.IsTrue(pass, "Area was calculated incorrectly");
        }

        /// <summary>
        /// Test condition CalculatePaintRequired(): Accurately returns paint required using room dimensions
        /// </summary>
        [TestMethod]
        public void CalculatePaintRequired1()
        {
            // Arrange
            Boolean pass = false;
            CalculatePaintRequired calcPaint = new CalculatePaintRequired();
            double length = 20;
            double width = 30;
            double height = 50;

            // Act
            double paintRequired = calcPaint.Execute(length, width, height);
            if (paintRequired == Math.Round(( (height * width) + ((length *2 + width *2) * height) ) /350, 4 ) )
            {
                pass = true;
            }

            // Assert
            Assert.IsTrue(pass, "Paint required was calculated incorrectly");
        }

        /// <summary>
        /// Test condition CalculatePaintRequired(): Accurately returns paint required using room dimensions
        /// </summary>
        [TestMethod]
        public void CalculateVolume1()
        {
            // Arrange
            Boolean pass = false;
            CalculateVolume calcVolume = new CalculateVolume();
            double length = 20;
            double width = 30;
            double height = 50;

            // Act
            double volume = calcVolume.Execute(length, width, height);
            if (volume == length * width * height)
            {
                pass = true;
            }

            // Assert
            Assert.IsTrue(pass, "Volume was calculated incorrectly");
        }
    }
}