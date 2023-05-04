using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace PR25_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double num1, num2;
            num1 = Convert.ToDouble(tb1.Text); //x
            num2 = Convert.ToDouble(tb2.Text); //a

            double result = Math.Pow(Math.E, -num1) * Math.Tan(num2) + Math.Pow(1 / Math.Tan(num1), 2)*Math.Pow((num2*num1), 3);
            ResultBlock.Text = result.ToString("0.00");   
        }
    }
}
