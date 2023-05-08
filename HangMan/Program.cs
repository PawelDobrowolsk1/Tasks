using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            string[] listwords = new string[10];
            listwords[0] = "sheep";
            listwords[1] = "goat";
            listwords[2] = "computer";
            listwords[3] = "america";
            listwords[4] = "watermelon";
            listwords[5] = "icecream";
            listwords[6] = "jasmine";
            listwords[7] = "pineapple";
            listwords[8] = "orange";
            listwords[9] = "mango";

            Random random = new Random();

            var idx = random.Next(0, 9);

            string mysteryWord = listwords[idx];

            char[] guess = new char[mysteryWord.Length];

            for (int i = 0; i < mysteryWord.Length; i++)
            {
                guess[i] = '*';
            }

            Console.WriteLine("Pleas entry your guess");

            while (a)
            {
                var playerGuess = char.Parse(Console.ReadLine());

                for (int i = 0; i < mysteryWord.Length; i++)
                {
                    if (playerGuess == mysteryWord[i])
                    {
                        guess[i] = playerGuess;
                    }
                }
                Console.WriteLine(guess);
                if (new string(guess) == mysteryWord)
                {
                    a = false;
                }
            }

            Console.WriteLine("You got the word!");

        }
    }
}
