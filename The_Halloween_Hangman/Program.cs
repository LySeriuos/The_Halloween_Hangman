using System;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace The_Halloween_Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); // activating random function
            var words = new List<string>() { "money", "danger", "aloof", "scheme", "observer", "abolish", "goalkeeper",
                "conviction", "allowance", "arrogant", "separation", "environment",
                "protection", "deteriorate", "economist", "continental", "mushroom",
                "repetition", "unlawful", "arrogant", "jazz" };

            int wordsIndex = random.Next(words.Count); // picking random index in the list
            string randomWord = words[wordsIndex]; // getting the value of the index
            Console.WriteLine(randomWord); // printing random word in the Console
            // int randomWordLetterIndex = randomWord.Count();
            for(int i = 0; i < randomWord.Count(); i++)
            {
                Console.Write("_");
                //Regex.Replace(randomWord, "([A-Z])", "_$1");
                //Console.WriteLine(Regex.Replace(randomWord[i], "([A-Z])", "_$1"));
            }
            Console.WriteLine("Guess the letter!");
            
            string userInput = Console.ReadLine();
            bool validUserInput = randomWord.Contains(userInput);
            
            
           // Console.WriteLine("The string '{0}' contains '{1}'? -> '{0}'", randomWord, userInput, validUserInput, words);
            Console.WriteLine($"The string '{randomWord}' contains '{userInput}'? -> '{validUserInput}'");
            if (validUserInput)
            {
                Console.WriteLine("Working");
            }
        }
    }
}
