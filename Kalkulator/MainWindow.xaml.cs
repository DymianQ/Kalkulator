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

namespace Kalkulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ResaultText.Text = string.Empty;
            CurrentOperationText.Text = string.Empty;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResaultText.Text = string.Empty;
            var button = sender as Button;
            var currentNumber = button.Name[button.Name.Length - 1];
            CurrentOperationText.Text += currentNumber; 
        }
        private void Button_Add(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;
            if(ContainsOperation(operation))
            {
                CurrentOperationText.Text = calculateResult(operation).ToString();
            }
            CurrentOperationText.Text += "+";
        }
        private void Button_Minus(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;
            if (ContainsOperation(operation))
            {
                CurrentOperationText.Text = calculateResult(operation).ToString();
            }
            CurrentOperationText.Text += "-";
        }

        private void Button_Multiplication(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;
            if (ContainsOperation(operation))
            {
                CurrentOperationText.Text = calculateResult(operation).ToString();
            }
            CurrentOperationText.Text += "*";
        }

        private void Button_Division(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;
            if (ContainsOperation(operation))
            {
                CurrentOperationText.Text = calculateResult(operation).ToString();
            }
            CurrentOperationText.Text += "/";
        }

        private void Button_Result(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;

            ResaultText.Text = calculateResult(operation).ToString();
            
            CurrentOperationText.Text = string.Empty;
        }

        private bool ContainsOperation(string operation) => operation.Contains("+") || operation.Contains("-") || operation.Contains("*") || operation.Contains("/");
       
        private int calculateResult(string operation)
        {
            if (operation.Contains('+'))
            {
                var elements = operation.Split('+');

                return int.Parse(elements[0]) + int.Parse(elements[1]);
            }
            if (operation.Contains('-'))
            {
                var elements = operation.Split('-');

                return int.Parse(elements[0]) - int.Parse(elements[1]);

            }
            if (operation.Contains('*'))
            {
                var elements = operation.Split('*');

                return int.Parse(elements[0]) * int.Parse(elements[1]);
            }
            if (operation.Contains('/'))
            {
                var elements = operation.Split('/');

                return int.Parse(elements[0]) / int.Parse(elements[1]);
            }

            return 0;
             
        }
    }
}
