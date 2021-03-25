using System;
using System.Collections.Generic;

namespace Collections_AllTypesOfCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1


            // Problem 2


            // Problem 3
           
            Dictionary<string, List<double>> courseGrades = new Dictionary<string, List<double>>();
            courseGrades.Add("MIS3013", new List<double>()); // First way
            courseGrades["MIS3013"].Add(0.75);
            courseGrades["MIS3013"].Add(0.100);
            courseGrades["MIS3013"].Add(0.80);

            List<double> mis3033Grades = new List<double>(); // Second way, does same thing as first
            mis3033Grades.Add(100);
            mis3033Grades.Add(70);
            mis3033Grades.Add(99);
            courseGrades.Add("MIS3033", mis3033Grades);

            foreach (string courseCode in courseGrades.Keys)
            {
                List<double> grades = courseGrades[courseCode];

                Console.WriteLine(grades);
            }

        }
    }
}
