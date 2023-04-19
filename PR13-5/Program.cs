using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PR13_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartHome smartHome = new SmartHome();
            TemperatureSensor temperatureSensor = new TemperatureSensor(smartHome, 30);

            temperatureSensor.TemperatureChanged += TemperatureSensor_TemperatureChanged;

            SmartPhone smartPhone = new SmartPhone(smartHome, temperatureSensor);

            smartPhone.PressButton();
            Console.WriteLine();

            for (int temperature = 25; temperature <= 35; temperature++)
            {
                Console.Write($"Текущая температура: {temperature} градусов");
                temperatureSensor.CheckTemperature(temperature);
                Console.ReadLine();
            }
        }

        private static void TemperatureSensor_TemperatureChanged(SmartHome smarthome)
        {
            smarthome.TurnOnAirConditioner();
            smarthome.CloseDoorsAndWindows();
            smarthome.BringIceCreamTruck();
        }
    }

    public delegate void Temperaturer(SmartHome smartHome);

    public class SmartHome
    {
        public void TurnOnAirConditioner()
        {
            Console.WriteLine("\nКондиционер включен");
        }

        public void CloseDoorsAndWindows()
        {
            Console.WriteLine("Двери и окна закрыты");
        }

        public void BringIceCreamTruck()
        {
            Console.WriteLine("Приехал грузовик с мороженым");
        }
    }

    public class SmartPhone
    {
        private SmartHome _smartHome;
        private TemperatureSensor _temperatureSensor;

        public SmartPhone(SmartHome smartHome, TemperatureSensor temperatureSensor)
        {
            _smartHome = smartHome;
            _temperatureSensor = temperatureSensor;
            _temperatureSensor.TemperatureChanged += OnTemperatureChanged;
        }

        private void OnTemperatureChanged(SmartHome smarthome)
        {
            smarthome.TurnOnAirConditioner();
            smarthome.CloseDoorsAndWindows();
            smarthome.BringIceCreamTruck();
        }

        public void PressButton()
        {
            _temperatureSensor.CheckTemperature(_temperatureSensor.HighTemperatureThreshold + 1);
        }
    }

    public class TemperatureSensor
    {
        private SmartHome _smartHome;
        private int _highTemperatureThreshold;

        public event Temperaturer TemperatureChanged;

        public TemperatureSensor(SmartHome smartHome, int highTemperatureThreshold)
        {
            _smartHome = smartHome;
            _highTemperatureThreshold = highTemperatureThreshold;
        }

        public int HighTemperatureThreshold
        {
            get { return _highTemperatureThreshold; }
        }

        public void CheckTemperature(int temperature)
        {
            if (temperature >= _highTemperatureThreshold)
            {
                OnTemperatureChanged();
            }
        }

        protected virtual void OnTemperatureChanged()
        {
            TemperatureChanged?.Invoke(_smartHome);
        }
    }
}
