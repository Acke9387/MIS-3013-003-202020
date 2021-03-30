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
            List<double> prob2_grades = new List<double>();
            string answer;
            do
            {
                Console.WriteLine("What is your grade? >>");
                answer = Console.ReadLine();
                prob2_grades.Add(Convert.ToDouble(answer));

                Console.WriteLine("Do you have another grade to enter? yes or no >>");
                answer = Console.ReadLine();
            } while (answer.ToLower()[0] == 'y');
            double prob2_sum = 0;
            foreach (double grade in prob2_grades)
            {
                prob2_sum += grade;
            }

            Console.WriteLine($"Prob 2 avg is {prob2_sum/prob2_grades.Count}");
         
            #region Problem 3
            Dictionary<string, List<double>> courseGrades = new Dictionary<string, List<double>>();
            courseGrades.Add("MIS3013", new List<double>()); // First way
            courseGrades["MIS3013"].Add(0.75);
            courseGrades["MIS3013"].Add(0.100);
            courseGrades["MIS3013"].Add(0.80);

            List<double> mis3033Grades = new List<double>(); // Second way, does same thing as first
            mis3033Grades.Add(1.00);
            mis3033Grades.Add(.70);
            mis3033Grades.Add(.99);
            courseGrades.Add("MIS3033", mis3033Grades);

            courseGrades.Add("MIS3353", new List<double>()); // First way
            courseGrades["MIS3353"].Add(0.75);
            courseGrades["MIS3353"].Add(0.10);
            courseGrades["MIS3353"].Add(0.80);

            foreach (string courseCode in courseGrades.Keys)
            {
                List<double> grades = courseGrades[courseCode];
                double sum = 0;
                foreach (double grade in grades)
                {
                    sum += grade;
                }
                    Console.WriteLine($"The avg for {courseCode} is {(sum/grades.Count).ToString("P")}");
            }
            #endregion
        }
    }
}
