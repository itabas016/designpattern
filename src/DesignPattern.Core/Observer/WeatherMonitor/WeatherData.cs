using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Observer.WeatherMonitor
{
    public class WeatherData : ISubject
    {
        public double Temperature { get; set; }

        public double Humidity { get; set; }

        public double Pressure { get; set; }

        public IList<IObserver> ObserverList { get; set; }

        public WeatherData()
        {
            ObserverList = new List<IObserver>();
        }

        public WeatherData(double temperature, double humidity, double pressure)
        {
            this.Temperature = temperature;
            this.Humidity = humidity;
            this.Pressure = pressure;
        }

        public void RegisterObserver(IObserver observer)
        {
            ObserverList.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            if (ObserverList != null && ObserverList.Count > 0)
            {
                ObserverList.Remove(observer);
            }
        }

        public void NotifyObservers()
        {
            if (ObserverList != null && ObserverList.Count > 0)
            {
                foreach (var item in ObserverList)
                {
                    item.Update(Temperature, Humidity, Pressure);
                }
            }
        }

        public void MeasureMentsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            this.Temperature = temperature;
            this.Humidity = humidity;
            this.Pressure = pressure;
            MeasureMentsChanged();
        }
    }
}
