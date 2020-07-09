using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Globalization;
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

namespace TaschenRechner
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void closeApp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void minimizeApp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.WindowState = WindowState.Minimized;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void DragMe(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            textDisplay.Text += b.Content.ToString();
            log.Text += b.Content.ToString();
        }
        private void btnClearAll_Click(object sender, RoutedEventArgs e)
        {
            textDisplay.Clear();
            log.Clear();
        }
        private void btnClearLast_Click(object sender, RoutedEventArgs e)
        {
            if (textDisplay.Text.Length > 0)
            {
                textDisplay.Text = textDisplay.Text.Substring(0, textDisplay.Text.Length - 1);
                log.Text = log.Text.Substring(0, log.Text.Length - 1);
            }
        }
        // TaschenRechner Buttons
        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                result();
            }
            catch (Exception exc)
            {
                textDisplay.Text = "Error!";
            }
        }
        // Operations
        public void result()
        {
            double sum = 0;

            String op;
            int iOp = 0;
            if (textDisplay.Text.Contains("+"))
            {
                iOp = textDisplay.Text.IndexOf("+");
            }
            else if (textDisplay.Text.Contains("-"))
            {
                iOp = textDisplay.Text.IndexOf("-");
            }
            else if (textDisplay.Text.Contains("*"))
            {
                iOp = textDisplay.Text.IndexOf("*");
            }
            else if (textDisplay.Text.Contains("/"))
            {
                iOp = textDisplay.Text.IndexOf("/");
            }
            else if (textDisplay.Text.Contains("^"))
            {
                iOp = textDisplay.Text.IndexOf("^");
            }


            CultureInfo culture = new CultureInfo("de"); // I'm assuming german here.
            op = textDisplay.Text.Substring(iOp, 1);
            double op1 = double.Parse(textDisplay.Text.Substring(0,iOp),culture);
            double op2 = double.Parse(textDisplay.Text.Substring(iOp + 1, textDisplay.Text.Length - iOp - 1),culture);


            if (op == "+")
            {
                sum = op1 + op2;
                textDisplay.Text = sum.ToString();
            }
            else if (op == "-")
            {
                sum = op1 - op2;
                textDisplay.Text = sum.ToString();
                log.Text += textDisplay.Text;
            }
            else if (op == "*")
            {
                sum = op1 * op2;
                textDisplay.Text = sum.ToString();
            }
            else if (op == "^")
            {
                double temp = 1;
                for (int i = 1; i <= op2; i++)
                {
                    temp = temp * op1;
                }               
                textDisplay.Text = temp.ToString();
            }
            else
            {
                sum = op1 / op2;
                textDisplay.Text = sum.ToString();
            }
        }
        // Tobinary
        private void binary_Click(object sender, RoutedEventArgs e)
        {
            var input = Convert.ToInt32(textDisplay.Text);
            string output = Convert.ToString(input, 2);
            textDisplay.Text = output;
        }
        // Tohex
        private void hex_Click(object sender, RoutedEventArgs e)
        {
            var input = Convert.ToInt32(textDisplay.Text);

            if (input < 1) textDisplay.Text = "0";

            int hex = input;
            string hexStr = string.Empty;

            while (input > 0)
            {
                hex = input % 16;

                if (hex < 10)
                    hexStr = hexStr.Insert(0, Convert.ToChar(hex + 48).ToString());
                else
                    hexStr = hexStr.Insert(0, Convert.ToChar(hex + 55).ToString());

                input /= 16;
            }

            textDisplay.Text = hexStr;

        }
        // ToDecimal
        private void Decimal_Click(object sender, RoutedEventArgs e)
        {
            var input = Convert.ToInt32(textDisplay.Text, 2).ToString();

            textDisplay.Text = input;
        }
    }
}
