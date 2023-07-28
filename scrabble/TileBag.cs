using System;
using System.Collections.Generic;
using System.Linq;

namespace ScrabbleGame
{
	public class TileBag
	{
		private readonly Dictionary<char, int> tileFrequencies;

		public TileBag()
		{
			tileFrequencies = new Dictionary<char, int>
			{
				{ 'A', 9 }, { 'B', 2 }, { 'C', 2 }, { 'D', 4 }, { 'E', 12 }, { 'F', 2 }, { 'G', 3 }, { 'H', 2 }, { 'I', 9 },
				{ 'J', 1 }, { 'K', 1 }, { 'L', 4 }, { 'M', 2 }, { 'N', 6 }, { 'O', 8 }, { 'P', 2 }, { 'Q', 1 }, { 'R', 6 },
				{ 'S', 4 }, { 'T', 6 }, { 'U', 4 }, { 'V', 2 }, { 'W', 2 }, { 'X', 1 }, { 'Y', 2 }, { 'Z', 1 }, { '_', 2 }
			};
		}

		public bool IsEmpty() => tileFrequencies.All(pair => pair.Value == 0);

		public Tile DrawTile()
		{
			var random = new Random();
			char randomTile = tileFrequencies.Keys.ElementAt(random.Next(tileFrequencies.Count));
			while (tileFrequencies[randomTile] == 0)
				randomTile = tileFrequencies.Keys.ElementAt(random.Next(tileFrequencies.Count));

			tileFrequencies[randomTile]--;
			return new Tile(randomTile, GetTileValue(randomTile));
		}

		private int GetTileValue(char letter)
		{
			// Implementasikan nilai tile berdasarkan aturan Scrabble
			// Misalnya: 'A', 'E', 'I', 'O', 'U', 'L', 'N', 'S', 'T' = 1 poin
			//          'D', 'G' = 2 poin, dan seterusnya
			// Gunakan peta (dictionary) untuk menetapkan nilai tile berdasarkan hurufnya
			// Contoh:
			Dictionary<char, int> letterValues = new Dictionary<char, int>
			{
				{ 'A', 1 }, { 'B', 3 }, { 'C', 3 }, { 'D', 1 }, { 'E', 1 }, { 'F', 3 }, { 'G', 1 }, { 'H', 1 }, { 'I', 1 },
				{ 'J', 1 }, { 'K', 1 }, { 'L', 1 }, { 'M', 1 }, { 'N', 1 }, /* dan seterusnya */
			};

			if (letterValues.ContainsKey(letter))
				return letterValues[letter];
			else
				return 0; // Jika huruf tidak memiliki nilai yang ditentukan, kembalikan 0
		}
	}
}
