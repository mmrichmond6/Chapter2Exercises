using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstSentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do:  once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book, ' thought Alice 'without pictures or conversation?'";

            Console.WriteLine("Strings Exercise");
            Console.WriteLine(firstSentence);
            
            Console.WriteLine("What term would you like me to find within this sentence?");
            string searchTerm = Console.ReadLine();

            string firstSentenceLC = firstSentence.ToLower();
            string searchTermLC = searchTerm.ToLower();
            int searchTermLength = searchTermLC.Length;

            int found = firstSentenceLC.IndexOf(searchTermLC);
            int cutLength = found + searchTermLength;



            if (found != -1)
            {
                string firstHalf = firstSentence.Substring(0, found);
                string secondHalf = firstSentence[cutLength..];
                string newSentence = firstHalf + secondHalf;
                Console.WriteLine("The term you indicated ('" + searchTerm + "') was found at index " + found + " and has a length of " + searchTermLength + " characters.");
                Console.WriteLine("A new sentence without your term would be:  " +  newSentence);
            } else
            {
                Console.WriteLine("The term you indicated ('" + searchTerm + "') was not found within the sentence.");
            }
        }
    }
}
