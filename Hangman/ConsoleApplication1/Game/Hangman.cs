using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanDriver
{
    class Hangman
    {
        private string[] words = { "function", "instantiate", "method", "object", "parameter", "variable", "loop", "null", "syntax", "exception", "csharp", "matt", "steven","jordan"}; //to change into import from txt file of ridiculous words,,, perhaps???
        private string secretWord;
        private string hiddenWord;
        private List<string> letterBank = new List<string>();
        private int wrongAns;
        private List<string> wrongGuesses = new List<string>();

        public Hangman(){
            Random gen = new Random();
            int wordChoice = gen.Next(0, 3);

            this.secretWord = words[wordChoice];

            for(int i=0; i<this.secretWord.Length; i++){
                this.hiddenWord += "?"; 
            }

            for(int j=1; j<=26; j++)
            {
                char alpha = Convert.ToChar(j + 94);
                letterBank.Add(Convert.ToString(alpha));
            }

            this.wrongAns = 6;
        }

        public int getWrongAns() => wrongAns;

        public string getHidden() => hiddenWord;

        public List<string> getWrongGuesses() => wrongGuesses;

        public string ContainsLetter (string guess){

            if (guess.Length > 1)
            {
                if (secretWord.Equals(guess))
                    return "You guessed the word!";
                else {
                    wrongAns--;
                    return "That is not the word.";
                }
            }
                
            else if (!secretWord.Contains(guess))
            {
                wrongAns--;
                wrongGuesses.Add(guess);
                letterBank.Remove(guess);
                return "\"" + guess + "\" is not in this word.";
            }

            while(secretWord.Contains(guess))
            {
                
            }
            
            return hiddenWord;
            
        }
        
        
    }
}
