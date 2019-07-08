using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Day
    {
        //member varaibles
        public Weather weather;
        public string days;
        List<string> daysOfTheWeekList;
        List<string> Name = new List<string>();
        // public List<Customer> customers;
        //AddName();
        

        // list of customers

        //constructor 
        public Day()
        {
            AddName();
        }

        //member methods  
        public void DetermineNumberOfCustomers()
        {
            if(weather.temperture > 70)
            {
                Console.WriteLine("");
            }
            else if(weather.temperture < 20)
            {
                Console.WriteLine("");
            }
            else if (weather.temperture < 20)
            {
                Console.WriteLine("");
            }
            else if (weather.temperture < 20)
            {
                Console.WriteLine("");
            }
            else if (weather.temperture < 20)
            {
                Console.WriteLine("");
            }
            else if (weather.temperture < 20)
            {
                Console.WriteLine("");
            }
            else if (weather.temperture < 20)
            {
                Console.WriteLine("");
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
            Name.Add("Stephannie");
            Name.Add("Chris");
            Name.Add("Daniel");
            Name.Add("Alice");
            Name.Add("James");
            Name.Add("Luke");
        }
    }
}
