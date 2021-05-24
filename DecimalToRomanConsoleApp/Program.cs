using System;
using DecimalToRomanConsoleApp.Models;

namespace DecimalToRomanConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 4;
            var result = SuperInteger.ConvertToRoman(number);

            Console.WriteLine($"The equivalent roman number is: {result}");
        }
    }
}
