using System.Globalization;
using System.Windows;

namespace CalculatorWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private double _num1 = 0;
        private double _num2 = 0;
        private string _operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        /*NUM PAD EVENT HANDLERS*/
        private void Btn7_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_operation))
            {
                _num1 = _num1 * 10 + 7; //shift over one place, then add the number clicked
                TextDisplay.Text = _num1.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                _num2 = _num2 * 10 + 7;
                TextDisplay.Text = _num2.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void Btn8_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_operation))
            {
                _num1 = _num1 * 10 + 8;
                TextDisplay.Text = _num1.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                _num2 = _num2 * 10 + 8;
                TextDisplay.Text = _num2.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void Btn9_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_operation))
            {
                _num1 = _num1 * 10 + 9;
                TextDisplay.Text = _num1.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                _num2 = _num2 * 10 + 9;
                TextDisplay.Text = _num2.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void Btn4_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_operation))
            {
                _num1 = _num1 * 10 + 4;
                TextDisplay.Text = _num1.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                _num2 = _num2 * 10 + 4;
                TextDisplay.Text = _num2.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void Btn5_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_operation))
            {
                _num1 = _num1 * 10 + 5;
                TextDisplay.Text = _num1.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                _num2 = _num2 * 10 + 5;
                TextDisplay.Text = _num2.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void Btn6_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_operation))
            {
                _num1 = _num1 * 10 + 6;
                TextDisplay.Text = _num1.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                _num2 = _num2 * 10 + 6;
                TextDisplay.Text = _num2.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void Btn1_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_operation))
            {
                _num1 = _num1 * 10 + 1;
                TextDisplay.Text = _num1.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                _num2 = _num2 * 10 + 1;
                TextDisplay.Text = _num2.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void Btn2_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_operation))
            {
                _num1 = _num1 * 10 + 2;
                TextDisplay.Text = _num1.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                _num2 = _num2 * 10 + 2;
                TextDisplay.Text = _num2.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void Btn3_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_operation))
            {
                _num1 = _num1 * 10 + 3;
                TextDisplay.Text = _num1.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                _num2 = _num2 * 10 + 3;
                TextDisplay.Text = _num2.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void Btn0_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_operation))
            {
                _num1 *= 10;
                TextDisplay.Text = _num1.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                _num2 *= 10;
                TextDisplay.Text = _num2.ToString(CultureInfo.InvariantCulture);
            }
        }
    }
}