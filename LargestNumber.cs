namespace LargestNumber
{
    class Largest
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter First Number ");
            int first_number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number ");
            int second_number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Number ");
            int third_number = Convert.ToInt32(Console.ReadLine());

            int max = first_number;
            if(max < second_number)
                max = second_number;
            if(max < third_number)
                max =third_number;
            Console.WriteLine("Largest Number = "+max);
        }
    }
}