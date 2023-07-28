using System;

namespace ScrabbleGame
{
    public class Board
    {
        public const int Size = 15;
        private Tile[,] tiles;

        public Board()
        {
            tiles = new Tile[Size, Size];
        }

        public void PlaceTile(int row, int col, Tile tile)
        {
            tiles[row, col] = tile;
        }

        public Tile GetTileAt(int row, int col)
        {
            return tiles[row, col];
        }

        public bool IsValidPlacement(int row, int col)
        {
            return row >= 0 && row < Size && col >= 0 && col < Size && tiles[row, col] == null;
        }

        public void Display()
        {
            // Implementasi logika untuk menampilkan papan permainan ke layar console
            // Tampilkan papan dalam bentuk matriks, berisi huruf dan nilai tile pada posisi yang tepat
        }
    }
}
