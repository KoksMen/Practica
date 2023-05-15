using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;

namespace PR33_1
{
    public partial class Form1 : Form
    {
        private DataContext dbContext;
        private Table<Dish> dishesTable;
        private Table<Product> productsTable;
        private Table<DishProduct> dishProductTable;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Создание подключения к базе данных
            dbContext = new DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=CookiesDB2;Integrated Security=True");

            // Получение таблиц из базы данных
            dishesTable = dbContext.GetTable<Dish>();
            productsTable = dbContext.GetTable<Product>();
            dishProductTable = dbContext.GetTable<DishProduct>();

            // Отображение данных
            DisplayTables();
        }

        private void DisplayTables()
        {
            // Очистка контролов
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Columns.Clear();
            dataGridView3.Rows.Clear();

            // Отображение таблицы "Блюда"
            var dishes = dishesTable.ToList();
            dataGridView1.Columns.Add("DishId", "Код блюда");
            dataGridView1.Columns.Add("DishType", "Тип блюда");
            dataGridView1.Columns.Add("DishWeight", "Вес блюда");
            dataGridView1.Columns.Add("DishOrder", "Порядок приготовления");
            dataGridView1.Columns.Add("DishCalories", "Количество калорий");
            dataGridView1.Columns.Add("DishCarbs", "Количество углеводов");
            foreach (var dish in dishes)
            {
                dataGridView1.Rows.Add(dish.DishId, dish.DishType, dish.DishWeight, dish.DishOrder, dish.DishCalories, dish.DishCarbs);
            }

            // Отображение таблицы "Продукты"
            var products = productsTable.ToList();
            dataGridView2.Columns.Add("ProductId", "Код продукта");
            dataGridView2.Columns.Add("ProductName", "Название продукта");
            dataGridView2.Columns.Add("ProductUnit", "Единица измерения");
            foreach (var product in products)
            {
                dataGridView2.Rows.Add(product.ProductId, product.ProductName, product.ProductUnit);
            }

            // Отображение таблицы "Блюда-Продукты"
            var dishProducts = dishProductTable.ToList();
            dataGridView3.Columns.Add("DishId", "Код блюда");
            dataGridView3.Columns.Add("ProductId", "Код продукта");
            dataGridView3.Columns.Add("ProductVolume", "Объём продукта");
            foreach (var dishProduct in dishProducts)
            {
                dataGridView3.Rows.Add(dishProduct.DishId, dishProduct.ProductId, dishProduct.ProductVolume);
            }
        }

        private void FilterData()
        {
            var filteredDishes = dishesTable.Where(d => d.DishType == "Main Course").ToList();
            // Применение фильтрации данных и отображение результата
            // ...
        }

        private void SortData()
        {
            var sortedDishes = dishesTable.OrderBy(d => d.DishCalories).ToList();
            // Применение сортировки данных и отображение результата
            // ...
        }

        private void GroupData()
        {
            var groupedDishes = dishesTable.GroupBy(d => d.DishType).ToList();
            // Применение группировки данных и отображение результата
            // ...
        }

        private void UpdateData()
        {
            // Обновление данных в таблице "Блюда"
            var dishToUpdate = dishesTable.FirstOrDefault(d => d.DishId == 1);
            if (dishToUpdate != null)
            {
                dishToUpdate.DishType = "Updated Dish Type";
                dishToUpdate.DishCalories = 500;
                dbContext.SubmitChanges();
            }
        }

        private void AddData()
        {
            // Добавление нового объекта в таблицу "Продукты"
            var newProduct = new Product
            {
                ProductName = "New Product",
                ProductUnit = "kg"
            };
            productsTable.InsertOnSubmit(newProduct);
            dbContext.SubmitChanges();
        }

        private void DeleteData()
        {
            // Удаление данных из таблицы "Блюда-Продукты"
            var dishProductToDelete = dishProductTable.FirstOrDefault(dp => dp.DishId == 1 && dp.ProductId == 1);
            if (dishProductToDelete != null)
            {
                dishProductTable.DeleteOnSubmit(dishProductToDelete);
                dbContext.SubmitChanges();
            }
        }
    }

    // Класс модели для таблицы "Блюда"
    public class Dish
    {
        public int DishId { get; set; }
        public string DishType { get; set; }
        public double DishWeight { get; set; }
        public int DishOrder { get; set; }
        public int DishCalories { get; set; }
        public int DishCarbs { get; set; }
    }

    // Класс модели для таблицы "Продукты"
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductUnit { get; set; }
    }

    // Класс модели для таблицы "Блюда-Продукты"
    public class DishProduct
    {
        public int DishId { get; set; }
        public int ProductId { get; set; }
        public double ProductVolume { get; set; }
    }




}
