using System;

namespace VariablesInputConversionFormatting_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName;
            double gpa;

            Console.WriteLine("Please enter your first name >>");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name >>");
            lastName = Console.ReadLine();

            Console.WriteLine("Please enter your gpa >>");
            string gpaAsString = Console.ReadLine();
            gpa = Convert.ToDouble(gpaAsString);

            gpa = gpa + .5; // idk why but we want to bump everyones gpa by .5

            string output = "Hello " + firstName + " " + lastName + "! " +
                            " we boosted your gpa to " + gpa.ToString("N3");
            //output = $"Hello {firstName} {lastName}! we boosted your gpa to {gpa.ToString("N3")}";


            Console.WriteLine(output);
        }
    }
}
