﻿using System;
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
        public void BuyItem()
        {

        }
    }
}