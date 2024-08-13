namespace _03.ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main()
        {
            decimal numbers = decimal.Parse(Console.ReadLine());

            decimal sum = 0;

            for (int i = 0; i < numbers; i++)
            {
                decimal currentNum = decimal.Parse(Console.ReadLine());
                sum += currentNum;
            }


            Console.WriteLine(sum);
        }
    }
}