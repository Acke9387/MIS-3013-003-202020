using System;

namespace P1_SumOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double MAGIC_NUMBER = 7.777;//local constant variable

            //MAGIC_NUMBER = 8;

            Console.WriteLine("Please enter the first number >>");
            string answer = Console.ReadLine();
            double num1 = Convert.ToDouble(answer);

            Console.WriteLine("Please enter the second number >>");
            answer = Console.ReadLine();
            double num2 = Convert.ToDouble(answer);

            Console.WriteLine("Please enter the third number >>");
            answer = Console.ReadLine();
            double num3 = Convert.ToDouble(answer);

            double sum = num1 + num2 + num3;

            Console.WriteLine($"{num1} + {num2} + {num3} = {sum.ToString("N3")}");

            double magicNumberTimesSum = sum * MAGIC_NUMBER;

            Console.WriteLine($"Your sum multiplied by our magic number is {magicNumberTimesSum.ToString("N3")}!");

        }
    }
}
