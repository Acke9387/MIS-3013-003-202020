using System;
using System.Collections.Generic;
using System.IO;

namespace Classes_Cereal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cereal> bowls = new List<Cereal>();
            string[] lines = File.ReadAllLines("Cereal_Data.txt");
            //[0] = "name|manufacturer|calories|cups"
            //[1] = "100% Bran|Nabisco|70|0.33"
            //[..] = ".."

            // Read in all the data from the file and make Cereal objects and add those to our bowls collection
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                //Line = "100% Bran|Nabisco|70|0.33"

                string[] pieces = line.Split('|');
                //                0           1       2      3
                //pieces = { "100% Bran", "Nabisco", "70", "0.33" }
                Cereal c = new Cereal();
                c.Name = pieces[0];
                c.Manufacturer = pieces[1];
                c.Calories = Convert.ToDouble(pieces[2]);
                c.Cups =     Convert.ToDouble(pieces[3]);

                bowls.Add(c);
            }

            // Go through bowls and output the desired cereals


        }
    }
}
