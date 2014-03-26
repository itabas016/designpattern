using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Core.Observer.WeatherMonitor;
using Xunit;

namespace DesignPattern.Test.Observer
{
    public class WeatherMonitorTest
    {
        [Fact]
        public void WeatherStationTest()
        {
            var station = new WeatherStation();

            station.DataCollection();
        }
    }
}
