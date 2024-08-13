namespace _10.LowerOrUpper
{
    internal class Program
    {
        static void Main()
        {
            char longOrNot = char.Parse(Console.ReadLine());

            if (char.IsLower(longOrNot))
            {
                Console.WriteLine("lower-case");
            }
            else if (char.IsUpper(longOrNot))
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}