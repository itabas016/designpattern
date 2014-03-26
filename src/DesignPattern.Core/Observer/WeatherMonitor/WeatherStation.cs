using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Observer.WeatherMonitor
{
    public class WeatherStation
    {
        public void DataCollection()
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionDisplay currentCondition = new CurrentConditionDisplay(weatherData);
            StatisticsDisplay statistic = new StatisticsDisplay(weatherData);
            ForecastDisplay forecasst = new ForecastDisplay(weatherData);

            weatherData.SetMeasurements(20, 50, 35);
        }
    }
}
