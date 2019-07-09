using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Day
    {
        //member variables
        public Weather weather;
        public string days;
        List<string> daysOfTheWeekList;
        List<string> Name = new List<string>();
        List<Customer> customers;
        Customer customer;
        Random rng;
        



        //constructor 
        public Day(Weather weather)
        {
            this.weather = weather;
            AddName();
            customers = new List<Customer>();
            Name = new List<string>();
            rng = new Random();
        }

        //member methods  
        public void DetermineNumberOfCustomers()
        {
            if(weather.temperture > 65)
            {
                Console.WriteLine("You'll get 32 customers");
            }
            else if(weather.temperture < 70)
            {
                Console.WriteLine("You'll get 48 customers");
            }
            else if (weather.temperture < 75)
            {
                Console.WriteLine("You'll get 59 customers");
            }
            else if (weather.temperture < 80)
            {
                Console.WriteLine("You'll get 79 customers");
            }
            else if (weather.temperture < 85)
            {
                Console.WriteLine("You'll get 102 customers");
            }
            else if (weather.temperture < 90)
            {
                Console.WriteLine("You'll get 164 customers");
            }
            else if (weather.temperture < 95)
            {
                Console.WriteLine("You'll get 190 customers");
            }
            else if (weather.temperture < 100)
            {
                Console.WriteLine("You'll get 204 customers");
            }
            else
            {

            }
           
        }

        public void DaysOfTheWeek()
        {
             daysOfTheWeekList = new List<string>() { "Monday", "Tuesday", "Wedenesday", "Thursday", "Friday", "Saturday", "Sunday" };

        }
        public string GetDays(int dayNumber)
        {
            days = daysOfTheWeekList[dayNumber];
            return days; 
        }
        public void AddName()
        {
            Name.Add("Ryan");
            Name.Add("Jake");
            Name.Add("Ben");
            Name.Add("Alex");
            Name.Add("John");
            Name.Add("Travis");
            Name.Add("Joe");
            Name.Add("Sam");
            Name.Add("Harry");
            Name.Add("Ricky");
            Name.Add("Stephanie");
            Name.Add("Chris");
            Name.Add("Daniel");
            Name.Add("Alice");
            Name.Add("James");
            Name.Add("Luke");
        }
        public void GenerateRandomCustomer() 
        {
            int randomNumber = rng.Next(0, Name.Count);

            customer = new Customer(Name[randomNumber]);
            customer.MakeDecision(weather,0.25);
        }

    }
}
