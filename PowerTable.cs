namespace PowerTable
{
    class PowerTable
    {
        //Input will be from command-line
        public static void Main(string[] args)
        {
            int value = Convert.ToInt32(args[0]);
            Console.WriteLine("Command-Line Input is = " +value);
            for (int i = 1; i <= value; i++)
                Console.WriteLine("2 ^ " + i + " = " + Math.Pow(2, i));
        }
    }
}