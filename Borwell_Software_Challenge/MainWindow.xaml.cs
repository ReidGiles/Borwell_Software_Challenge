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
        private int _length;
        private int _width;
        private int _height;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            GetDimensions();

            ICalculator calculator = new Calculator(new CalculateArea());
            lblArea.Content = "Area of floor: " + calculator.Calculate(_length, _width, _height).ToString();

            calculator = new Calculator(new CalculatePaintRequired());
            lblPaint.Content = "Paint required: " + calculator.Calculate(_length, _width, _height).ToString();

            calculator = new Calculator(new CalculateVolume());
            lblVolume.Content = "Volume of room: " + calculator.Calculate(_length, _width, _height).ToString();
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
            }

            if (txtHeight.Text != "")
            {
                _height = int.Parse(txtHeight.Text);
            }
            else
            {
                txtHeight.Text = "0";
            }

            if (txtWidth.Text != "")
            {
                _width = int.Parse(txtWidth.Text);
            }
            else
            {
                txtWidth.Text = "0";
            }
        }
    }
}