using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanDriver
{
    class Hangman
    {
        private string[] words = {"lemon","peach","cherry" }; //to change into import from txt file of ridiculous words
        private string secretWord;
        private string hiddenWord;
        private List<string> letterBank;
        private string man;

        public Hangman(){
            Random gen = new Random();
            int wordChoice = gen.Next(0, 3);

            this.secretWord = words[wordChoice];

            for(int i; i<this.secretWord.Length; i++){
                this.hiddenWord += "-";
            }

            for(int j=1; j<=26; j++)
            {
                char alpha = Convert.ToChar(j + 94);
                letterBank.Add(Convert.ToString(alpha));
            }

            string man = "";
        }

        public bool IsLetter(string guess){

            return false; //test
        }

        public bool IsWord(string guess) {

            return false; //test
        }

        public string toString(){
            return "bruh" //test
        }
    }
}
