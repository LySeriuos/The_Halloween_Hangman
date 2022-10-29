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
            //char[] charArr = randomWord.ToCharArray(); // dividing word in chars and adding to array          

            //var good = charArr.ToString();
           // Console.Write(good);

            // char charTry = char.Parse(userInput);
            // char[] userChars = userInput.ToCharArray();
            // char[] charArrInput = userInput.ToCharArray();
           //bool validUserInput = randomWord.Contains(userInput); // validating user's input
          // bool validUserInput2 = randomWord.Contains(userInput);
                      
            int found;
            int totFinds = 0;
            int i;
            // 1. make and for loop which is exact length as the random word and print underscores
            // 2. this part of the code is getting the indexes of matching letter with userInput 
            // 3. later I need to change empty indexes to the letter it was matching
            do
            {
                Console.WriteLine("Guess the letter!"); // Asking for user's input
                string userInput = Console.ReadLine(); // reading user's input
                bool validUserInput = randomWord.Contains(userInput);

            if (userInput != "") // check if user input is not empty 
                {
                    for (i = 0; i < randomWord.Length; i++) // check thru the chosen word 
                    {
                        found = randomWord.IndexOf(userInput, i); //getting the indexes of the letters                          

                        if (found >= 0) // if index is gigher than 0 we can count how many times the same letter was found
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

                Console.WriteLine("{0}The search parameter '{1}' was found {2} times.",
                        Environment.NewLine, userInput, totFinds);

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
