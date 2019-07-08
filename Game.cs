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
            Weather weather = new Weather();
            weather.WeatherForeCast();
            weather.RandomTemperture();
            Day day = new Day();

            // day.weather.WeatherForeCast();


        }
      

        //member methods 
    }
}
