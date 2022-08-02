namespace FlipCoin
{
    class FlipTheCoin
    {
        public static void Main(string[] args)
        { 
            Random random = new Random();
            Console.WriteLine("Enter the no. of times to flip the coin = ");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            float head = 0;
            float tail = 0;
            while(temp > 0)
            { 
                int toss = random.Next(2);
                if (toss == 0)
                    ++head;
                else
                    ++tail;
                --temp;
            }
            head = (head / num) * 100;
            tail = (tail / num) * 100;
            Console.WriteLine("Head comes out " +head+ "%");
            Console.WriteLine("Tail comes out " +tail+ "%");
        }
    }
}