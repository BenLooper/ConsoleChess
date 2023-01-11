using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess
{
    public class Piece
    {
        public enum PieceTypes
        {
            Pawn,
            Knight,
            Bishop,
            Rook,
            Queen,
            King
        }

        public PieceTypes PieceType { get; set;}

        public Player Player { get; set; }

        public Piece(Player player, PieceTypes type)
        {
            Player = player;
            PieceType = type;   
        }
    }
}
