using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Store
    {
        //member variables 
        //Item prices per 
        public double lemonPrice;
        public double sugarPrice;
        public double waterPrice;
        public double icePrice;
        public double cupPrice;

        //constructor
        public void StorePrices() 
        {
            lemonPrice = .60;
            sugarPrice = .10;
            waterPrice = 1.00;
            icePrice = .50;
            cupPrice = .13;

        }

        //member methods 
        public void BuyItem(Player player, string item, double itemPrice)
        {
            Console.WriteLine($"How many {item} do you want to buy for the day?");
            int numberToBuy = int.Parse(Console.ReadLine());
            double totalCost = numberToBuy * itemPrice;
            if(totalCost <= player.money)
            {
                IncreaseInventory(player, item, numberToBuy);
            }
            else
            {
                Console.WriteLine("You don't have enough money"); 
            }
        }
        public void IncreaseInventory(Player player, string item, int numberToBuy)
        {
            switch (item)
            {
                case "lemon":
                    player.myInventory.lemons += numberToBuy;
                    break;
                case "sugar":
                    player.myInventory.sugar += numberToBuy;
                    break;
                case "water":
                    player.myInventory.water += numberToBuy;
                    break;
                case "ice":
                    player.myInventory.ice += numberToBuy;
                    break;
                case "cup":
                    player.myInventory.cups += numberToBuy;
                    break;
            }
                
        }
    }
}
