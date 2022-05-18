using NUnit.Framework;
using FluentAssertions;
using Encapsulation.Models;

namespace Encapsulation.Tests
{
    public class WeatherReporterTests
    {
        private string getOutputMessage(string location, string locationCondition, string temperatureCondition, double newTemp)
        {
            return $"I am in {location} and it is {locationCondition}. {temperatureCondition}. The temperature in Fahrenheit is {newTemp}.";
        }

        [Test]
        public void TestHotWeatherInLondon()
        {
            string location = "london";
            string locationCondition = "🌦";
            double temperature = 40;
            string temperatureCondtion = "It's too hot 🥵!";
            double newTemp = 104;
            WeatherReporter weatherReporter = new WeatherReporter(location, temperature);
            weatherReporter.Print().Should().Be(getOutputMessage(location, locationCondition, temperatureCondtion, newTemp));
        }

        [Test]
        public void TestColdWeatherInCapeTown()
        {
            string location = "cape town";
            string locationCondition = "🌤";
            double temperature = 9;
            string temperatureCondtion = "It's too cold 🥶!";
            double newTemp = 48.2;
            WeatherReporter weatherReporter = new WeatherReporter(location, temperature);
            weatherReporter.Print().Should().Be(getOutputMessage(location, locationCondition, temperatureCondtion, newTemp));
        }

        [Test]
        public void TestPleasantWeatherInCalifornia()
        {
            string location = "california";
            string locationCondition = "🌅";
            double temperature = 18;
            string temperatureCondtion = "Ahhh...it's just right 😊!";
            double newTemp = 64.4;
            WeatherReporter weatherReporter = new WeatherReporter(location, temperature);
            weatherReporter.Print().Should().Be(getOutputMessage(location, locationCondition, temperatureCondtion, newTemp));
        }
    }
}
