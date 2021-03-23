using System;
using System.Collections.Generic;

namespace Collections_MinMaxAvgMode
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>();
            Dictionary<double, int> examGrades = new Dictionary<double, int>();

            string answer;

            do
            {
                Console.WriteLine("Please enter your exam grade >>");
                double grade = Convert.ToDouble(Console.ReadLine());
                grades.Add(grade);

                if (examGrades.ContainsKey(grade) == false)
                {
                    examGrades.Add(grade, 1);
                }
                else
                {
                    examGrades[grade] = examGrades[grade] + 1;
                }

                Console.WriteLine("Do you have another exam grade to enter? yes or no >>");
                answer = Console.ReadLine();
            } while (answer.ToLower()[0] == 'y');

            double min = grades[0];
            foreach (double grade in grades)
            {
                if (grade < min)
                {
                    min = grade;
                }
            }

            Console.WriteLine($"Your minimum exam grade is {min.ToString("N2")}.");

            int maxOccurrences = 0;
            foreach (double key in examGrades.Keys)
            {
                double grade = key;
                if (examGrades[grade] > maxOccurrences)
                {
                    maxOccurrences = examGrades[grade];
                }
            }

            foreach (double key in examGrades.Keys)
            {
                double grade = key;
                if (examGrades[grade] == maxOccurrences)
                {
                    Console.WriteLine($"The grade that appears the most times is {grade} x {maxOccurrences}");
                }
            }

        }
    }
}
