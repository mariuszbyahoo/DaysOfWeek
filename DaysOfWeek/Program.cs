using System;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

// Simplest way to enumerate over the array's elements
            foreach(string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

        }
    }
}
