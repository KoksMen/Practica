using System;
using System.Collections.Generic;
using System.IO;
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

namespace PR25_4
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

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            nameTextBox.Text = string.Empty;
            subspeciesTextBox.Text = string.Empty;
            lifespanTextBox.Text = string.Empty;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string name = nameTextBox.Text;
            string subspecies = subspeciesTextBox.Text;
            string lifespan = lifespanTextBox.Text;

            string data = $"{name}, {subspecies}, {lifespan}\n";

            string fileName = "mammals.txt";
            File.AppendAllText(fileName, data);

            MessageBox.Show("Данные сохранены в файл.");
        }
    }
}
