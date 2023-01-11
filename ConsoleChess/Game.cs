using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static ConsoleChess.Piece;

namespace ConsoleChess
{
    public class Game
    {

        public Dictionary<string, List<Piece?>> Board { get; set; }
        public List<Player> Players { get; set; }
        public Player ToMove { get; set; }
        public bool GameOn { get; set; }

        public Game(Player white, Player black)
        {
            Players = new List<Player>() { white, black };
            ToMove = white;
            GameOn = false;
            Board = new Dictionary<string, List<Piece?>>();

            Board.Add("a", new List<Piece?>(8));
            Board.Add("b", new List<Piece?>(8));
            Board.Add("c", new List<Piece?>(8));
            Board.Add("d", new List<Piece?>(8));
            Board.Add("e", new List<Piece?>(8));
            Board.Add("f", new List<Piece?>(8));
            Board.Add("g", new List<Piece?>(8));
            Board.Add("h", new List<Piece?>(8));

            foreach (var column in Board)
            {
                for (int i = 0; i < 8; i++)
                {
                    Piece? piece;

                    if (column.Key == "a")
                    {
                        if (i == 0)
                        {
                            piece = new Piece(white, PieceTypes.Rook);
                        }
                        else if (i == 1)
                        {
                            piece = new Piece(white, PieceTypes.Pawn);
                        }
                        else if (i == 6)
                        {
                            piece = new Piece(black, PieceTypes.Pawn);
                        }
                        else if (i == 7)
                        {
                            piece = new Piece(black, PieceTypes.Rook);
                        }
                        else
                        {
                            piece = null;
                        }
                        Board[column.Key].Add(piece);
                    }
                    else if(column.Key == "b")
                    {
                        if (i == 0)
                        {
                            piece = new Piece(white, PieceTypes.Knight);
                        }
                        else if (i == 1)
                        {
                            piece = new Piece(white, PieceTypes.Pawn);
                        }
                        else if (i == 6)
                        {
                            piece = new Piece(black, PieceTypes.Pawn);
                        }
                        else if (i == 7)
                        {
                            piece = new Piece(black, PieceTypes.Knight);
                        }
                        else
                        {
                            piece = null;
                        }
                        Board[column.Key].Add(piece);
                    }
                    else if (column.Key == "c")
                    {
                        if (i == 0)
                        {
                            piece = new Piece(white, PieceTypes.Bishop);
                        }
                        else if (i == 1)
                        {
                            piece = new Piece(white, PieceTypes.Pawn);
                        }
                        else if (i == 6)
                        {
                            piece = new Piece(black, PieceTypes.Pawn);
                        }
                        else if (i == 7)
                        {
                            piece = new Piece(black, PieceTypes.Bishop);
                        }
                        else
                        {
                            piece = null;
                        }
                        Board[column.Key].Add(piece);
                    }
                    else if (column.Key == "d")
                    {
                        if (i == 0)
                        {
                            piece = new Piece(white, PieceTypes.Queen);
                        }
                        else if (i == 1)
                        {
                            piece = new Piece(white, PieceTypes.Pawn);
                        }
                        else if (i == 6)
                        {
                            piece = new Piece(black, PieceTypes.Pawn);
                        }
                        else if (i == 7)
                        {
                            piece = new Piece(black, PieceTypes.Queen);
                        }
                        else
                        {
                            piece = null;
                        }
                        Board[column.Key].Add(piece);
                    }
                    else if (column.Key == "e")
                    {
                        if (i == 0)
                        {
                            piece = new Piece(white, PieceTypes.King);
                        }
                        else if (i == 1)
                        {
                            piece = new Piece(white, PieceTypes.Pawn);
                        }
                        else if (i == 6)
                        {
                            piece = new Piece(black, PieceTypes.Pawn);
                        }
                        else if (i == 7)
                        {
                            piece = new Piece(black, PieceTypes.King);
                        }
                        else
                        {
                            piece = null;
                        }
                        Board[column.Key].Add(piece);
                    }
                    else if (column.Key == "f")
                    {
                        if (i == 0)
                        {
                            piece = new Piece(white, PieceTypes.Bishop);
                        }
                        else if (i == 1)
                        {
                            piece = new Piece(white, PieceTypes.Pawn);
                        }
                        else if (i == 6)
                        {
                            piece = new Piece(black, PieceTypes.Pawn);
                        }
                        else if (i == 7)
                        {
                            piece = new Piece(black, PieceTypes.Bishop);
                        }
                        else
                        {
                            piece = null;
                        }
                        Board[column.Key].Add(piece);
                    }
                    else if (column.Key == "g")
                    {
                        if (i == 0)
                        {
                            piece = new Piece(white, PieceTypes.Knight);
                        }
                        else if (i == 1)
                        {
                            piece = new Piece(white, PieceTypes.Pawn);
                        }
                        else if (i == 6)
                        {
                            piece = new Piece(black, PieceTypes.Pawn);
                        }
                        else if (i == 7)
                        {
                            piece = new Piece(black, PieceTypes.Knight);
                        }
                        else
                        {
                            piece = null;
                        }
                        Board[column.Key].Add(piece);
                    }
                    else if (column.Key == "h")
                    {
                        if (i == 0)
                        {
                            piece = new Piece(white, PieceTypes.Rook);
                        }
                        else if (i == 1)
                        {
                            piece = new Piece(white, PieceTypes.Pawn);
                        }
                        else if (i == 6)
                        {
                            piece = new Piece(black, PieceTypes.Pawn);
                        }
                        else if (i == 7)
                        {
                            piece = new Piece(black, PieceTypes.Rook);
                        }
                        else
                        {
                            piece = null;
                        }
                        Board[column.Key].Add(piece);
                    }
                }
            }
        }

        public bool BeginGame()
        {
            this.GameOn = true;

            while (this.GameOn)
            {
                Console.WriteLine($"{this.ToMove.Color} to move");

                var move = Console.ReadLine()?.ToLower();

                if(move == "resign")
                {
                    this.GameOn = false;
                }
                else if (move != null)
                {
                    if (IsMoveInput(move))
                    {

                    }
                    else if (IsRevealInput(move))
                    {
                        RevealSquare(move);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid move or Ctrl+D + (square) to reveal a certain square");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid move or Ctrl+D + (square) to reveal a certain square");
                }
            }
            return true;
        }
        public void EndTurn()
        {
            if (this.ToMove.Color == Player.Colors.White)
            {
                this.ToMove = this.Players[1];
            }
            else
            {
                this.ToMove = this.Players[0];
            }
        }
        public bool IsRevealInput(string move)
        {
            Regex revealChecker = new(@"^\u0012[a-h][1-8]$");

            if (revealChecker.IsMatch(move))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsMoveInput(string move)
        {
            Regex pawnMoveChecker = new(@"^[a-h][1-8]$");
            Regex pieceMoveChecker = new(@"^[rnbqk][a-h][1-8]$");
            Regex takeChecker = new(@"^[rnbqka-h]x[a-h][1-8]$");

            if (pawnMoveChecker.IsMatch(move) || pieceMoveChecker.IsMatch(move) || takeChecker.IsMatch(move))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void RevealSquare(string move)
        {
            move = Regex.Replace(move, @"^\u0012", "");
            var file = move[0].ToString();
            var rank = move[1].ToString();
            var piece = this.Board[file][Int32.Parse(rank) - 1];

            if (piece != null)
            {
                Console.WriteLine($"There is a {piece.Player.Color} {piece.PieceType} on {move}");
            }
            else
            {
                Console.WriteLine($"{move} is empty");
            }
            this.EndTurn();
        }
        public bool HasPiece(string move)
        {
            
        }
        public bool ValidMove(string move)
        { 
                // Just gotta get the piece type, where it is, and where it wants to move
                // DOESN'T need to be more complicated than that
        }
        public void MovePiece(string move)
        {
               
        }
    }
}
