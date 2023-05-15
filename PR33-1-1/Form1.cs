using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace PR33_1_1
{
    public partial class Form1 : Form
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CookiesDB;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();

            DataContext db = new DataContext(connectionString);

            //Просто вывод
            //Table<Product> products = db.GetTable<Product>();
            //Table<Dish> dishes = db.GetTable<Dish>();
            //Table<CookingBook> cokingbooks = db.GetTable<CookingBook>();

            //Фильтрация и сортировка
            var products = db.GetTable<Product>().Where(p => p.ProudctCode > 2).OrderBy(p => p.ProductName);
            var dishes = db.GetTable<Dish>().Where(d => d.DishWeight < 13).OrderBy(d => d.CaloryCount);
            var cokingbooks = db.GetTable<CookingBook>().Where(c => c.ProductScope.Length > 3).OrderBy(c => c.BookCode);

            //Группировка
            var groupdedDishes = db.GetTable<Dish>().GroupBy(d => d.CaloryCount);

            //Вывод в DataGridView
            dataGridView1.DataSource = products;
            dataGridView2.DataSource = dishes;
            dataGridView3.DataSource = cokingbooks;
            dataGridView4.DataSource = groupdedDishes;

            //Изменение
            Dish dish1 = db.GetTable<Dish>().FirstOrDefault();
            dish1.DishWeight = 2525777;
            db.SubmitChanges();
            Table<Dish> dishesEdited = db.GetTable<Dish>();
            dataGridView5.DataSource = dishesEdited;

            //Добавление
            Product product1 = new Product { ProductName = "Арбуз", MeasureUnit = "Количество" };
            db.GetTable<Product>().InsertOnSubmit(product1);
            db.SubmitChanges();
            Table<Product> productsAdded = db.GetTable<Product>();
            dataGridView6.DataSource = productsAdded;

            //Удаление
            var cookingBookToDelete = db.GetTable<CookingBook>().FirstOrDefault();
            db.GetTable<CookingBook>().DeleteOnSubmit(cookingBookToDelete);
            db.SubmitChanges();
            Table<CookingBook> booksDelete = db.GetTable<CookingBook>();
            dataGridView7.DataSource = booksDelete;
        }
    }

    [Table(Name = "Products")]
    public class Product
    {
        [Column(Name = "ProudctCode", IsPrimaryKey = true, IsDbGenerated = true)]
        public int ProudctCode { get; set; }
        [Column(Name = "ProductName")]
        public string ProductName { get; set; }
        [Column(Name = "MeasureUnit")]
        public string MeasureUnit { get; set; }
    }

    [Table(Name = "CoockingBooks")]
    public class CookingBook
    {
        [Column(Name = "BookCode", IsPrimaryKey = true, IsDbGenerated = true)]
        public int BookCode { get; set; }
        [Column(Name = "DishCode")]
        public int DishCode { get; set; }
        [Column(Name = "ProudctCode")]
        public int ProudctCode { get; set; }
        [Column(Name = "ProductScope")]
        public string ProductScope { get; set; }
    }
    [Table(Name = "Dishes")]
    public class Dish
    {
        [Column(Name = "DishCode", IsPrimaryKey = true, IsDbGenerated = true)]
        public int DishCode { get; set; }
        [Column(Name = "DishType")]
        public string DishType { get; set; }
        [Column(Name = "DishWeight")]
        public int DishWeight { get; set; }
        [Column(Name = "PreparationOrder")]
        public string PreparationOrder { get; set; }
        [Column(Name = "CaloryCount")]
        public int CaloryCount { get; set; }
        [Column(Name = "CarbCount")]
        public int CarbCount { get; set; }
    }

}
