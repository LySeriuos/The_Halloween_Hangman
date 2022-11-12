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
            char[] randomWordInChar = new char[randomWord.Length]; // creating char array for randomWord
            randomWordInChar = randomWord.ToCharArray(); // converting to char array
            int randomWordsLength = randomWord.Length; // getting the length of the randomWord
            string[] underscores = new string[randomWordsLength]; // creating new array for underscores
            var listOfUnderscoresString = new List<string>(); //creating new list for underscores

            int i;
            for (i = 0; i < underscores.Length; i++) // for every letter adding one underscore
            {
                listOfUnderscoresString.Add("_");
            }

            string[] underscoreChar = listOfUnderscoresString.ToArray(); // converting list to array
            for (i = 0; i < underscoreChar.Length; i++) // looping thru every undescore in the list to get indexnumber
            {
                Console.Write(underscoreChar[i]);
            }

            char userInput; //creating char for the User Input
            Console.WriteLine("\n\n\r\nGuess the letter!");
            userInput = Convert.ToChar(Console.ReadLine());
            
           





















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
