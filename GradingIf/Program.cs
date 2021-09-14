using System;

namespace GradingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis hinde sa said?");
            string UserNumber = Console.ReadLine();

            if (UserNumber == "5")
            {
                Console.WriteLine("Suurepärane");
            }
            else if (UserNumber == "4")
            {
                Console.WriteLine("Väga hea");
            }
            else if (UserNumber == "3")
            {
                Console.WriteLine("Hea");
            }
            else if (UserNumber == "2")
            {
                Console.WriteLine("Rahuldav");
            }
            else if (UserNumber == "1")
            {
                Console.WriteLine("Puudulik");
            }
            else
            {
                Console.WriteLine("Pole hinnet");
            }
        }
    }
}
