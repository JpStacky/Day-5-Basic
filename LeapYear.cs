namespace Program
{
    class LeapYear
    {
        public static void Main(string[] args)
        {
            //Taking input
            Console.WriteLine("Enter a year (Considering year after 999 as a valid input) = ");
            string year = Console.ReadLine();

            //To check the input is 4-digit or not
            //To check the year is leap year or not
            if (year.Length == 4)
            {
                if (Convert.ToInt32(year) % 4 == 0)
                    Console.WriteLine("The year, " + year + " is a Leap year");
                else
                    Console.WriteLine("The year, " + year + " is not a Leap year");
            }
            else
                Console.WriteLine("Invalid Input");

        }
    }
}