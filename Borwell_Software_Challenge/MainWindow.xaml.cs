using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Borwell_Software_Challenge
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _length;
        private double _width;
        private double _height;

        private double _area;
        private double _paint;
        private double _volume;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            // Attempt to retrieve dimensions from user interface
            try
            {
                GetDimensions();
            }
            // Catch input type error, prompt user to try again
            catch (FormatException)
            {
                MessageBoxResult error = MessageBox.Show("Please input numbers only");
            }

            // Instantiate calculator, pass in the area strategy
            ICalculator calculator = new Calculator(new CalculateArea());
            // Calculate area using input dimensions, store in '_area'
            _area = calculator.Calculate(_length, _width, _height);

            // Instantiate calculator, pass in the paint strategy
            calculator = new Calculator(new CalculatePaintRequired());
            // Calculate paint required using input dimensions, store in '_paint'
            _paint = calculator.Calculate(_length, _width, _height);

            // Instantiate calculator, pass in the volume strategy
            calculator = new Calculator(new CalculateVolume());
            // Calculate volume using input dimensions, store in '_volume'
            _volume = calculator.Calculate(_length, _width, _height);

            // Output results
            lblArea.Content = "Area of floor: " + _area.ToString() + " ft2";
            lblPaint.Content = "Paint required: " + _paint.ToString() + " gallons";
            lblVolume.Content = "Volume of room: " + _volume.ToString() + " ft3";
        }
        /// <summary>
        /// Set instance variables '_length', '_width' and '_height' based on user input.
        /// If user input is blank, default to '0'.
        /// </summary>
        private void GetDimensions()
        {
            // If txtLength is not blank
            if (txtLength.Text != "")
            {
                // Convert txtLength.Text to a double and store in '_length'
                _length = double.Parse(txtLength.Text);
            }
            else
            {
                // Return to defaults
                txtLength.Text = "0";
                _length = 0;
            }
            // If txtHeight is not blank
            if (txtHeight.Text != "")
            {
                // Convert txtHeight.Text to a double and store in '_height'
                _height = double.Parse(txtHeight.Text);
            }
            else
            {
                // Return to defaults
                txtHeight.Text = "0";
                _height = 0;
            }
            // If txtWidth is not blank
            if (txtWidth.Text != "")
            {
                // Convert txtWidth to a double and store in '_width'
                _width = double.Parse(txtWidth.Text);
            }
            else
            {
                // Return to defaults
                txtWidth.Text = "0";
                _width = 0;
            }
        }
    }
}