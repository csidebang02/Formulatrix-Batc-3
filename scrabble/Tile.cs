using System;

namespace ScrabbleGame
{
    public enum TileType
    {
        Normal,
        DoubleLetter,
        TripleLetter,
        DoubleWord,
        TripleWord
    }

    public class Tile
    {
        public char Letter { get; }
        public int Value { get; }
        public TileType TileType { get; }

        public Tile(char letter, int value, TileType tileType = TileType.Normal)
        {
            Letter = letter;
            Value = value;
            TileType = tileType;
        }
    }
}
