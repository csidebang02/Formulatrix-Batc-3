using System;
using System.Collections.Generic;

namespace ScrabbleGame
{
	public class ScrabbleDictionary
	{
		HashSet<string> wordSet;

		public ScrabbleDictionary()
		{
			wordSet = new HashSet<string>();
		}

		public void LoadDictionary(string filePath)
		{
			// Implementasi logika untuk memuat kamus kata dari file teks
			// Baca file teks dan tambahkan setiap kata ke dalam HashSet wordSet
			// Contoh implementasi:
			// string[] words = File.ReadAllLines(filePath);
			// wordSet = new HashSet<string>(words);
			// Implementasi kode di sini
		}
		public static int GetLetterScore(char letter)
		{
			switch (char.ToUpper(letter))
			{
				case 'A':
				case 'E':
				case 'I':
				case 'O':
				case 'U':
				case 'L':
				case 'N':
				case 'R':
				case 'S':
				case 'T':
					return 1;
				case 'D':
				case 'G':
					return 2;
				case 'B':
				case 'C':
				case 'M':
				case 'P':
					return 3;
				case 'F':
				case 'H':
				case 'V':
				case 'W':
				case 'Y':
					return 4;
				case 'K':
					return 5;
				case 'J':
				case 'X':
					return 8;
				case 'Q':
				case 'Z':
					return 10;
				default:
					return 0; // Jika karakter bukan huruf vokal atau konsonan, maka skornya 0
			}
		}

		public bool IsValidWord(string word)
		{
			return wordSet.Contains(word.ToUpper());
		}
	}
}
