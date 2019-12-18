using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanDriver
{
    class Driver
    {
        public static void Main()
        {
            Console.Out.WriteLine("Welcome to the the C#102 Gallows... our instructors are feeling kind today. \nTheir deal is this: guess the secret word and you'll be spared in their reviews... \n\nMay the odds be ever in your favor!");

           Hangman currentGame = new Hangman();
           while(currentGame.getWrongAns() != 0)
            {
                string status = currentGame.getHidden() + "\n \nAttempts Left: " + currentGame.getWrongAns()+
                    "\nBad Letters: "+currentGame.getWrongGuesses();

                Console.Out.WriteLine(status);
                Console.Out.WriteLine("Input your Guess: ");
                string guess = Console.ReadLine().ToLower();

                currentGame.ContainsLetter(guess);


                
                
            }
            
        }
    }
}
