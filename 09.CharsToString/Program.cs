﻿namespace _09.CharsToString
{
    internal class Program
    {
        static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());

            Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
        }
    }
}