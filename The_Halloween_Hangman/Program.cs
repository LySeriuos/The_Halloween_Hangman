﻿namespace The_Halloween_Hangman
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
            char[]randomWordLetters = randomWord.ToCharArray(); // converting string to char Array


            int found;
            int totFinds = 0;
            int i;
            int countLetters = 0; // variable for total letters in the word

            foreach (char ch in randomWordLetters) // going thru every letter in the randomWord to get total letters 
            {                
                countLetters++; //adding letters
                Console.WriteLine(countLetters);
            }

            int newOne = countLetters;
            Console.WriteLine(newOne);


            // 1. make and for loop which is exact length as the random word and print underscores
            // 2. this part of the code is getting the indexes of matching letter with userInput 
            // 3. later I need to change empty indexes to the letter it was matching
            do
            {
                               
                
                Console.WriteLine();
                ; Console.WriteLine("Guess the letter!"); // Asking for user's input
                string userInput = Console.ReadLine(); // reading user's input
                bool validUserInput = randomWord.Contains(userInput);
                Console.Write("_");
                if (userInput != "") // check if user input is not empty 
                {
                    for (i = 0; i < randomWord.Length; i++) // check thru the chosen word 
                    {

                        found = randomWord.IndexOf(userInput, i); //getting the indexes of the letters

                        char currentChar = randomWord[i];
                        char userChar = userInput[0];

                        if (userChar == currentChar)
                        {

                        }

                        if (found >= 0) // if index is higher or equal to 0 we can count how many times the same letter was found
                        {
                            totFinds++; //counting finds
                            i = found; // getting index numbers
                            Console.WriteLine(i);
                        }
                        else
                        {
                            break;
                        }
                    }

                }
                else
                {
                    return;
                }

                Console.WriteLine($"The search parameter {userInput} was found {2} times.",
                        Environment.NewLine, userInput, totFinds); //TODO: use string interpolation.

                totFinds = 0;
                if (validUserInput != true) // if the users input doesn't match any letter it gives this error
                {
                    Console.WriteLine("Your letter doesn't match with any in the word");
                }
            } while (true);


















            //for (int i = 0; i < randomWord.Count(); i++)
            //{
            //    Console.Write("the letters"[i]);
            //    //Regex.Replace(randomWord, "([A-Z])", "_$1");
            //    //Console.WriteLine(Regex.Replace(randomWord[i], "([A-Z])", "_$1"));
            //}



            // Console.WriteLine("The string '{0}' contains '{1}'? -> '{0}'", randomWord, userInput, validUserInput, words);
            // Console.WriteLine($"The string '{randomWord}' contains '{userInput}'? -> '{validUserInput}'");

        }
    }

}
