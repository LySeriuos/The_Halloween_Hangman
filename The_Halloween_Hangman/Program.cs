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
            int randomWordsLength = randomWord.Length; // getting the length of the randomWord
            string[] underscores = new string[randomWordsLength]; // creating new array for underscores
            var listOfChars = new List<char>();

            int totFinds = 0;


            for (int i = 0; i < underscores.Length; i++)
            {
                listOfChars.Add('_');
            }

            do
            {
                //Console.WriteLine($"\n\n\r\n{listOfChars}");
                char[] underscoreChars = listOfChars.ToArray();
                for (int i = 0; i < underscoreChars.Length; i++)
                {
                    Console.Write(underscoreChars[i]);
                }

                Console.WriteLine("\n\n\r\nGuess the letter!"); // Asking for user's input
                string userInput = Console.ReadLine(); // reading user's input
                bool validUserInput = randomWord.Contains(userInput);
                if (userInput != "") // check if user input is not empty 
                {
                    for (int i = 0; i < randomWord.Length; i++) // check thru the chosen word 
                    {

                        //        found = randomWord.IndexOf(userInput, i); //getting the indexes of the letters
                        //         Console.Write(found);
                        char currentChar = randomWord[i]; 
                        char userChar = userInput[0];

                        // Add for each to get thru every index with the same char
                        if (userChar == currentChar)
                        {            
                            totFinds++; //counting finds
                            listOfChars[i] = userInput[0];
                            //                     listOfChars[found] = userInput; // updating the underscore by index to the letter by the same index                            
                        }

                        //if (found > 0) // if index is higher or equal to 0 we can count how many times the same letter was found
                        //{
                        //    i = found ; // getting index numbers
                        //}
                        //else
                        //{
                        //    break;
                        //}
                    }
                }
                else
                {
                    return;
                }

                Console.WriteLine($"The search parameter {userInput} was found {totFinds} times."); //TODO: use string interpolation.

                totFinds = 0;
                if (validUserInput != true) // if the users input doesn't match any letter it gives this error
                {
                    Console.WriteLine("Your letter doesn't match with any in the word");
                }
            } while (true);


        }
    }
}