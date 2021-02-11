using System;

namespace P2_CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNbr = rand.Next(1,3); //generate a random # between 1 and 2

            Console.WriteLine(randomNbr);

            // 1 = heads
            // 2 = tails

            // Ask the user for heads or tails

            // generate random number (done above)

            // Convert either the user's answer to an int or our random number to a string

            // See if they guessed right with the newly converted value


        }
    }
}
