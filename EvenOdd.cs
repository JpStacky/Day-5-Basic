namespace EvenOdd
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number  = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine("Number Is Even");
            else
                Console.WriteLine("Number is Odd");
        }
    }
}