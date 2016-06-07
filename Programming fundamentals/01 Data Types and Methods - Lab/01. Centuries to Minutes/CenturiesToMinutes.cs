using System;

namespace _01.Centuries_to_Minutes
{
    class CenturiesToMinutes
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = 100 * centuries;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = 60 * hours;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");

        }
    }
}
