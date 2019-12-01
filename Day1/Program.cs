using System;

namespace Day1
{
    class Program
    {

        static void Main(string[] args)
        {
            decimal solution1 = 0;
            decimal solution2 = 0;

            string[] lines = System.IO.File.ReadAllLines(@"D:\Development\Personal\AdventOfCode-2019\Day1\input.txt");
            foreach (String line in lines){
                decimal value = calculate(decimal.Parse(line));
                solution1 += value;

                solution2 += calculateExtra(decimal.Parse(line));
            }

            Console.WriteLine(solution1);
            Console.WriteLine(solution2);
        }

        static decimal calculate(decimal incomingValue)
        {
            decimal value = Math.Floor(incomingValue / 3) - 2;
            return value;
        }

        static decimal calculateExtra(decimal incomingValue)
        {
            decimal fuel = calculate(incomingValue);

            if (fuel <= 0)
            {
                return 0;
            }
            return fuel + calculateExtra(fuel);
        }
    }
}
