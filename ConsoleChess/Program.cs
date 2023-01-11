using ConsoleChess;

Console.WriteLine("Enter 1 for white, or 2 for black");
var colorSelection = Console.ReadLine();
if (colorSelection == "1")
{
    var player1 = new Player(Player.Colors.White);
    var player2 = new Player(Player.Colors.Black);
    var currentGame = new Game(player1, player2);
    currentGame.BeginGame();
}
else if(colorSelection == "2")
{
    var player1 = new Player(Player.Colors.Black);
    var player2 = new Player(Player.Colors.White);
    var currentGame = new Game(player2, player1);
    currentGame.BeginGame();
}
else
{
    Console.WriteLine("Please enter 1 for white, or 2 for black");
}

