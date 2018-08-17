using System;
using System.Text;

namespace CG6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //The first sentence of Alice in Wonderland is below. Store this sentence
            //in a string, and then prompt the user for a string to search for within
            //this string. Print whether the search term was found. See if you can make
            //the search case-insensitive, so that searching for “alice” prints true.

            //Upload your program to a new repository called CG 6 - 3.
            //Upload a link to your repository here when you are finished.


            Console.WriteLine("Please enter any word and this program will search in " +
                              "the phrase below for that word.\n");

            string myString = "Alice was beginning to get very tired of sitting by" +
                            " her sister on the bank, and of having nothing to do: once or twice " +
                            "she had peeped into the book her sister was reading, but it had no " +
                            "pictures or conversations in it, ‘and what is the use of a book,’ " +
                            "thought Alice ‘without pictures or conversation?’\n";

            //string upperMyString = myString.ToUpper();


            Console.WriteLine(myString);

            Console.WriteLine("Enter the word to be searched.");

            string input = Console.ReadLine();
            //string upperInput = input.ToUpper();

            var start = myString.ToUpper().IndexOf(input.ToUpper());
            

            if (start >= 0)
            {
                Console.WriteLine("Your word is in the phrase at position " + start);
            }

            else
            {
                Console.WriteLine("Bad choice, not in the phrase.");
            }

            
            Console.ReadLine();

            

            


            


        }
    }
}
