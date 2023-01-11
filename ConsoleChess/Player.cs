using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess
{
    public class Player
    {
        public enum Colors
        {
            White,
            Black
        }
        public Colors Color { get; set;}

        public Player(Colors color)
        {
            Color = color;
        }
    }
}
