using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR15_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HistroticalDate histroticalDate = new HistroticalDate();
            Years years = new Years();
            Mounths mounths = new Mounths();
            Time time = new Time();

            histroticalDate.Input();
            years.Input();
            mounths.Input();
            time.Input();

            histroticalDate.Output();
            years.Output();
            mounths.Output();
            time.Output();
        }
    }

    public interface IDate<T>
    {
        T Input();
        void Output();
    }

    public class HistroticalDate : IDate<DateTime>
    {
        public DateTime Value { get; set; }

        public virtual DateTime Input()
        {
            Console.Write("Введите дату (в формате yyyy/MM/dd): ");
            Value = DateTime.ParseExact(Console.ReadLine(), "yyyy/MM/dd", null);
            return Value;
        }

        public virtual void Output()
        {
            Console.WriteLine($"Дата: {Value}");
        }
    }

    public class Years : HistroticalDate, IDate<DateTime>
    {
        public DateTime Value { get; set; }

        public virtual DateTime Input()
        {
            Console.Write("Введите дату (в формате yyyy): ");
            Value = DateTime.ParseExact(Console.ReadLine(), "yyyy", null);
            return Value;
        }

        public virtual void Output()
        {
            Console.WriteLine($"Год: {Value}");
        }
    }

    public class Mounths : HistroticalDate, IDate<DateTime>
    {
        public DateTime Value { get; set; }

        public virtual DateTime Input()
        {
            Console.Write("Введите дату (в формате MM): ");
            Value = DateTime.ParseExact(Console.ReadLine(), "MM", null);
            return Value;
        }

        public virtual void Output()
        {
            Console.WriteLine($"Месяц: {Value}");
        }
    }

    public class Time : HistroticalDate, IDate<DateTime>
    {
        public DateTime Value { get; set; }

        public virtual DateTime Input()
        {
            Console.Write("Введите дату (в формате HH:MM:SS): ");
            Value = DateTime.ParseExact(Console.ReadLine(), "T", null);
            return Value;
        }

        public virtual void Output()
        {
            Console.WriteLine($"Время: {Value}");
        }
    }
}
