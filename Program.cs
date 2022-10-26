internal class Program
{
    private static void Main(string[] args)
    {
        string city = "Knoxville";
        ShowCharcter(city);
        static void ShowCharcter(string city, int x = 1)
        {
            Console.WriteLine($"The letter in the 2nd index of {city} is {city[x]}.");
        }



        int wholesale = 20;
        int markup = 50;
        int retail = wholesale * markup / 100 + wholesale;

        int x = CalculateRetail(wholesale, markup, retail);

        static int CalculateRetail(int wholesale, int markup, int retail)
        {
            Console.WriteLine($"The total retail cost of the item is {retail}.");
            return retail;
        }



        static void Celsius()
        {
            Console.WriteLine("Enter degrees (-500 - 500) :");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"It is {celsius} degrees outside.");
            Console.WriteLine(" The conversion from Fahrenheit to Celsius 80 - 100 degress:");
            for (int i = 80; i < 101; i++)
            {
                Console.WriteLine($"Degrees : Fahrenheit {i} Celsius" + (i - 32) * 5 / 9);
            }
        }
        Celsius();



        static bool IsPrime(int number)
        {
            if (number % 2 == 0)
            {
                return false;
            }
            for (int denominator = 3; denominator < Math.Sqrt(number); denominator += 2)
            {
                if (number % denominator == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}