using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            SuperMarket market = new SuperMarket();
            market.PurchaseComplete += Market_PurchaseComplete;
            market.ProductRemoved += Market_ProductRemoved;
            List<Client> clients = new List<Client>()
            {
                new Client(
                            "Machechin",
                         new List<Product>()
                         {
                             new Product($"Product{rnd.Next(100)}", rnd.Next(345)),
                             new Product($"Product{rnd.Next(100)}", rnd.Next(345)),
                             new Product($"Product{rnd.Next(100)}", rnd.Next(345)),
                             new Product($"Product{rnd.Next(100)}", rnd.Next(345)),
                         }
                         ,
                         rnd.Next(1)),
                new Client(
                        "Nishpor",
                         new List<Product>()
                         {
                             new Product($"Product{rnd.Next(100)}", rnd.Next(345)),
                             new Product($"Product{rnd.Next(100)}", rnd.Next(345)),
                             new Product($"Product{rnd.Next(100)}", rnd.Next(345)),
                             new Product($"Product{rnd.Next(100)}", rnd.Next(345)),
                         }
                         ,
                         rnd.Next(10000)),
                new Client(
                            "Tichonovich",
                         new List<Product>()
                         {
                             new Product($"Product{rnd.Next(100)}", rnd.Next(345)),
                             new Product($"Product{rnd.Next(100)}", rnd.Next(345)),
                             new Product($"Product{rnd.Next(100)}", rnd.Next(345)),
                             new Product($"Product{rnd.Next(100)}", rnd.Next(345)),
                         }
                         ,
                         rnd.Next(10000)),
                new Client(
                        "Loban",
                         new List<Product>()
                         {
                             new Product($"Product{rnd.Next(100)}", rnd.Next(345)),
                             new Product($"Product{rnd.Next(100)}", rnd.Next(345)),
                             new Product($"Product{rnd.Next(100)}", rnd.Next(345)),
                             new Product($"Product{rnd.Next(100)}", rnd.Next(345)),
                         }
                         ,
                         rnd.Next(10000)),
                new Client(
                    "Marchovets",
                         new List<Product>()
                         {
                             new Product($"Product{rnd.Next(100)}", rnd.Next(345)),
                             new Product($"Product{rnd.Next(100)}", rnd.Next(345)),
                             new Product($"Product{rnd.Next(100)}", rnd.Next(345)),
                             new Product($"Product{rnd.Next(100)}", rnd.Next(345)),
                         }
                         ,
                         rnd.Next(10000)),
            };

            market.ProcessList(clients);
        }

        private static void Market_ProductRemoved(Client arg1, Product arg2)
        {
            Console.WriteLine($"У клиента {arg1.ClientName}, удалён продукт {arg2.ProductName}");
        }

        private static void Market_PurchaseComplete(Client client,decimal sum)
        {
            Console.WriteLine("{1} выполнил покупку на сумму {0}", sum, client.ClientName);
        }
    }

    public class SuperMarket
    {
        public event Action<Client, decimal> PurchaseComplete;
        public event Action<Client, Product> ProductRemoved;
        public decimal TotalRevenue { get; private set; }

        public void ProcessList(List<Client> clients)
        {
            foreach (var client in clients)
            {
                decimal totalPrice = 0;

                foreach (var product in client.Products)
                {
                    totalPrice += product.Price;
                }

                if (totalPrice <= client.Money)
                {
                    client.Money -= totalPrice;
                    TotalRevenue += totalPrice;
                    PurchaseComplete?.Invoke(client, totalPrice);
                    totalPrice = 0;
                }
                else
                {
                    while (client.Money < totalPrice)
                    {
                        if (client.Products.Count == 0)
                        {
                            break;
                        }

                        var productToRemove = client.Products[0];
                        ProductRemoved?.Invoke(client, productToRemove);
                        client.Products.RemoveAt(0);
                        totalPrice -= productToRemove.Price;
                    }

                    if (totalPrice <= client.Money)
                    {
                        client.Money -= totalPrice;
                        TotalRevenue += totalPrice;
                        PurchaseComplete?.Invoke(client, totalPrice);
                        totalPrice = 0;
                    }
                }
            }
        }
    }

    public class Client
    {
        public Client(string name,List<Product> products, decimal money)
        {
            ClientName = name;
            Products = products;
            Money = money;
        }

        public string ClientName { get; set; }
        public List<Product> Products { get; } = new List<Product>();
        public decimal Money { get; set; }
    }

    public class Product
    {
        public Product(string productName, decimal price)
        {
            ProductName = productName;
            Price = price;
        }

        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}


