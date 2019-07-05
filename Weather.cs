using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Weather
    {
        //member variables (HAS A)
        //temperture/ forecast
        public int temperture;
        public string forecast;
        public Day day; 
        List<string> weatherForecastList;


        //constructor
        public Weather()
        {

        }

        //member methods 

        //method for get random temp
        //get weather forecast 
        public void WeatherForeCast() 
        {
            weatherForecastList = new List<string>() { "cloudy", "rainy", "sunny", "partly cloudy", "partly sunny" };
        }
        public string GetWeatherForecast()
        {
            Random randomNumberGenerator = new Random();
            int indexNumber = randomNumberGenerator.Next(5);
            forecast = weatherForecastList[indexNumber];
            return forecast;
        }
        public int RandomTemperture()
        {
            Random randomNumberGenerator = new Random();
            temperture = randomNumberGenerator.Next(65, 100);
            return temperture;
        }

    }


}
