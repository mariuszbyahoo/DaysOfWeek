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

            Console.WriteLine("Which day do you want to display?");
            Console.WriteLine("(Monday = 1, etc.) > ");
            int iDay = int.Parse(Console.ReadLine());

            string chosenDay = daysOfWeek[iDay - 1];
            Console.WriteLine($"That day is: {chosenDay}");
        }
    }
}
