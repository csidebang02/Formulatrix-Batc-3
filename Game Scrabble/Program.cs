using System;

namespace ScrabbleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrabble scrabbleGame = new Scrabble();

            // Menambahkan kata-kata ke kamus Scrabble
            scrabbleGame.AddWordToDictionary("cat");
            scrabbleGame.AddWordToDictionary("dog");
            scrabbleGame.AddWordToDictionary("rat");
            scrabbleGame.AddWordToDictionary("bat");

            // Menambahkan pemain
            Console.Write("Enter Player 1 Name: ");
            string player1Name = Console.ReadLine();
            scrabbleGame.AddPlayer(player1Name);

            Console.Write("Enter Player 2 Name: ");
            string player2Name = Console.ReadLine();
            scrabbleGame.AddPlayer(player2Name);

            // Memulai permainan
            scrabbleGame.Play();
        }
    }
}
