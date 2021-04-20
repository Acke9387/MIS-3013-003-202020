using System;

namespace Functions_Speak
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter an animal >>");
                string response = Console.ReadLine();

                string sound = Speak(response);

                Console.WriteLine($"{response} makes the sound {sound}");

                Console.WriteLine("Do you want to go again? yes or no >>");
            } while (Console.ReadLine().ToLower() == "yes");

        }

        static string Speak(string animal)
        {
            string noise;

            if (animal == "Dog")
            {
                noise = "Woof";
            }
            else if (animal == "Cat")
            {
                noise = "Purr";
            }
            else if (animal == "Giraffe")
            {
                noise = "Pffft";
            }
            else
            {
                noise = "GRRRR";
            }

            return noise;

        }
    }
}
