using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Game // : inheritance => (IS A TYPE OF)
    {
        //member variables (HAS A)
        public Player player;
        public Day day;
        Rules rules;
        public Store store;
       
        // list of days

        //constructor
        public void LemonGame()
        {
            player = new Player();
            rules = new Rules();

        }
        public void RunGame()
        {
            Rules rules = new Rules();


            Weather weather = new Weather();
            weather.WeatherForeCast();
            weather.RandomTemperture();
            Day day = new Day(weather);
            store.BuyItem(player, "lemon", 0.60);
            store.BuyItem(player, "sugar", 0.10);
            store.BuyItem(player, "water", 1.00);
            store.BuyItem(player, "ice", 0.50);
            store.BuyItem(player, "cups", 0.13);

            // day.weather.WeatherForeCast();
        }
      

        //member methods 
    }
}
