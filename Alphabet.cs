namespace Alphabet
{
    class VowelCons
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an alphabet");
            string alpha = Console.ReadLine();
            string alpha_lower = alpha.ToLower();
            char ch= Convert.ToChar(alpha_lower);

            if (alpha_lower == "a" || alpha_lower == "e" || alpha_lower == "i" || alpha_lower == "o" || alpha_lower == "u")
                Console.WriteLine("Alphabet is a Vowel");
            else if (ch > 'a' && ch < 'z')
                Console.WriteLine("Alphabet is Consonant");
            else
                Console.WriteLine("Invalid Input!! Please enter an alphabet");
        }
    }
}