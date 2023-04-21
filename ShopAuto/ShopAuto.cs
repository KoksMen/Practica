using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAuto
{
    interface IBaseInfo
    {
        string InfoCars();
        int AllCostAuto();
    }
    public class Shop : IBaseInfo
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public int Cost { get; set; }
        public double Discount { get; set; }
        public Shop() { }
        public Shop(string Name, int MaxSpeed, int Cost, double Discount)
        {
            this.Name = Name;
            this.MaxSpeed = MaxSpeed;
            this.Cost = Cost;
            this.Discount = Discount;
        }
        public string InfoCars()
        {
            return String.Format($@"Информация об авто:
            ------------------
            Марка: \t{this.Name}
            Макс.скорость: \t{this.MaxSpeed}
            Стоимость: \t{this.Cost}
            Скидка: \t{this.Discount}
           ");
        }
        public int AllCostAuto()
        {
            return (int)(Discount * Cost / 100);
        }
        public override string ToString()
        {
            return this.InfoCars();
        }
    }
}

