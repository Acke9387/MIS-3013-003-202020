using System;

namespace Functions_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;

            bool shouldAskUserForFirstValue = true;
            double result = 0;

            do
            {
                double val1;
                if (shouldAskUserForFirstValue)
                {
                    Console.WriteLine("Please enter the first value >>");
                    val1 = Convert.ToDouble(Console.ReadLine()); 
                }
                else
                {
                    val1 = result;
                }

                Console.WriteLine("Please enter the second value >>");
                double val2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What type of equation do you want to perform? Add, Subtract, Multiplt or Divide >>");
                answer = Console.ReadLine();
                
                switch (answer.ToLower())
                {
                    case "add":
                        result = Add(val1, val2);
                        break;
                    case "subtract":
                        result = Subtract(val1, val2);
                        break;
                    case "multiply":
                        result = Multiply(val1, val2);
                        break;
                    case "divide":
                        result = Divide(val1, val2);
                        break;
                    default:
                        result = 0;
                        break;
                }
                Console.WriteLine($"The result of your calculation is {result.ToString("N4")}");

                Console.WriteLine("Do you want to perform another calculation? yes or no >>");
                answer = Console.ReadLine();

                if (answer.ToLower() == "yes")
                {
                    Console.WriteLine($"Do you want to use {result} as your first value? yes or no >>" );
                    string response = Console.ReadLine();

                    if (response.ToLower() == "yes")
                    {
                        shouldAskUserForFirstValue = false;
                    }
                    else
                    {
                        shouldAskUserForFirstValue = true;
                    }

                }

            } while (answer.ToLower() == "yes");
            
        }

        static void DeveloperInformation(string name, string course, string date)
        {
            Console.WriteLine($"This appliation was developed by {name} for {course} on {date}.");
        }

        static double Add(double v1, double val2)
        {
            double sum = v1 + val2;

            return sum;

            return v1 + val2;
        }

        static double Subtract(double v1, double val2)
        {
            
            return v1 - val2;
        }
        static double Divide(double v1, double val2)
        {

            return v1 / val2;
        }

        static double Multiply(double v1, double val2)
        {

            return v1 * val2;
        }

    }
}