using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR11_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WritingTable wt = new WritingTable("Письменный стол", 1.5, "Дерево", 100000);
            wt.PrintInfo();

            Console.WriteLine();

            DiningTable dt = new DiningTable("Обеденный стол", 2.5, "Овальный");
            dt.PrintInfo();
        }
    }

    class Table
    {
        protected string name;
        protected double area;

        public Table()
        {
            name = "";
            area = 0;
        }

        public Table(string name, double area)
        {
            this.name = name;
            this.area = area;
        }

        public virtual double Cost
        {
            get
            {
                return Math.Pow(area, 2.0 / 3.0) + 500000;
            }
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Название стола: {0}", name);
            Console.WriteLine("Площадь стола: {0}", area);
            Console.WriteLine("Стоимость стола: {0}", Cost);
        }
    }

    class WritingTable : Table
    {
        private string material;
        private double finishCost;

        public WritingTable()
            : base()
        {
            material = "";
            finishCost = 0;
        }

        public WritingTable(string name, double area, string material, double finishCost)
            : base(name, area)
        {
            this.material = material;
            this.finishCost = finishCost;
        }

        public override double Cost
        {
            get { return base.Cost + finishCost; }
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Материал стола: {0}", material);
            Console.WriteLine("Финальная стоиость стола: {0}", finishCost);
        }
    }

    class DiningTable : Table
    {
        private string shape;

        public DiningTable()
            : base()
        {
            shape = "";
        }

        public DiningTable(string name, double area, string shape)
            : base(name, area)
        {
            this.shape = shape;
        }

        public override double Cost
        {
            get {
                double cost = base.Cost;
                if (area < 0.5 || area > 2)
                {
                    if (shape == "Прямоугольный")
                    {
                        cost *= 1.1;
                    }
                    else if (shape == "Овальный")
                    {
                        cost *= 1.2;
                    }
                }
                return cost;
            }
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Форма стола: {0}", shape);
        }
    }
}
