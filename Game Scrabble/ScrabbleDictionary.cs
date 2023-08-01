using System.Collections.Generic;

namespace ScrabbleGame
{
	public class ScrabbleDictionary
	{
		private HashSet<string> words;
		public ScrabbleDictionary()
		{
		 words = new HashSet<string>();
			// Isi dengan kata-kata yang valid di dalam kamus Scrabble
			// Contoh:
			words.Add("apple");
			words.Add("banana");
			words.Add("orange");
			// ...
		}
		public bool IsWordValid(string word)
		
		{
			return words.Contains(word.ToLower());
		}
	}
}
