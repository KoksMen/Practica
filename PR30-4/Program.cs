using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PR30_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new UserContext())
            {
                // CREATE
                var newDish = new Dish { DishCode = 1, DishType = "Няма", DishWeight = 44, PreparationOrder = "Купить-Скушать", CaloryCount = 44, CarbCount = 15 };
                var newProduct = new Product { ProudctCode = 1, ProductName = "Колбаса", MeasureUnit = "шт" };
                var newBook = new CoockingBook { BookCode = 1, DishCode = 1, ProudctCode = 1, ProductScope = 14 };
                db.Dishs.Add(newDish);
                db.Products.Add(newProduct);
                db.CoockingBooks.Add(newBook);
                db.SaveChanges();

                // READ
                var dishs = db.Dishs.ToList();
                var products = db.Products.ToList();
                var books = db.CoockingBooks.ToList();
                foreach (var dish in dishs)
                {
                    Console.WriteLine($"Dish code: {dish.DishCode} " +
                        $"DishType: {dish.DishType} DishWeight: {dish.DishWeight} PreparationOrder: {dish.PreparationOrder} " +
                        $"CaloryCount: {dish.CaloryCount} CarbCount: {dish.CarbCount} ");
                }

                foreach (var product in products)
                {
                    Console.WriteLine($"ProductCode: {product.ProudctCode} ProductName: {product.ProductName} MeasureUnit: {product.MeasureUnit}");
                }

                foreach (var book in books)
                {
                    Console.WriteLine($"BookCode: {book.BookCode}, DishCode: {book.DishCode} ProductCode: {book.ProudctCode} ProductScope: {book.ProductScope}");
                }


                // UPDATE
                var dishToUpdate = db.Dishs.FirstOrDefault(d => d.DishCode == 1);
                if (dishToUpdate != null)
                {
                    dishToUpdate.DishType = "МегаНяма";
                    db.SaveChanges();
                }
                var productToUpdate = db.Products.FirstOrDefault(p => p.ProudctCode == 1);
                if (productToUpdate != null)
                {
                    productToUpdate.ProductName = "Шоколад";
                    db.SaveChanges();
                }
                var bookToUpdate = db.CoockingBooks.FirstOrDefault(b => b.BookCode == 1);
                if (dishToUpdate != null)
                {
                    bookToUpdate.ProductScope = 555;
                    db.SaveChanges();
                }

                // DELETE
                var dishToDelete = db.Dishs.FirstOrDefault(d => d.DishCode == 1);
                if (dishToDelete != null)
                {
                    db.Dishs.Remove(dishToDelete);
                    db.SaveChanges();
                }
                var productToDelete = db.Products.FirstOrDefault(d => d.ProudctCode == 1);
                if (productToDelete != null)
                {
                    db.Products.Remove(productToDelete);
                    db.SaveChanges();
                }
                var bookToDelete = db.CoockingBooks.FirstOrDefault(d => d.BookCode == 1);
                if (dishToDelete != null)
                {
                    db.CoockingBooks.Remove(bookToDelete);
                    db.SaveChanges();
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }       
}

    public class Dish
    {
        [Key]
        public int DishCode { get; set; }
        public string DishType { get; set; }
        public int DishWeight { get; set; }
        public string PreparationOrder { get; set; }
        public int CaloryCount { get; set; }
        public int CarbCount { get; set; }
    }

    public class Product
    {
        [Key]
        public int ProudctCode { get; set; }
        public string ProductName { get; set; }
        public string MeasureUnit { get; set; }
    }

    public class CoockingBook
    {
        [Key]
        public int BookCode { get; set; }
        public int DishCode { get; set; }
        public int ProudctCode { get; set; }
        public int ProductScope { get; set; }
    }

    public class UserContext : DbContext
    {
        public UserContext() :
            base("Cooks")
        { }

        public DbSet<Dish> Dishs { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CoockingBook> CoockingBooks { get; set; }
    }
