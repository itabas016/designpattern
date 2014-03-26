using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Observer.WeatherMonitor
{
    public class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        public double Temperature { get; set; }

        public double Humidirty { get; set; }

        public ISubject Subject { get; set; }

        public CurrentConditionDisplay(ISubject subject)
        {
            this.Subject = subject;
            Subject.RegisterObserver(this);
        }

        public void Update(double temperature, double humidirty, double pressure)
        {
            this.Temperature = temperature;
            this.Humidirty = humidirty;
            Display();
        }

        public void Display()
        {
            Console.WriteLine(string.Format("Current Condition is : temperature {0} degrees and humidirty {1} %humidirty!", Temperature, Humidirty));
        }
    }
}
