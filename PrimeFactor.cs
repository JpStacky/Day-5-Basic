namespace PrimeFactor
{
    class PrimeNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number to find Prime Factors ");
            int num = Convert.ToInt32(Console.ReadLine());
            int count;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    count = 0;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                            ++count;
                    }
                    if (count == 0)
                        Console.WriteLine(i);
                }
            }
        }
    }
}