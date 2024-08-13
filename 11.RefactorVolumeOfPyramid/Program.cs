﻿namespace _11.RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            double baseArea = length * width;
            double volume = (baseArea * height) / 3;

            Console.Write($"Pyramid Volume: {volume:f2}");
        }
    }
}