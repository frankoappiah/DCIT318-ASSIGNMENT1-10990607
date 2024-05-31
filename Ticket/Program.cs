using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            decimal ticketPrice;
            if (age >= 65 || age <= 12)
                ticketPrice = 7.00m;
            else
                ticketPrice = 10.00m;

            Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
        }
    }
}