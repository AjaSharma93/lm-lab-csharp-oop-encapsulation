using NUnit.Framework;
using FluentAssertions;
using Encapsulation.Models;

namespace Encapsulation.Tests
{
    public class WeatherReporterTests
    {

        [Test]
        public void CreateWeatherReporterObject()
        {
            WeatherReporter weatherReporter = new WeatherReporter("london",100);
        }
    }
}
