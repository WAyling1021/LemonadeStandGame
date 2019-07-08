using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Customer
    {
        //member variables 
        //Customer has money 
        int money;
        public string name;
        public int chanceToBuy;

        //constructor 

        //member methods
        //customer buys lemonade 
        public Customer()
        {
            chanceToBuy = 50;
        }

        public void MakeDecision(Weather currentWeather, double priceOfLemonade)
        {
            if(currentWeather.temperture < 40)
            {
                chanceToBuy -= 15;
            }
            else if (currentWeather.temperture < 40)
            {
                chanceToBuy -= 15;
            }
            else if (currentWeather.temperture < 40)
            {
                chanceToBuy -= 15;
            }
            else if (currentWeather.temperture < 40)
            {
                chanceToBuy -= 15;
            }
            else if (currentWeather.temperture < 40)
            {
                chanceToBuy -= 15;
            }
            else if (currentWeather.temperture < 40)
            {
                chanceToBuy -= 15;
            }
            else if (currentWeather.temperture < 40)
            {
                chanceToBuy -= 15;
            }
            else
            {

            }

        }


    }
}
