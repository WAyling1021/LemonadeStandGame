using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Weather
    {
        //member variables 
        //temperture/ forecast
        public int temperture;
        public string forecast;
        List<string> weatherForecastList;
        //constructor
       

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
        public void RandomTemperture()
        {
            Random Temp = new temp();
        }
        





















        //public const int totalDays = 7;
        //public const int minTemp = 65;
        //public const int maxTemp = 99;
        //public static Day[] days = new Day[totalDays];




    }

}
