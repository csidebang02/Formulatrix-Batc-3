using System;
using System.Collections.Generic;

namespace ScrabbleGame
{
    public class ScrabbleGame
    {
        private List<IPlayer> players;
        private TileBag tileBag;
        private Board board;
        private ScrabbleDictionary scrabbleDictionary;

        public ScrabbleGame(List<string> playerNames, string dictionaryFilePath)
        {
            players = new List<IPlayer>();
            foreach (var name in playerNames)
            {
                players.Add(new Player(name));
            }

            tileBag = new TileBag();
            board = new Board();
            scrabbleDictionary = new ScrabbleDictionary();
            scrabbleDictionary.LoadDictionary(dictionaryFilePath);
        }

        public void Play()
        {
            // Implementasi logika utama untuk permainan Scrabble di sini
            // Game dimulai dengan pembagian tile ke masing-masing pemain
            // Setiap pemain menarik tile dari tile bag sampai masing-masing memiliki 7 tile di rack
            // Lakukan loop giliran pemain sampai ada pemain yang menang atau tile bag kosong dan semua pemain tidak bisa lagi membentuk kata yang valid
            // Saat giliran, tampilkan papan dan tile rack pemain, lalu pemain diminta untuk menempatkan kata pada papan
            // Pastikan kata yang dimainkan pemain valid (terdapat di kamus) dan dapat dibentuk dari tile pada rack pemain
            // Setelah kata berhasil dimainkan, hitung skor dari kata tersebut dan tambahkan ke skor pemain
            // Ulangi proses hingga ada pemain yang menang atau tidak ada pemain yang bisa bermain
            // Tampilkan skor akhir setiap pemain dan umumkan pemenangnya

            // Contoh implementasi:
            while (true)
            {
                foreach (var player in players)
                {
                    if (!player.HasTiles())
                    {
                        player.DrawTiles(tileBag);
                    }

                    Console.WriteLine($"Current Player: {player.Name}");
                    board.Display();
                    player.DisplayRack();

                    Console.Write("Enter word to play (or 'QUIT' to end the game): ");
                    string input = Console.ReadLine().ToUpper();

                    if (input == "QUIT")
                    {
                        Console.WriteLine("Thanks for playing!");
                        return;
                    }

                    if (!scrabbleDictionary.IsValidWord(input))
                    {
                        Console.WriteLine("Invalid word!");
                        continue;
                    }

                    char[] playerRack = player.Rack.Select(tile => tile.Letter).ToArray();
                    if (!player.IsWordInRack(input, playerRack))
                    {
                        Console.WriteLine("You don't have the necessary tiles!");
                        continue;
                    }

                    int row, col;
                    Console.Write("Enter row (0-14): ");
                    int.TryParse(Console.ReadLine(), out row);
                    Console.Write("Enter column (0-14): ");
                    int.TryParse(Console.ReadLine(), out col);

                    if (!board.IsValidPlacement(row, col))
                    {
                        Console.WriteLine("Invalid placement!");
                        continue;
                    }

                    // Implementasi logika untuk meletakkan kata pada papan
                    // Gunakan method PlaceTile pada board untuk meletakkan setiap huruf kata pada papan
                    // Lakukan perhitungan skor menggunakan method CalculateScore pada player dan UpdateScore untuk menambahkan skor pemain
                }
            }
        }
    }
}