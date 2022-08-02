namespace QuotientRemainder
{
    class Division
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Dividend ");
            float dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor");
            float divisor = Convert.ToInt32(Console.ReadLine());
            float quotient = dividend/divisor;
            float remainder = dividend%divisor;

            Console.WriteLine("Quotient is " +quotient);
            Console.WriteLine("Remainder is " +remainder);
        }
    }
}