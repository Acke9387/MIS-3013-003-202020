using System;

namespace P2_CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNbr = rand.Next(1,3); // generate a random # between 1 and 2

            Console.WriteLine(randomNbr);
        }
    }
}
