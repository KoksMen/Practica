using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR21_2
{
    public interface ITransport
    {
        void Move();
    }

    public class Car : ITransport
    {
        public void Move()
        {
            Console.WriteLine("Автомобиль едет по дороге.");
        }
    }

    public class Train : ITransport
    {
        public void Move()
        {
            Console.WriteLine("Поезд движется по железной дороге.");
        }
    }

    public class Airplane : ITransport
    {
        public void Move()
        {
            Console.WriteLine("Самолет летит в небе.");
        }
    }

    public abstract class TransportFactory
    {
        public abstract ITransport CreateTransport();
    }

    public class CarFactory : TransportFactory
    {
        public override ITransport CreateTransport()
        {
            return new Car();
        }
    }

    public class TrainFactory : TransportFactory
    {
        public override ITransport CreateTransport()
        {
            return new Train();
        }
    }

    public class AirplaneFactory : TransportFactory
    {
        public override ITransport CreateTransport()
        {
            return new Airplane();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            TransportFactory carFactory = new CarFactory();
            ITransport car = carFactory.CreateTransport();
            car.Move();

            TransportFactory trainFactory = new TrainFactory();
            ITransport train = trainFactory.CreateTransport();
            train.Move();

            TransportFactory airplaneFactory = new AirplaneFactory();
            ITransport airplane = airplaneFactory.CreateTransport();
            airplane.Move();

            Console.ReadLine();
        }
    }
}
