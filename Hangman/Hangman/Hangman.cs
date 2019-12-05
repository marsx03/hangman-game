using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Hangman
    {
        public string word;
        public string emptyWord;
        public int wrongAttemptsLeft;
        public string[] bodyParts;

        public Hangman(string theme) //CONSTRUCTOR 
        {
            Random gen = new Random();

            if (theme.Equals("SAT Words")) {
                string[] SATList = { "Egregious", "Nascent", "Galvanizing", "Plethora", "Dominion" };
                this.word = SATList[gen.Next(0, 4)].ToUpper();
            }

            if (theme.Equals("Nature")) {
                string[] natureList = { "Lotus", "Eukaryotic", "Kudzu", "Metamorphisis", "Symbiosis" };
                this.word = natureList[gen.Next(0, 4)].ToUpper();
            }

            if (theme.Equals("Math")) {
                string[] mathList = { "Golden Ratio", "Euler", "Logarithim", "Theorem", "Pythagoreas" };
                this.word = mathList[gen.Next(0, 4)].ToUpper();
            }
            
            foreach(var letter in word)
            {
                if(!letter.Equals(" "))
                {
                    word.IndexOf(letter);
                }
            }
            this.wrongAttemptsLeft = 6; //one for each body part
            this.bodyParts = new string[] { "head", "body", "armL", "armR", "legL", "legR" };
        }

        public string Body() //RESPONSIBLE FOR IMAGE THAT APPEARS
        {

            return "";
        }

    }
}
