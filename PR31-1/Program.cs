using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR31_1
{
    internal class Program
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=CookiesDB;Integrated Security=True";
        static void Main(string[] args)
        {
            Console.Write("Введите тип блюда:");
            string DishType = Console.ReadLine();

            Console.Write("Введите вес блюда:");
            int DishWeight = Int32.Parse(Console.ReadLine());

            Console.Write("Введите порядок приготовления блюда:");
            string PreparationOrder = Console.ReadLine();

            Console.Write("Введите количество калорий блюда:");
            int CaloryCount = Int32.Parse(Console.ReadLine());

            Console.Write("Введите количество углеводов блюда:");
            int CarbCount = Int32.Parse(Console.ReadLine());

            AddDish(DishType, DishWeight, PreparationOrder, CaloryCount, CarbCount);
            Console.WriteLine();
            GetDishes();


            Console.Write("Введите код блюда:");
            int DishCode = Int32.Parse(Console.ReadLine());

            Console.Write("Введите новый тип блюда:");
            string newDishType = Console.ReadLine();

            Console.Write("Введите новый вес блюда:");
            int newDishWeight = Int32.Parse(Console.ReadLine());

            Console.Write("Введите новый порядок приготовления блюда:");
            string newPreparationOrder = Console.ReadLine();

            Console.Write("Введите новое количество калорий блюда:");
            int newCaloryCount = Int32.Parse(Console.ReadLine());

            Console.Write("Введите новое количество углеводов блюда:");
            int newCarbCount = Int32.Parse(Console.ReadLine());

            UpdateDish(DishCode, newDishType, newDishWeight, newPreparationOrder, newCaloryCount, newCarbCount);

            Console.Clear();
            GetDishes();


            Console.Write("Введите код блюда для удаления:");
            int deleteDishCode = Int32.Parse(Console.ReadLine());

            DeleteDish(deleteDishCode);

            Console.Clear();
            GetDishes();

            Console.Read();
        }

        // добавление блюда
        private static void AddDish(string dishType, int dishWeight, string preparationOrder, int caloryCount, int carbCount)
        {
            // название процедуры
            string sqlExpression = "sp_InsertDish";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода типа блюда
                SqlParameter dishTypeParam = new SqlParameter
                {
                    ParameterName = "@DishType",
                    Value = dishType
                };
                // добавляем параметр
                command.Parameters.Add(dishTypeParam);
                // параметр для ввода веса блюда
                SqlParameter dishWeightParam = new SqlParameter
                {
                    ParameterName = "@DishWeight",
                    Value = dishWeight
                };
                command.Parameters.Add(dishWeightParam);
                
                // параметр для ввода порядка приготовления блюда
                SqlParameter preparationOrderParam = new SqlParameter
                {
                    ParameterName = "@PreparationOrder",
                    Value = preparationOrder
                };
                command.Parameters.Add(preparationOrderParam);
                
                // параметр для ввода количества калорий блюда
                SqlParameter caloryCountParam = new SqlParameter
                {
                    ParameterName = "@CaloryCount",
                    Value = caloryCount
                };
                command.Parameters.Add(caloryCountParam);
                
                // параметр для ввода количества углеводов блюда
                SqlParameter carbCountParam = new SqlParameter
                {
                    ParameterName = "@CarbCount",
                    Value = carbCount
                };
                command.Parameters.Add(carbCountParam);

                var result = command.ExecuteScalar();
                // если нам не надо возвращать id
                //var result = command.ExecuteNonQuery();

                Console.WriteLine("Id добавленного объекта: {0}", result);
            }
        }

        // изменение блюда
        private static void UpdateDish(int dishCode, string dishType, int dishWeight, string preparationOrder, int caloryCount, int carbCount)
        {
            // название процедуры
            string sqlExpression = "sp_UpdateDish";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода кода блюда
                SqlParameter dishCodeParam = new SqlParameter
                {
                    ParameterName = "@DishCode",
                    Value = dishCode
                };
                // добавляем параметр
                command.Parameters.Add(dishCodeParam);
                // параметр для ввода типа блюда
                SqlParameter dishTypeParam = new SqlParameter
                {
                    ParameterName = "@DishType",
                    Value = dishType
                };
                // добавляем параметр
                command.Parameters.Add(dishTypeParam);
                // параметр для ввода веса блюда
                SqlParameter dishWeightParam = new SqlParameter
                {
                    ParameterName = "@DishWeight",
                    Value = dishWeight
                };
                command.Parameters.Add(dishWeightParam);

                // параметр для ввода порядка приготовления блюда
                SqlParameter preparationOrderParam = new SqlParameter
                {
                    ParameterName = "@PreparationOrder",
                    Value = preparationOrder
                };
                command.Parameters.Add(preparationOrderParam);

                // параметр для ввода количества калорий блюда
                SqlParameter caloryCountParam = new SqlParameter
                {
                    ParameterName = "@CaloryCount",
                    Value = caloryCount
                };
                command.Parameters.Add(caloryCountParam);

                // параметр для ввода количества углеводов блюда
                SqlParameter carbCountParam = new SqlParameter
                {
                    ParameterName = "@CarbCount",
                    Value = carbCount
                };
                command.Parameters.Add(carbCountParam);

                var result = command.ExecuteScalar();
                // если нам не надо возвращать id
                //var result = command.ExecuteNonQuery();

                Console.WriteLine("Id измененного объекта: {0}", result);
            }
        }

        // удаление блюда
        private static void DeleteDish(int dishCode)
        {
            // название процедуры
            string sqlExpression = "sp_DeleteDish";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода кода блюда
                SqlParameter dishCodeParam = new SqlParameter
                {
                    ParameterName = "@DishCode",
                    Value = dishCode
                };
                // добавляем параметр
                command.Parameters.Add(dishCodeParam);

                var result = command.ExecuteNonQuery();

                Console.WriteLine("Количество удаленных объектов: {0}", result);
            }
        }

        // вывод всех блюд
        private static void GetDishes()
        {
            // название процедуры
            string sqlExpression = "sp_GetDishes";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3), reader.GetName(4), reader.GetName(5));

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string type = reader.GetString(1);
                        int weight = reader.GetInt32(2);
                        string preparationorder = reader.GetString(3);
                        int calorycount = reader.GetInt32(4);
                        int carbcount = reader.GetInt32(5);
                        Console.WriteLine("{0} \t{1} \t{2} \t{3} \t{4} \t{5}", id, type, weight, preparationorder, calorycount, carbcount);
                    }
                }
                reader.Close();
            }
        }
    }
}
