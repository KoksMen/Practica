using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(12, 30, 45);
            timer.Print();
            timer.IncreaseSeconds(15);
            timer.Print();
            timer.Tick();
            timer.Print();
        }
    }

    abstract class Triad
    {
        private int first;
        private int second;
        private int third;

        public Triad(int first, int second, int third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }

        public void SetFirst(int first)
        {
            this.first = first;
        }

        public void SetSecond(int second)
        {
            this.second = second;
        }

        public void SetThird(int third)
        {
            this.third = third;
        }

        public void IncreaseFirst(int value)
        {
            first += value;
        }

        public void IncreaseSecond(int value)
        {
            second += value;
        }

        public void IncreaseThird(int value)
        {
            third += value;
        }

        public virtual void Print()
        {
            Console.WriteLine("{0} {1} {2}", first, second, third);
        }

        public int GetFirst()
        {
            return first;
        }

        public int GetSecond()
        {
            return second;
        }

        public int GetThird()
        {
            return third;
        }
    }

    class Timer : Triad
    {
        public Timer(int hours, int minutes, int seconds) : base(hours, minutes, seconds)
        {
        }

        public void SetHours(int hours)
        {
            SetFirst(hours);
        }

        public void SetMinutes(int minutes)
        {
            SetSecond(minutes);
        }

        public void SetSeconds(int seconds)
        {
            SetThird(seconds);
        }

        public void IncreaseHours(int value)
        {
            IncreaseFirst(value);
        }

        public void IncreaseMinutes(int value)
        {
            IncreaseSecond(value);
        }

        public void IncreaseSeconds(int value)
        {
            IncreaseThird(value);
        }

        public override void Print()
        {
            Console.WriteLine("{0:D2}:{1:D2}:{2:D2}", GetFirst(), GetSecond(), GetThird());
        }

        public void Tick()
        {
            if (GetThird() < 59)
            {
                IncreaseThird(1);
            }
            else
            {
                SetSeconds(0);
                if (GetSecond() < 59)
                {
                    IncreaseSecond(1);
                }
                else
                {
                    SetMinutes(0);
                    if (GetFirst() < 23)
                    {
                        IncreaseFirst(1);
                    }
                    else
                    {
                        SetHours(0);
                    }
                }
            }
        }
    }
}


