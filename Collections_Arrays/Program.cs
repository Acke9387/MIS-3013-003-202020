using System;

namespace Collections_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            string[] studentIds = new string[3];
            for (int i = 0; i < studentIds.Length; i++)
            {
                studentIds[i] = rand.Next(1300000, 1400000).ToString();
            }

            double[] studentGPAs = { 3.0, 4.0, 2.7 };

            // Display all the ID's
            //for (int i = 0; i < studentIds.Length; i++)
            //{
            //    string id = studentIds[i];
            //    Console.Write($"\t {id}");
            //}
            
            foreach (string id in studentIds)
            {
                Console.Write($"\t {id}");
            }

            Console.WriteLine("\nWhose GPA do you want to see? >>");
            string idToLookFor = Console.ReadLine();

            for (int i = 0; i < studentIds.Length; i++)
            {

                if (studentIds[i] == idToLookFor)
                {
                    double gpa = studentGPAs[i];
                    Console.WriteLine($"{idToLookFor} has a {gpa.ToString("N2")}");
                }
            }

        }
    }
}
