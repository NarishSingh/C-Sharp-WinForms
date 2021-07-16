﻿using System.Globalization;
using System.Windows;
using System.Windows.Input;

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

        private void NumPadKeyPress(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
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
            }
        }
        
        /// <summary>
        /// Validate btn press and change display based on input
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
    }
}