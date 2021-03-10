using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "55s";
            int realNumber;// = Convert.ToInt32(number);
            bool b = int.TryParse(number, out realNumber);
            if (b == true)
            {
                Console.WriteLine("Ayyy good #");
            }
            else
            {
                Console.WriteLine("Ayy, bad #");
                //return;
                Environment.Exit(-1);
            }

            Console.WriteLine(number + 5);

        }
    }
}
