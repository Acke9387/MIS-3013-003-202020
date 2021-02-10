using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your lucky # (whole number) >>");
            string answer = Console.ReadLine();
            int luckyNbr;

            bool isAnswerAInteger = int.TryParse(answer, out luckyNbr);

            if (isAnswerAInteger == false)
            {
                Console.WriteLine("Sorry that was an invalid number. Goodbye.");
                //return;
                Environment.Exit(-1);
            }

            //int luckyNbr = Convert.ToInt32(Console.ReadLine());

            int remainder = luckyNbr % 7;

            if (remainder == 0)
            {
                //ctrl + k + d for formatting
                Console.WriteLine($"{luckyNbr.ToString("N0")} is really a lucky number !!!");
            }
            else if (luckyNbr % 13 == 0)
            {
                Console.WriteLine($"{luckyNbr.ToString("N0")} is really an unlucky number :(");
            }
            else
            {
                Console.WriteLine($"meh ... {luckyNbr.ToString("N0")}");
            }

            Console.WriteLine("What is your first name >>");
            string name = Console.ReadLine();

            switch (name.ToLower())
            {
                case "adam":
                    Console.WriteLine("That's the coolest name ever!");
                    break;
                case "darby":
                    Console.WriteLine("That's a cool name, but nothing like Adam");
                    break;
                default:
                    Console.WriteLine("cool");
                    break;
            }

        }
    }
}
