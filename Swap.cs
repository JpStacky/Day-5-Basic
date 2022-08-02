namespace SwapNumber
{
    class Swap
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a First Number");
            int first_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Second Number");
            int second_number = Convert.ToInt32(Console.ReadLine());

            swap(first_number, second_number);
        }
        static void swap(int first_number, int second_number)
        { 
            first_number = first_number + second_number;
            second_number = first_number - second_number;
            first_number = first_number - second_number;
            Console.WriteLine("After Swapping");
            Console.WriteLine("First Number = " + first_number);
            Console.WriteLine("Second Number = " + second_number);
        }
    }
}