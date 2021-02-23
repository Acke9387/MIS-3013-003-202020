using System;

namespace P2_CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1 = heads
            // 2 = tails
            const int HEADS = 1;
            const int TAILS = 2;

            // generate random number (done above)
            Random rand = new Random();
            int randomNbr = rand.Next(1, 3); //generate a random # between 1 and 2

            //This is only for testing purposes so i can know i guess right/wrong
            Console.WriteLine(randomNbr);

            // Ask the user for heads or tails
            Console.WriteLine("Heads or Tails? >>");
            string answer = Console.ReadLine();

            // Convert either the user's answer to an int or our random number to a string
            int answerAsInt = 0;

            if (answer.ToLower() == "tails")
            {
                answerAsInt = TAILS;
            }
            else if (answer.ToLower() == "heads")
            {
                answerAsInt = HEADS;
            }
            else
            {
                //answerAsInt = 0;
                Console.WriteLine("INCORRECT INPUT.  GOODBYE!");
                Environment.Exit(-1);
            }

            // See if they guessed right with the newly converted value
            if (randomNbr == HEADS)
            {
                Console.WriteLine($"The flip came up HEADS");
            }
            else
            {
                Console.WriteLine($"The flip came up TAILS");
            }

            if (randomNbr == answerAsInt)
            {
                Console.WriteLine($"Congratulations, you guessed right!");
            }
            else
            {
                Console.WriteLine("Shucks, you guessed incorrectly.");
            }




        }
    }
}
