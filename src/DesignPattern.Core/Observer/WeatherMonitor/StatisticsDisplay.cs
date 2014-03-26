using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Observer.WeatherMonitor
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        public IList<double> TemperatureList { get; set; }

        public IList<double> HumidirtyList { get; set; }

        public IList<double> PressureList { get; set; }

        public double Temperature { get; set; }

        public double Humidirty { get; set; }

        public double Pressure { get; set; }

        public ISubject Subject { get; set; }

        public StatisticsDisplay(ISubject subject)
        {
            this.Subject = subject;
            Subject.RegisterObserver(this);
        }

        public void Update(double temperature, double humidirty, double pressure)
        {
            this.Temperature = temperature;
            this.Humidirty = humidirty;
            this.Pressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine(string.Format("Statistic today is : temperature {0} degrees, humidirty {1} %humidirty and pressuer {2} pressure!", Temperature, Humidirty, Pressure));
        }

        public double GetAverageTemperature(IList<double> temperatureList, double temperature)
        {
            return GetAverage(temperatureList, temperature);
        }

        public double GetAverageHumidirty(IList<double> humidirtyList, double humidirty)
        {
            return GetAverage(humidirtyList, humidirty);
        }

        public double GetAveragePressure(IList<double> pressureList, double pressure)
        {
            return GetAverage(pressureList, pressure);
        }

        private double GetAverage(IList<double> list, double item)
        {
            list.Add(item);
            return list.Average();
        }
    }
}
