namespace _04.CenturiesToMinutes
{
    internal class Program
    {
        static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;

            int days = (int)(years * 365.2422);

            double hours = 24 * days;

            double minutes = 60 * hours;

            decimal sum = 0;


            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}