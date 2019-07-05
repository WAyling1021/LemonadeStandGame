using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Rules
    {
        List<string> RulesOfTheGame = new List<string>();
        public void DisplayRules()
        {
            RulesOfTheGame.Add("The objective of the game is to sell the most lemonade and make the most profit. Beware, if the weather doesn't permit, DON'T buy more projects then you can sell. GOOD LUCK, SELL LEMONADE!");

            foreach (string rule in RulesOfTheGame)
            {
                Console.WriteLine(rule);
                Console.ReadLine();
            }
        }
    }
}
