using System;
using System.Collections.Generic;
using System.Linq;
using ScrabbleGame;

namespace ScrabbleGame
{
	public class Scrabble
	{
		private List<Player> players;
		private readonly ScrabbleDictionary dictionary;
		private readonly Board board;
		private readonly Player currentPlayer;
		private int currentPlayerIndex;

		public Scrabble()
		{
			currentPlayer = new Player("Player 1");
			board = new Board(15);
			players = new List<Player>();
			scrabbleDictionary = new ScrabbleDictionary();
		}

		public void AddPlayer(string name)
		{
			Player player = new Player(name, dictionary);
			players.Add(player);
		}

		public void AddWordToDictionary(string word)
		{
			dictionary.AddWord(word);
		}
		private void AddWordToBoard(string word, int row, int col, bool isHorizontal)
		
		{
			int wordScore = 0;
			int WordMultiplayer = 1;
			
			for (int i = 0; i < word.Length; i++)
			
			{
				char latter = word[i];
				ScrabbleTile tile = board.GetTile(row, col);
				
				wordScore += tile.Letter.Score;
				
				if (tile.WordMultiplayer > 1)
				
				{
					WordMultiplayer *= tile.WordMultiplayer;
				}
				
				if (isHorizontal)
				
				{
					col++;
				}
				else
				
				{
					row++;
				}
				wordScore *= WordMultiplayer;
				currentPlayer.updateScore(wordScore);
			}
		}

		public void Play()
		{
			currentPlayerIndex = 0;
			currentPlayer = players[0];
			bool gameEnded = false;

			while (!gameEnded)
			{
				Console.Clear();
				board.DisplayBoard();

				Console.WriteLine($"{currentPlayer.Name}'s Turn");
				Console.WriteLine("1. Play a Word");
				Console.WriteLine("2. Exchange Tiles");
				Console.WriteLine("3. Pass");
				Console.WriteLine("4. Resign");
				// Print the current board and player's rack
				Console.WriteLine("\nCurrent Board:");
				board.PrintBoard();

				Player currentPlayer = players[currentPlayerIndex];
				Console.WriteLine($"\nCurrent player: {currentPlayer.Name}");
				board.DisplayBoard();
				Console.WriteLine("Your rack:");
				currentPlayer.DisplayRack();

				// Ask the player to enter a word
				Console.Write("\nEnter a word to play (or type 'exit' to end the game): ");
				string wordToPlay = Console.ReadLine().ToLower();

				if (wordToPlay == "exit")
				{
					Console.WriteLine("\nGame ended.");
					gameEnded = true;
				}
				else
				{
					if (dictionary.IsWordValid(wordToPlay))
					{
						// Ask for the row and column to place the word
						Console.Write("Enter the row (0-14): ");
						int row = int.Parse(Console.ReadLine());

						Console.Write("Enter the column (0-14): ");
						int col = int.Parse(Console.ReadLine());

						// Check if the word can be placed on the board
						if (board.IsValidPlacement(row, col, wordToPlay))
						{
							int score = currentPlayer.CalculateScore(wordToPlay);
							currentPlayer.AddScore(score);

							// Place the word on the board and update the rack
							board.PlaceWord(row, col, wordToPlay);
							currentPlayer.RemoveTilesFromRack(wordToPlay);

							// Switch to the next player
							currentPlayerIndex = (currentPlayerIndex + 1) % players.Count;
						}
						else
						{
							Console.WriteLine("Invalid placement. Try again.");
						}
					}
					else
					{
						Console.WriteLine("Invalid word. Try again.");
					}
				}
			}

			// Print final scores
			Console.WriteLine("\nFinal Scores:");
			foreach (var player in players)
			{
				Console.WriteLine($"{player.Name}: {player.Score}");
			}
		}
	}
}
