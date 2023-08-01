using System.Collections.Generic;
using ScrabbleGame;

namespace ScrabbleGame
{
	public class Player
	{
		public string Name { get; private set; }
		private List<ScrabbleTile> rack;
		public int Score { get; private set; }
		private ScrabbleDictionary dictionary;

		public Player(string name, ScrabbleDictionary dictionary)
		{
			Name = name;
			rack = new List<ScrabbleTile>();
			this.dictionary = dictionary;
			Score = 0;
		}
		
		public void FillRack()
		{
			while (rack.Count < 7)
			{
				// Get a random tile from the Scrabble bag and add it to the player's rack
				ScrabbleTile tile = ScrabbleBag.GetRandomTile(); // Assuming you have defined ScrabbleBag class with GetRandomTile method
				rack.Add(tile);
			}
		}
		
		 public void DisplayRack()
        {
            Console.WriteLine($"Rack for {Name}:");
            for (int i = 0; i < rack.Count; i++)
            {
                ScrabbleTile tile = rack[i];
                Console.WriteLine($"[{i + 1}] {tile.Letter} ({tile.Score})");
            }
        }

		public void AddTileToRack(ScrabbleTile tile)
		{
			rack.Add(tile);
		}

		public void PrintRack()
		{
			foreach (var tile in rack)
			{
				Console.Write($"{tile.Letter}({tile.Score}) ");
			}
			Console.WriteLine();
		}

		public void RemoveTilesFromRack(string word)
		{
			foreach (char letter in word)
			{
				int index = rack.FindIndex(tile => tile.Letter == letter);
				if (index != -1)
				{
					rack.RemoveAt(index);
				}
			}
		}
		
		public void PlayWord(string word, int row, int col, bool isHorizontal)
		{
			int score = CalculateScore(word); // Gunakan CalculateScore untuk menghitung skor

			if (board.PlaceWord(word, row, col, isHorizontal, this))
			{
				Score += score;
				RefillRack();
			}
		}

		public int CalculateScore(string word)
		{
			int score = 0;
			int WordMultiplayer = 1;
			foreach (char letter in word)
			{
				score += scrabbleDictionary.GetLetterScore(letter) * tile.Score;
				wordMultiplier *= tile.WordMultiplier;
			}
			return score * wordMultiplier;
		}

		public void AddScore(int score)
		{
			Score += score;
		}
	}
}
