namespace The_Halloween_Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); // activating random object generator
            var words = new List<string>() { "money", "danger", "aloof", "scheme", "jazz", "volume", "lady", "sector", "guitar",
            "death", "winner", "ladder", "cousin", "driver", "farmer", "engine", "worker", "aspect", "memory", "cookie", "cancer", "income",
            "agency", "method", "wedding", "payment", "message", "clothes", "science", "queen"};
            int wordsIndex = random.Next(words.Count); // picking random index in the list
            string randomWord = words[wordsIndex]; // getting the value of the index
            var randomWordToCharList = randomWord.ToList<char>(); // creating a char list to randomWord
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
                    if (listOfChars.Count < randomWordLength) // checking if the list has less characters than randomWord length. If the list has equal it doesn't add more to the list,
                                                              // if it less than randomWord length then it keeps adding untill it get equal number
                        listOfChars.Add('_');
                    Console.Write($"{listOfChars[i]}"); // printing out underscores for every letter in the word
                }

                Console.WriteLine("\n\n\r\nGuess the letter!"); // Asking for user's input
                string userInput = Console.ReadLine().ToLower(); // reading user's input

                if (userInput != "") // check if user input is not empty 
                {
                    char userChar = userInput[0]; // adding the value for the userChar 
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
                    continue;
                }
                // checking if listOfGoodLettersInChar is equal to randomWordToCharList
                bool isEqual = randomWordToCharList.All(listOfGoodLettersInChar.Contains) && listOfGoodLettersInChar.All(randomWordToCharList.Contains);
                if (isEqual == true)
                {
                    Console.WriteLine($"You won! The random word is {randomWord.ToUpper()}"); // printing out message
                    return; // jumping out the code
                }


                var listOfBadLettersInChar = listOfAllInputChars.Except(listOfGoodLettersInChar).ToList(); // comparing two lists and creating new list
                                                                                                           // with letters wich doesn't match
                Console.WriteLine("Your's guessed wrong letters: "); // printing out wrong letters
                foreach (char badLettersChar in listOfBadLettersInChar)
                {
                    Console.Write(badLettersChar + ","); // printing list with ',' in between them
                }
                Console.WriteLine(); // empty line for extra empty row
            } while (tries <= 6);

            Console.WriteLine("You Lost! Try again!");
            Console.WriteLine();
            Console.WriteLine($"The random word was: {randomWord.ToUpper()}");
        }
    }
}