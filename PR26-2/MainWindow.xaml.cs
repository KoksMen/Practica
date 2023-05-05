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

namespace PR26_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] answers = { "Да", "Нет", "Возможно", "Попробуй еще раз", "Не могу сейчас предсказать" };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void PredictButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(questionTextBox.Text))
            {
                Random random = new Random();
                int index = random.Next(answers.Length);
                numberTextBlock.Text = index.ToString();
                resultTextBox.Text = answers[index];
            }
        }
    }
}
