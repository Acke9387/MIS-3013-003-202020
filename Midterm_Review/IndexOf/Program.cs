using System;

namespace IndexOf
{
    class Program
    {
        
        static string msg2;
        static void Main(string[] args)
        {
            //            0123456789...
            const string msg = "Hello World!";

            double indexOfTheFirstW = msg.IndexOf('W');
            char middleInitial = 'P';

            msg2 = "Adam";

            Console.WriteLine(msg);
            Console.WriteLine($"It exists \"{indexOfTheFirstW.ToString("C2")}\"");
        }
    }
}
