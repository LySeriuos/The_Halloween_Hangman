namespace The_Halloween_Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); // activating random function
            var words = new List<string>() { "money", "danger", "aloof", "scheme", "jazz", "volume", "lady", "sector", "guitar",
            "death", "winner", "ladder", "cousin", "driver", "farmer", "engine", "worker", "aspect", "memory", "cookie", "cancer", "income",
            "agency", "method", "wedding", "payment", "message", "clothes", "science", "queen"};
            int wordsIndex = random.Next(words.Count); // picking random index in the list
            string randomWord = words[wordsIndex]; // getting the value of the index
            List<char> randomWordToCharList = new List<char>(); // creating a list to randomWord
            randomWordToCharList.AddRange(randomWord); // add chars from string to a list
            Console.WriteLine(randomWord); // printing random word in the Console                
            int randomWordLength = randomWord.Length; // getting the length of the randomWord          
            var listOfChars = new List<char>(); // creating a chars list for underscores
            var listOfGoodLettersInChar = new List<char>();
            var listOfAllInputChars = new List<char>();
            int tries = 0;
            Console.WriteLine("\n\t\t\t\t\tWelcome to The Hangman! \n\n\t\tYou guess the word by guessing letters one at a time. \n\t\tYou are allowed seven mistakes! \n\n\t\t\t\t\tGood luck!!!");
            do
            {
                Console.WriteLine();
                for (int i = 0; i < randomWordLength; i++)
                {
                    listOfChars.Add('_');
                    Console.Write($"{listOfChars[i]}"); // printing out underscores for every letter in the word
                }
                Console.WriteLine("\n\n\r\nGuess the letter!"); // Asking for user's input
                string userInput = Console.ReadLine().ToLower(); // reading user's input

                if (userInput != "") // check if user input is not empty 
                {
                    char userChar = userInput[0]; //TODO: valiidate input here
                    listOfAllInputChars.Add(userChar); // adding all userInput letters to the list
                    tries++;

                    for (int i = 0; i < randomWord.Length; i++) // check thru the chosen word 
                    {
                        char currentChar = randomWord[i]; // converting string to char 
                        if (userChar == currentChar) // checking if letter in the randomWord is the same as userInput
                        {
                            listOfChars[i] = userChar; // changing underscore to letter in the listOfChars
                            listOfGoodLettersInChar.Add(userChar); // adding to the list guessed right letters
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Your input is empty! Please guess your letter!");
                    string userInputAfterInputWasEmpty = Console.ReadLine().ToLower(); // reading userInput after it was empty
                    char userCharAfterInputWasEmpty = userInputAfterInputWasEmpty[0]; // converting user's Input to char                    
                    if (userInputAfterInputWasEmpty != "") // checking if user input is not empty again
                    {
                        listOfAllInputChars.Add(userCharAfterInputWasEmpty); // if it is not empty, add letter to the list of all letters
                    }
                }
                // checking if listOfGoodLettersInChar is equal to randomWordToCharList
                bool isEqual = randomWordToCharList.All(listOfGoodLettersInChar.Contains) && listOfGoodLettersInChar.All(randomWordToCharList.Contains);
                if (isEqual == true)
                {
                    Console.WriteLine($"You won! The random word is {randomWord.ToUpper()}"); // printing out message 
                    break; // jumping out the code
                }
                var listOfBadLettersInChar = listOfAllInputChars.Except(listOfGoodLettersInChar).ToList(); // comparing two lists and creating new list
                                                                                                           // with letters wich doesn't match
                Console.WriteLine("Your's guessed wrong letters: "); // printing out wrong letters
                foreach (char badLettersChar in listOfBadLettersInChar)
                {
                    Console.Write(badLettersChar + ","); // printing list with ',' in between them
                }
                Console.WriteLine(); // empty line for extra empty row
            } while (tries < 7);

            if (tries > 7)
            {
                Console.WriteLine("You Lost! Try again!");
                Console.WriteLine();
                Console.WriteLine($"The random word was: {randomWord.ToUpper()}");                
            }


            Console.Write("\nPress 'Enter' to exit the process...");
            Console.ReadKey();
        }

    }
}