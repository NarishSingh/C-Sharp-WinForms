using System.Globalization;
using System.Windows;
using System.Windows.Input;

namespace CalculatorWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private long _num1;
        private long _num2;
        private string _operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        /*NUM PAD EVENT HANDLERS*/
        private void Btn7_OnClick(object sender, RoutedEventArgs e)
        {
            ValidateNum(7);
        }

        private void Btn8_OnClick(object sender, RoutedEventArgs e)
        {
            ValidateNum(8);
        }

        private void Btn9_OnClick(object sender, RoutedEventArgs e)
        {
            ValidateNum(9);
        }

        private void Btn4_OnClick(object sender, RoutedEventArgs e)
        {
            ValidateNum(4);
        }

        private void Btn5_OnClick(object sender, RoutedEventArgs e)
        {
            ValidateNum(5);
        }

        private void Btn6_OnClick(object sender, RoutedEventArgs e)
        {
            ValidateNum(6);
        }

        private void Btn1_OnClick(object sender, RoutedEventArgs e)
        {
            ValidateNum(1);
        }

        private void Btn2_OnClick(object sender, RoutedEventArgs e)
        {
            ValidateNum(2);
        }

        private void Btn3_OnClick(object sender, RoutedEventArgs e)
        {
            ValidateNum(3);
        }

        private void Btn0_OnClick(object sender, RoutedEventArgs e)
        {
            ValidateNum(0);
        }

        /// <summary>
        /// KeyDown event handler for numpad presses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                //numpad
                case Key.NumPad0:
                    ValidateNum(0);
                    break;
                case Key.NumPad1:
                    ValidateNum(1);
                    break;
                case Key.NumPad2:
                    ValidateNum(2);
                    break;
                case Key.NumPad3:
                    ValidateNum(3);
                    break;
                case Key.NumPad4:
                    ValidateNum(4);
                    break;
                case Key.NumPad5:
                    ValidateNum(5);
                    break;
                case Key.NumPad6:
                    ValidateNum(6);
                    break;
                case Key.NumPad7:
                    ValidateNum(7);
                    break;
                case Key.NumPad8:
                    ValidateNum(8);
                    break;
                case Key.NumPad9:
                    ValidateNum(9);
                    break;
                //operations
                case Key.Add:
                    ValidateOperation("+");
                    break;
                case Key.Subtract:
                    ValidateOperation("-");
                    break;
                case Key.Multiply:
                    ValidateOperation("*");
                    break;
                case Key.Divide:
                    ValidateOperation("/");
                    break;
                case Key.Enter:
                    PerformOperation();
                    break;
                //typing
                case Key.Back: //todo not working
                    DeleteLastDigit();
                    break;
            }
        }

        /*OPERATION EVENT HANDLERS*/
        private void BtnPlus_OnClick(object sender, RoutedEventArgs e)
        {
            ValidateOperation("+");
        }

        private void BtnMinus_OnClick(object sender, RoutedEventArgs e)
        {
            ValidateOperation("-");
        }

        private void BtnTimes_OnClick(object sender, RoutedEventArgs e)
        {
            ValidateOperation("*");
        }

        private void BtnDivideBy_OnClick(object sender, RoutedEventArgs e)
        {
            ValidateOperation("/");
        }

        private void BtnEqual_OnClick(object sender, RoutedEventArgs e)
        {
            PerformOperation();
        }

        /*TYPING EVENT HANDLERS*/
        private void BtnClearEntry_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_operation))
            {
                _num1 = 0;
            }
            else
            {
                _num2 = 0;
            }

            TextDisplay.Text = "0";
        }

        private void BtnClear_OnClick(object sender, RoutedEventArgs e)
        {
            _num1 = 0;
            _num2 = 0;
            _operation = "";
            TextDisplay.Text = "0";
        }

        private void BtnBackspace_OnClick(object sender, RoutedEventArgs e)
        {
            DeleteLastDigit();
        }
        
        private void BtnNeg_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_operation))
            {
                _num1 *= -1;
                TextDisplay.Text = _num1.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                _num2 *= -1;
                TextDisplay.Text = _num2.ToString(CultureInfo.InvariantCulture);
            }
        }

        /*HELPERS*/
        /// <summary>
        /// Validate digit click and change display based on input
        /// </summary>
        /// <param name="num">digit to validate</param>
        private void ValidateNum(int num)
        {
            if (string.IsNullOrEmpty(_operation))
            {
                _num1 = _num1 * 10 + num; //shift over one place, then add the number clicked
                TextDisplay.Text = _num1.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                _num2 = _num2 * 10 + num;
                TextDisplay.Text = _num2.ToString(CultureInfo.InvariantCulture);
            }
        }

        /// <summary>
        /// Validate and store operation and reset display for 2nd number
        /// </summary>
        /// <param name="operation">operation to perform</param>
        private void ValidateOperation(string operation)
        {
            switch (operation)
            {
                case "+":
                    _operation = "+";
                    break;
                case "-":
                    _operation = "-";
                    break;
                case "/":
                    _operation = "/";
                    break;
                case "*":
                    _operation = "*";
                    break;
            }

            TextDisplay.Text = "0";
        }

        /// <summary>
        /// Perform the operation and display result to text box
        /// </summary>
        private void PerformOperation()
        {
            switch (_operation)
            {
                case "+":
                    TextDisplay.Text = (_num1 + _num2).ToString(CultureInfo.InvariantCulture);
                    break;
                case "-":
                    TextDisplay.Text = (_num1 - _num2).ToString(CultureInfo.InvariantCulture);
                    break;
                case "*":
                    TextDisplay.Text = (_num1 * _num2).ToString(CultureInfo.InvariantCulture);
                    break;
                case "/":
                    TextDisplay.Text = (_num1 / _num2).ToString(CultureInfo.InvariantCulture);
                    break;
            }
        }
        
        /// <summary>
        /// Erase the last digit from display
        /// </summary>
        private void DeleteLastDigit()
        {
            if (string.IsNullOrEmpty(_operation))
            {
                _num1 /= 10; //we want truncation here
                TextDisplay.Text = _num1.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                _num2 /= 10;
                TextDisplay.Text = _num2.ToString(CultureInfo.InvariantCulture);
            }
        }
    }
}