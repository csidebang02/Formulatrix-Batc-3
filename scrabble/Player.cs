using System;
using System.Collections.Generic;
using System.Linq;

namespace ScrabbleGame
{
    public interface IPlayer
    {
        string Name { get; }
        List<Tile> Rack { get; }
        int Score { get; }

        void DrawTiles(TileBag tileBag, int count = 7);
        void DisplayRack();
        bool IsWordInRack(string word, char[] playerRack);
        int CalculateScore(string word);
        bool HasTiles();
        void UpdateScore(int score);
    }

    public class Player : IPlayer
    {
        public string Name { get; }
        public List<Tile> Rack { get; private set; }
        public int Score { get; private set; }

        public Player(string name)
        {
            Name = name;
            Rack = new List<Tile>();
            Score = 0;
        }

        public void DrawTiles(TileBag tileBag, int count = 7)
        {
            for (int i = 0; i < count; i++)
            {
                if (!tileBag.IsEmpty())
                {
                    Rack.Add(tileBag.DrawTile());
                }
            }
        }

        public void DisplayRack()
        {
            Console.WriteLine($"Rack for {Name}:");
            foreach (var tile in Rack)
            {
                Console.Write($"{tile.Letter} ");
            }
            Console.WriteLine();
        }

        public bool IsWordInRack(string word, char[] rack)
        {
            if (word.Length > rack.Length)
            {
                return false;
            }

            char[] rackCopy = (char[])rack.Clone();

            foreach (char c in word)
            {
                bool found = false;
                for (int i = 0; i < rackCopy.Length; i++)
                {
                    if (rackCopy[i] == c)
                    {
                        rackCopy[i] = '\0'; // Mark character as used in rack
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    return false; // No matching character found in the rack
                }
            }

            return true;
        }

        public int CalculateScore(string word)
        {
            int score = 0;
            foreach (char c in word)
            {
                score += ScrabbleDictionary.GetLetterScore(c);
            }
            return score;
        }

        public bool HasTiles()
        {
            return Rack.Count > 0;
        }

        public void UpdateScore(int score)
        {
            Score += score;
        }
    }
}
