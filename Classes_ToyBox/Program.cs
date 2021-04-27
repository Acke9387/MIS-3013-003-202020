using System;
using System.Collections.Generic;

namespace Classes_ToyBox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ToyBox> toyboxes = new List<ToyBox>();
            string answer;

            //toyboxes = GenerateTestData();

            do
            {
                toyboxes.Add(GetToyBoxInformationFromUser());

                Console.WriteLine("Do you want to create another ToyBox? yes or no >>");
            } while (Console.ReadLine().ToLower() == "yes");


            foreach (ToyBox toybox in toyboxes)
            {
                Console.WriteLine($"Time to fill {toybox.Owner}'s ToyBox with Toys!");

                do
                {
                    Toy usersToy = GetToyInformationFromUser();

                    toybox.Toys.Add(usersToy);
                    Console.WriteLine("Do you have another toy to enter? yes or no >>");
                    answer = Console.ReadLine();

                } while (answer.ToLower() == "yes");
            }


            //Output All toys for each ToyBox
            foreach (ToyBox toyBox in toyboxes)
            {
                Console.WriteLine($"All the toy's from {toyBox.Owner}'s ToyBox:");
                foreach (Toy toy in toyBox.Toys)
                {
                    Console.WriteLine(toy);
                }
            }

            //Output a random toy from each ToyBox
            foreach (ToyBox toyBox in toyboxes)
            {
                Console.WriteLine($"Random toy from {toyBox.Owner}'s ToyBox:");
                Console.WriteLine(toyBox.GetRandomToy());
            }

        }

        private static List<ToyBox> GenerateTestData()
        {
            ToyBox tb1 = new ToyBox();
            tb1.Owner = "Adam";
            tb1.Location = "Somewhere";
            tb1.Toys.Add(new Toy()
            {
                Manufacturer = "hasbro",
                Name = "slinky",
                Price = 4.99
            });

            List<ToyBox> tbs = new List<ToyBox>();
            tbs.Add(tb1);

            return tbs;
        }

        private static ToyBox GetToyBoxInformationFromUser()
        {
            ToyBox tb1 = new ToyBox();
            Console.WriteLine("What is the location for the ToyBox? >>");
            tb1.Location = Console.ReadLine();

            Console.WriteLine("Who is the owner of the ToyBox? >>");
            tb1.Owner = Console.ReadLine();

            return tb1;
        }

        private static Toy GetToyInformationFromUser()
        {
            Toy t1 = new Toy();
            Console.WriteLine("Please enter the notes about the Toy >>");
            t1.AddNote(Console.ReadLine());

            Console.WriteLine("Who manufactured the Toy? >>");
            t1.Manufacturer = Console.ReadLine();

            Console.WriteLine("What is the name of the Toy? >>");
            t1.Name = Console.ReadLine();

            Console.WriteLine("What is the price of the Toy? >>");
            t1.Price = Convert.ToDouble(Console.ReadLine());

            return t1;
        }
    }
}
