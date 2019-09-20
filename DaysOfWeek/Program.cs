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
                "Wensday", // badly spelled wednesday
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine();

            daysOfWeek[2] = "Wednesday"; //fixing the typo

            foreach(string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
        }
    }
}
