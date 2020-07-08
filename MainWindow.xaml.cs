using System;
using System.Collections.Generic;
using System.Data.Odbc;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long firstNumber = 0;
        long secoNumber = 0;
        string operation = "";


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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation =="")
            {
            firstNumber = (firstNumber*10)+ 1;
            textDisplay.Text = firstNumber.ToString();
            }
            else
            {
                secoNumber = (secoNumber * 10) + 1;
                textDisplay.Text = secoNumber.ToString();

            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                firstNumber = (firstNumber * 10) + 2;
                textDisplay.Text = firstNumber.ToString();
            }
            else
            {
                secoNumber = (secoNumber * 10) + 2;
                textDisplay.Text = secoNumber.ToString();

            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                firstNumber = (firstNumber * 10) + 3;
                textDisplay.Text = firstNumber.ToString();
            }
            else
            {
                secoNumber = (secoNumber * 10) + 3;
                textDisplay.Text = secoNumber.ToString();

            }

        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                firstNumber = (firstNumber * 10) + 4;
                textDisplay.Text = firstNumber.ToString();
            }
            else
            {
                secoNumber = (secoNumber * 10) + 4;
                textDisplay.Text = secoNumber.ToString();

            }

        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                firstNumber = (firstNumber * 10) + 5;
                textDisplay.Text = firstNumber.ToString();
            }
            else
            {
                secoNumber = (secoNumber * 10) + 5;
                textDisplay.Text = secoNumber.ToString();

            }

        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                firstNumber = (firstNumber * 10) + 6;
                textDisplay.Text = firstNumber.ToString();
            }
            else
            {
                secoNumber = (secoNumber * 10) + 6;
                textDisplay.Text = secoNumber.ToString();

            }

        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                firstNumber = (firstNumber * 10) + 7;
                textDisplay.Text = firstNumber.ToString();
            }
            else
            {
                secoNumber = (secoNumber * 10) + 7;
                textDisplay.Text = secoNumber.ToString();

            }

        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                firstNumber = (firstNumber * 10) + 8;
                textDisplay.Text = firstNumber.ToString();
            }
            else
            {
                secoNumber = (secoNumber * 10) + 8;
                textDisplay.Text = secoNumber.ToString();

            }

        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                firstNumber = (firstNumber * 10) + 9;
                textDisplay.Text = firstNumber.ToString();
            }
            else
            {
                secoNumber = (secoNumber * 10) + 9;
                textDisplay.Text = secoNumber.ToString();

            }
        }
        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                firstNumber = (firstNumber * 10);
                textDisplay.Text = firstNumber.ToString();
            }
            else
            {
                secoNumber = (secoNumber * 10);
                textDisplay.Text = secoNumber.ToString();

            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            textDisplay.Text = "0";
        }

        private void btnMal_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            textDisplay.Text = "0";

        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            textDisplay.Text = "0";

        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            textDisplay.Text = "0";

        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textDisplay.Text = (firstNumber + secoNumber).ToString();
                    break;
                case "-":
                    textDisplay.Text = (firstNumber - secoNumber).ToString();
                    break;
                case "*":
                    textDisplay.Text = (firstNumber * secoNumber).ToString();
                    break;
                case "/":
                    textDisplay.Text = (firstNumber / secoNumber).ToString();
                    break;
            }
        }

        private void btnClearAll_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = 0;
            secoNumber = 0;
            operation = "";
            textDisplay.Text = "0";
        }

        private void btnClearLast_Click(object sender, RoutedEventArgs e)
        {

            if (operation == "")
            {
                firstNumber = (firstNumber / 10);
                textDisplay.Text = firstNumber.ToString();
            }
            else
            {
                secoNumber = (secoNumber / 10);
                textDisplay.Text = secoNumber.ToString();

            }


        }
    }
}
