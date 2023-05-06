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

namespace PR27_2
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

        private void MenuItem_Task1_Click(object sender, RoutedEventArgs e)
        {
            // Задача 1: вычисление суммы цифр трехзначного числа
            int num = 0;
            if (int.TryParse(tb1.Text, out num) && num >= 100 && num <= 999)
            {
                int sum = num % 10 + (num / 10) % 10 + (num / 100) % 10;
                MessageBox.Show($"Сумма цифр числа {num} равна {sum}");
            }
            else
            {
                MessageBox.Show("Ошибка: введенное значение не является трехзначным числом.");
            }
        }

        private void MenuItem_Task2_Click(object sender, RoutedEventArgs e)
        {
            // Задача 2: удаление букв из имени
            string name = "Никита"; // замените на свое имя
            string inputStr = tb1.Text;
            string outputStr = inputStr.Replace(name, "");
            MessageBox.Show($"Результат: {outputStr}");
        }

        private void MenuItem_Task3_Click(object sender, RoutedEventArgs e)
        {
            // Задача 3: изменение цвета фона окна
            Color[] colors = { Colors.Red, Colors.Green, Colors.Blue };
            string[] colorNames = { "Красный", "Зеленый", "Синий" };
            int selectedIndex = Convert.ToInt32(tb1.Text);
            if (selectedIndex >= 0 && selectedIndex < colors.Length)
            {
                this.Background = new SolidColorBrush(colors[selectedIndex]);
            }
        }
    }
}
