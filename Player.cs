using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Player
    {
        //member variables 
        public string name;
        public int money;
        public Store store;
        public Inventory myInventory;

        //constructor
        public Player()
        {
            Console.WriteLine("How much would you like to buy today?");
            myInventory = new Inventory();
        }

        //member methods 
        public void PlayerWallet()
        {
            money = 25;
        }
    }
}
