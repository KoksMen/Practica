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
using System.Windows.Shapes;

namespace PR26_3
{
    /// <summary>
    /// Логика взаимодействия для MammalDetailsWindow.xaml
    /// </summary>
    public partial class MammalDetailsWindow : Window
    {
        public MammalDetailsWindow(string selectedMammal)
        {
            InitializeComponent();
            string replacedSelectedMammal = selectedMammal.Replace("System.Windows.Controls.ComboBoxItem: ", "");
            DisplayMammalDetails(replacedSelectedMammal);
        }

        private void DisplayMammalDetails(string selectedMammal)
        {
            switch (selectedMammal)
            {
                case "Лев":
                    nameTextBlock.Text = "Наименование: Лев";
                    subspeciesTextBlock.Text = "Подвид: Panthera leo";
                    lifespanTextBlock.Text = "Продолжительность жизни: 10-14 лет";
                    break;
                case "Слон":
                    nameTextBlock.Text = "Наименование: Слон";
                    subspeciesTextBlock.Text = "Подвид: Elephas maximus";
                    lifespanTextBlock.Text = "Продолжительность жизни: 60-70 лет";
                    break;
                case "Тигр":
                    nameTextBlock.Text = "Наименование: Тигр";
                    subspeciesTextBlock.Text = "Подвид: Panthera tigris";
                    lifespanTextBlock.Text = "Продолжительность жизни: 8-10 лет";
                    break;
                case "Обезьяна":
                    nameTextBlock.Text = "Наименование: Обезьяна";
                    subspeciesTextBlock.Text = "Подвид: Cercopithecidae";
                    lifespanTextBlock.Text = "Продолжительность жизни: 20-30 лет";
                    break;
                case "Кит":
                    nameTextBlock.Text = "Наименование: Кит";
                    subspeciesTextBlock.Text = "Подвид: Balaenoptera physalus";
                    lifespanTextBlock.Text = "Продолжительность жизни: 70-90 лет";
                    break;
                default:
                    break;
            }
        }
    }
}

