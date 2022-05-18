using System;
namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        private string _location;
        private double _temperature;
        // Referred: https://physics.stackexchange.com/questions/86726/celsius-to-fahrenheit-confusion-why-there-is-no-1-to-x-ratio
        private const double  SLOPE_DIFFERENCE = 9.0/5.0;
        private const double ZERO_DIFFERENCE = 32;

        public WeatherReporter(string location, double temperature)
        {
            _location = location;
            _temperature = temperature;
        }

        private Dictionary<String, String> fetchWeatherConditions(){
            Dictionary<String, String> weatheConditonsByLocation = new Dictionary<string,string>();
            weatheConditonsByLocation["london"] = "🌦";
            weatheConditonsByLocation["california"] = "🌅";
            weatheConditonsByLocation["cape town"] = "🌤";
            return weatheConditonsByLocation;
        }

        private double getTemperatureInFahrenheit(){
            return SLOPE_DIFFERENCE * _temperature + ZERO_DIFFERENCE;
        }

        public string Print()
        {
            double newTemp = getTemperatureInFahrenheit();
            return $"I am in {_location} and it is {CheckLocation()}. {CheckTemperature()}. The temperature in Fahrenheit is {newTemp}.";
        }

        public string CheckLocation()
        {
            // Ideally fetched from API
            string weather; 
            fetchWeatherConditions().TryGetValue(_location, out weather);
            return (String.IsNullOrEmpty(weather))?"🔆":weather;
        }

        public string CheckTemperature()
        {
            if (_temperature > 30)
            {

                return "It's too hot 🥵!";

            }
            else if (_temperature < 10)
            {

                return "It's too cold 🥶!";

            }
            return "Ahhh...it's just right 😊!";
        }

    }
}

