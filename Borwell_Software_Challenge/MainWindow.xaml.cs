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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve dimensions from interface
            GetDimensions();

            // Instantiate calculator, pass in the area strategy
            ICalculator calculator = new Calculator(new CalculateArea());
            // Output area calculation
            lblArea.Content = "Area of floor: " + calculator.Calculate(_length, _width, _height).ToString() + " ft2";

            // Instantiate calculator, pass in the paint strategy
            calculator = new Calculator(new CalculatePaintRequired());
            // Output paint calculation
            lblPaint.Content = "Paint required: " + calculator.Calculate(_length, _width, _height).ToString() + " gallons";

            // Instantiate calculator, pass in the volume strategy
            calculator = new Calculator(new CalculateVolume());
            // Output volume calculation
            lblVolume.Content = "Volume of room: " + calculator.Calculate(_length, _width, _height).ToString() + " ft3";
        }

        private void GetDimensions()
        {
            if (txtLength.Text != "")
            {
                _length = int.Parse(txtLength.Text);
            }
            else
            {
                txtLength.Text = "0";
                _length = 0;
            }

            if (txtHeight.Text != "")
            {
                _height = int.Parse(txtHeight.Text);
            }
            else
            {
                txtHeight.Text = "0";
                _height = 0;
            }

            if (txtWidth.Text != "")
            {
                _width = int.Parse(txtWidth.Text);
            }
            else
            {
                txtWidth.Text = "0";
                _width = 0;
            }
        }
    }
}