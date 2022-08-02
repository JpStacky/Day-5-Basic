namespace Harmonic{
    class HarmonicNum
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a value = ");
            int value = Convert.ToInt32(Console.ReadLine());
            
            double sum = 0;
            Console.Write("1");
            
            for (int i = 1; i <= value; i++)
            {
                Console.Write(" + 1/" + i);
                sum += 1/(float)i;

            }
            Console.Write(" = "+sum);
        }
    }
}