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
        // list of customers

        //constructor 
        public Day()
        {

        }

        //member methods  
        public void DaysOfTheWeek()
        {
             daysOfTheWeekList = new List<string>() { "Monday", "Tuesday", "Wedenesday", "Thursday", "Friday", "Saturday", "Sunday" };

        }
        public string GetDays(int dayNumber)
        {
            days = daysOfTheWeekList[dayNumber];
            return days; 
        }




    }
}
