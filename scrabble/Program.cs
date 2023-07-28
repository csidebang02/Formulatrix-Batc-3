using System;
using System.Collections.Generic;

namespace ScrabbleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> playerNames = new List<string> { "Player 1", "Player 2" };
            string dictionaryFilePath = "words.txt";

            ScrabbleGame scrabbleGame = new ScrabbleGame(playerNames, dictionaryFilePath);
            scrabbleGame.Play();
        }
    }
}
