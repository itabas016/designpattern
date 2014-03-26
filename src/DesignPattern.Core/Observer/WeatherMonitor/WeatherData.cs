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

        public double Humidirty { get; set; }

        public double Pressure { get; set; }

        public IList<IObserver> ObserverList { get; set; }

        public WeatherData()
        {

        }

        public WeatherData(double temperature, double humidirty, double pressure)
        {
            this.Temperature = temperature;
            this.Humidirty = humidirty;
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
                    item.Update(Temperature, Humidirty, Pressure);
                }
            }
        }

        public void MeasureMentsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(double temperature, double humidirty, double pressure)
        {
            this.Temperature = temperature;
            this.Humidirty = humidirty;
            this.Pressure = pressure;
            MeasureMentsChanged();
        }
    }
}
