using System;

namespace _5_year_frac2dec
{
    class Program
    {
        static void Main(string[] args)
        {
            string fracPrice;
            double decPrice;

            Console.WriteLine("5 Year Treasury Note Price Convertor");
            Console.WriteLine("This will convert a fractional price to a decimal price\n");
            Console.Write("What is the fractional price? (###'##.##): ");
            fracPrice = Convert.ToString(Console.ReadLine());
            decPrice = CalculateDecimal(fracPrice);
            Console.WriteLine("\n" + fracPrice + " converts to " + decPrice);
        }

        public double CalculateDecimal()

    }
}
