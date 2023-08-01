using System;

namespace ScrabbleGame
{
    public class Board
    {
        private char[,] board;

        public Board(int size)
        {
            board = new char[size, size];
        }

        public void PlaceWord(int row, int col, string word)
        {
            int wordIndex = 0;
            foreach (char letter in word)
            {
                board[row, col + wordIndex] = letter;
                wordIndex++;
            }
        }

        public bool IsValidPlacement(int row, int col, string word)
        {
            int wordIndex = 0;
            foreach (char letter in word)
            {
                if (row < 0 || row >= board.GetLength(0) || col + wordIndex < 0 || col + wordIndex >= board.GetLength(1))
                    return false;

                if (board[row, col + wordIndex] != '\0')
                    return false;

                wordIndex++;
            }

            return true;
        }

        public void PrintBoard()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    char letter = board[i, j];
                    Console.Write(letter == '\0' ? "_ " : $"{letter} ");
                }
                Console.WriteLine();
            }
        }
    }
}
