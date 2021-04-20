using System;
using System.Collections.Generic;

namespace Classes_Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Toy> toys = new List<Toy>();


            Toy toy1 = new Toy()
            {
                Manufacturer = "Hasbro",
                Name = "Mr. Potato Head",
                Price = 7.99
            };
            toy1.Manufacturer = "Hasbro";
            toy1.AddNote("Children must be at least 4+ years old");
            toy1.AddNote("Pieces are a choking hazard");

            toys.Add(toy1);

            Console.WriteLine(toy1.ToString());
            Console.WriteLine();
            double x = 0;

            Toy toy2 = new Toy("Discontinued.");
            toy2.Manufacturer = "Hot Wheels";
            toy2.Name = "Limited edition Tesla Hot Wheels";
            toy2.Price = 49.99;
            toy2.AddNote("Elon bought all of them");

            toys.Add(toy2);

            Console.WriteLine(toy2);
        }
    }
}
