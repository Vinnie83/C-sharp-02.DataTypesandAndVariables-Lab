﻿namespace _01.ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main()
        {
            int meters = int.Parse(Console.ReadLine());
            double kilometers = meters / 1000.0;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}