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
            Console.WriteLine(randomWord); // printing random word in the Console                                           // 
            int randomWordLength = randomWord.Length; // getting the length of the randomWord            
            var listOfChars = new List<char>(); // creating a chars list for underscores
            var listOfBadLettersInChar = new List<char>();
            var listOfAllInputChars = new List<char>();
            int totFinds = 0; // variableto count how many letters is equal to the the userInput
            Console.WriteLine("\n\t\t\t\t\tWelcome to The Hangman! \n\n\t\tYou guess the word by guessing letters one at a time. \n\t\tYou are allowed seven mistakes! \n\n\t\t\t\t\tGood luck!!!");
            do
            {
                for (int i = 0; i < randomWordLength; i++)
                {
                    listOfChars.Add('_');
                    Console.Write(listOfChars[i]);
                }               

                Console.WriteLine("\n\n\r\nGuess the letter!"); // Asking for user's input
                string userInput = Console.ReadLine().ToLower(); // reading user's input
                if (userInput != "") // check if user input is not empty 
                {
                    for (int i = 0; i < randomWord.Length; i++) // check thru the chosen word 
                    {
                        char currentChar = randomWord[i]; // converting string to char 
                        char userChar = userInput[0]; // converting userInput to char


                        if (userChar == currentChar) // checking if letter in the randomWord is the same as userInput
                        {
                            totFinds++; //counting finds
                            listOfChars[i] = userInput[0]; // changing underscore to letter in the listOfChars
                            Console.WriteLine($"\n\nThe letter {userInput} was found {totFinds} times in the word.\n");
                        }                        
                    }                    
                }
                else
                {
                    return;
                }

                if (listOfChars[0] != userInput[0]) // if the users input doesn't match any letter
                {
                    listOfBadLettersInChar.Add(userInput[0]); // adding letter to a bad letters list
                    Console.WriteLine("\nYour letter doesn't match with any in the word\n"); // Printing out information that letter doesn't match any in the letter

                }

                Console.WriteLine("Your's guessed wrong letters: "); // Printo
                foreach (char badLettersChar in listOfBadLettersInChar)
                {
                    Console.Write(badLettersChar);
                }

                Console.WriteLine($"\n\nThe search parameter {userInput} was found {totFinds} times.");

            } while (true);
            
        }

    }
}