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
        public Customer(string name)
        {
            chanceToBuy = 50;
            this.name = name;
        }

        public void MakeDecision(Weather currentWeather, double priceOfLemonade)
        {
            if(currentWeather.temperture < 65 || priceOfLemonade <= .15)
            {
                chanceToBuy -= 15;
            }
            else if (currentWeather.temperture < 70 || priceOfLemonade <= .15)
            {
                chanceToBuy -= 20;
            }
            else if (currentWeather.temperture < 75 || priceOfLemonade <= .20)
            {
                chanceToBuy -= 20;
            }
            else if (currentWeather.temperture < 80 || priceOfLemonade <= .25)
            {
                chanceToBuy += 25;
            }
            else if (currentWeather.temperture < 85 || priceOfLemonade <= .75)
            {
                chanceToBuy += 35;
            }
            else if (currentWeather.temperture < 90 || priceOfLemonade <= 1.00)
            {
                chanceToBuy += 50;
            }
            else if (currentWeather.temperture < 95 || priceOfLemonade <= 1.15)
            {
                chanceToBuy += 60;
            }
            else if (currentWeather.temperture < 100 || priceOfLemonade <= 1.25)
            {
                chanceToBuy += 90;
            }
            else
            {

            }



        }

        
    }
}
