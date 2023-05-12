using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace PR31_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=CookiesDB;Integrated Security=True";

        public MainWindow()
        {
            InitializeComponent();
            LoadDishes();
        }

        private void LoadDishes()
        {
            string sqlExpression = "sp_GetDishes";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();

                List<Dish> dishes = new List<Dish>();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int code = reader.GetInt32(0);
                        string dishType = reader.GetString(1);
                        int dishWeight = reader.GetInt32(2);
                        string preparationOrder = reader.GetString(3);
                        int caloryCount = reader.GetInt32(4);
                        int carbCount = reader.GetInt32(5);

                        Dish dish = new Dish()
                        {
                            Code = code,
                            DishType = dishType,
                            DishWeight = dishWeight,
                            PreparationOrder = preparationOrder,
                            CaloryCount = caloryCount,
                            CarbCount = carbCount
                        };

                        dishes.Add(dish);
                    }
                }

                reader.Close();

                dgvDishes.ItemsSource = dishes;
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (dgvDishes.SelectedItem != null)
            {
                Dish selectedDish = dgvDishes.SelectedItem as Dish;
                int dishCode = selectedDish.Code;

                string newDishType = txtNewDishType.Text;
                int newDishWeight = int.Parse(txtNewDishWeight.Text);
                string newPreparationOrder = txtNewPreparationOrder.Text;
                int newCaloryCount = int.Parse(txtNewCaloryCount.Text);
                int newCarbCount = int.Parse(txtNewCarbCount.Text);

                UpdateDish(dishCode, newDishType, newDishWeight, newPreparationOrder, newCaloryCount, newCarbCount);
                LoadDishes();
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (dgvDishes.SelectedItem != null)
            {
                Dish selectedDish = dgvDishes.SelectedItem as Dish;
                int dishCode = selectedDish.Code;

                DeleteDish(dishCode);
                LoadDishes();
            }
        }

        private void UpdateDish(int dishCode, string dishType, int dishWeight, string preparationOrder, int caloryCount, int carbCount)
        {
            string sqlExpression = "sp_UpdateDish";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter dishCodeParam = new SqlParameter
                {
                    ParameterName = "@DishCode",
                    Value = dishCode
                };
                command.Parameters.Add(dishCodeParam);

                SqlParameter dishTypeParam = new SqlParameter
                {
                    ParameterName = "@DishType",
                    Value = dishType
                };
                command.Parameters.Add(dishTypeParam);

                SqlParameter dishWeightParam = new SqlParameter
                {
                    ParameterName = "@DishWeight",
                    Value = dishWeight
                };
                command.Parameters.Add(dishWeightParam);

                SqlParameter preparationOrderParam = new SqlParameter
                {
                    ParameterName = "@PreparationOrder",
                    Value = preparationOrder
                };
                command.Parameters.Add(preparationOrderParam);

                SqlParameter caloryCountParam = new SqlParameter
                {
                    ParameterName = "@CaloryCount",
                    Value = caloryCount
                };
                command.Parameters.Add(caloryCountParam);

                SqlParameter carbCountParam = new SqlParameter
                {
                    ParameterName = "@CarbCount",
                    Value = carbCount
                };
                command.Parameters.Add(carbCountParam);

                var result = command.ExecuteScalar();

                MessageBox.Show("Id измененного объекта: " + result);
            }
        }

        private void DeleteDish(int dishCode)
        {
            string sqlExpression = "sp_DeleteDish";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter dishCodeParam = new SqlParameter
                {
                    ParameterName = "@DishCode",
                    Value = dishCode
                };
                command.Parameters.Add(dishCodeParam);

                var result = command.ExecuteNonQuery();

                MessageBox.Show("Количество удаленных объектов: " + result);
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string dishType = txtDishType.Text;
            int dishWeight = int.Parse(txtDishWeight.Text);
            string preparationOrder = txtPreparationOrder.Text;
            int caloryCount = int.Parse(txtCaloryCount.Text);
            int carbCount = int.Parse(txtCarbCount.Text);

            AddDish(dishType, dishWeight, preparationOrder, caloryCount, carbCount);
            LoadDishes();
        }

        private void AddDish(string dishType, int dishWeight, string preparationOrder, int caloryCount, int carbCount)
        {
            string sqlExpression = "sp_InsertDish";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter dishTypeParam = new SqlParameter
                {
                    ParameterName = "@DishType",
                    Value = dishType
                };
                command.Parameters.Add(dishTypeParam);

                SqlParameter dishWeightParam = new SqlParameter
                {
                    ParameterName = "@DishWeight",
                    Value = dishWeight
                };
                command.Parameters.Add(dishWeightParam);

                SqlParameter preparationOrderParam = new SqlParameter
                {
                    ParameterName = "@PreparationOrder",
                    Value = preparationOrder
                };
                command.Parameters.Add(preparationOrderParam);

                SqlParameter caloryCountParam = new SqlParameter
                {
                    ParameterName = "@CaloryCount",
                    Value = caloryCount
                };
                command.Parameters.Add(caloryCountParam);

                SqlParameter carbCountParam = new SqlParameter
                {
                    ParameterName = "@CarbCount",
                    Value = carbCount
                };
                command.Parameters.Add(carbCountParam);

                var result = command.ExecuteScalar();

                MessageBox.Show("Id добавленного объекта: " + result);
            }
        }
    }

    public class Dish
    {
        public int Code { get; set; }
        public string DishType { get; set; }
        public int DishWeight { get; set; }
        public string PreparationOrder { get; set; }
        public int CaloryCount { get; set; }
        public int CarbCount { get; set; }
    }

    
} 

