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

namespace PR26_1
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
            if (tb1.Text == "6")
                tb2.Text = "Шесть";
            else if (tb1.Text == "Сколько времени?")
                tb2.Text = DateTime.Now.ToString("HH:m:ss");
            else if (tb1.Text == "Кто я?")
                tb2.Text = "Нишпор Никита Фёдорович";
            else
                tb2.Text = "Дейтвие для данного текста, не предусмотрено";
        }
    }
}
