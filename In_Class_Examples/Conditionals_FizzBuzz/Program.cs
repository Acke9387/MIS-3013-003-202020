using System;

/*
 Generate a random number with a range between 1 and 100, using the Random class.  
Once you have the random number generated, we will play the FizzBuzz Game.

If the number they provided to you is divisible by 3, then you should output the word 'Fizz'.
If the number is divisible by 5, then you should output the word 'Buzz'.
If the number is divisible by 3 AND 5, then you should output the word 'Fizz Buzz'
If the number is NOT divisible by either, just output the number back out.

e.g. 1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, Fizz Buzz, 16, 17, Fizz, 19, Buzz, Fizz, 22, 23, Fizz, Buzz, 26, Fizz, 28, 29, Fizz Buzz, 31, 32, Fizz, 34, Buzz, Fizz, ... 
  
 */

namespace Conditionals_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNbr = rand.Next(1, 101);//Generate a randomn number between 1 and 100
            int divisableBy3Remainder = randomNbr % 3;
            bool isDivisibleBy3 = divisableBy3Remainder == 0;
            
            
            if (randomNbr % 3 == 0
                  && randomNbr % 5 == 0)// == true)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (randomNbr % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (randomNbr % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(randomNbr);
            }

        }
    }
}
