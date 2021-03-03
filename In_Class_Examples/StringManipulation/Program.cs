/*
 Create a string variable that holds the following value:

"tAylOr SwIFt, tHe WeEknD, TRaVis sCoTt, aRiANa gRAndE, bIlLiE eiLiSh"

Create an application that will separate the above string into an array of string variables. Make the first character of the first and last name upper case and everything else lower case i.e. Taylor Swift

Display the list to the user.
*/

using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //               01234567
            string artist = "tAylOr SwIFt";
            //string newValue = artist.ToLower();
            artist = artist.ToLower();

            //                                      T         + AylOr 
            string artistWithProperName = artist.ToUpper()[0] + artist.Substring(1, 6)
                + artist.ToUpper()[7] + artist.Substring(8);
            //       T               +   wift

            string realProblem = "tAylOr SwIFt, tHe WeEknD, TRaVis sCoTt, aRiANa gRAndE, bIlLiE eiLiSh";

            string[] artistNames = realProblem.Split(", ");

            for (int i = 0; i < artistNames.Length; i++)
            {
                string tist = artistNames[i].ToLower();
                //first way
                int spaceLocation = tist.IndexOf(' ');
                artistWithProperName = tist.ToUpper()[0] + tist.Substring(1, spaceLocation)
                + tist.ToUpper()[spaceLocation + 1] + tist.Substring(spaceLocation + 2);
                Console.WriteLine(artistWithProperName);
                //second way
                string[] names = tist.Split(' ');
                string firstName = names[0];
                string lastName = names[1];

                firstName = firstName.ToUpper()[0] + firstName.Substring(1);
                lastName = lastName.ToUpper()[0] + lastName.Substring(1);

                Console.WriteLine($"{firstName} {lastName}");
                Console.WriteLine();
            }

            //for (int i = 0; i < artistWithProperName.Length; i++)
            //{
            //    Console.WriteLine(artistWithProperName[i]);
            //}


            //Console.WriteLine(artistWithProperName);

        }
    }
}
