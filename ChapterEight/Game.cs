namespace VisualCSharpHowToProgram.ChapterEight;

public class Game
{
    public void RunGame()
    {
        var gameBoard = new Board();
        var turtle = new Turtle();
        var gameCommands = (GameCommands)Input.GetPositiveInteger("Enter a command");

        switch (gameCommands)
        {
            case GameCommands.PenDown:
                turtle.IsPenDown = true;
                break;
            case GameCommands.PenUp:
                turtle.IsPenDown = false;
                break;
            case GameCommands.TurnNorth:
                turtle.Direction = TurtleDirection.Up;
                break;
            case GameCommands.TurnEast:
                turtle.Direction = TurtleDirection.Right;
                break;
            case GameCommands.TurnSouth:
                turtle.Direction = TurtleDirection.Down;
                break;
            case GameCommands.TurnWest:
                turtle.Direction = TurtleDirection.Left;
                break;
            
        }
    }
}


public enum GameCommands
{
    PenUp = 1,
    PenDown = 2,
    TurnNorth = 3,
    TurnEast = 4,
    TurnSouth = 5,
    TurnWest = 6,
    Move = 7,
    DisplayMap = 8,
    EndGame = 9
};

public class Turtle
{
    public int PosX { get; set; }
    public int PosY { get; set; }
    
    public bool IsPenDown { get; set; }

    public TurtleDirection Direction { get; set; }

    public Turtle()
    {
        PosX = 0;
        PosY = 0;
        Direction = TurtleDirection.Right;
        IsPenDown = false;
    }
    
    
}



public enum TurtleDirection
{
    Left,
    Up,
    Right,
    Down
};

public class Board
{
    public int[,] GameBoard { get; set; }

    public Board()
    {
        GameBoard = new int[20, 20];
    }

    private void DisplayBoard()
    {
        for (int i = 0; i < GameBoard.GetLength(0); i++)
        {
            for (int j = 0; j < GameBoard.GetLength(1); j++)
            {
                switch (GameBoard[i,j])
                {
                    case 0:
                        Console.Write(" ");
                        break;
                    case 1:
                        Console.Write("*");
                        break;
                }
            }
            
            Console.WriteLine();
        }
    }
}

public static class GameUi
{
    public static void ShowCommands()
    {
        Console.WriteLine("1, Pen UP");
        Console.WriteLine("2, Pen DOWN");
        Console.WriteLine("3, Turn Right");
        Console.WriteLine("4, Turns Left");
        Console.WriteLine("5,X  Move X positions in your directions");
        Console.WriteLine("6, Display Board");
        Console.WriteLine("9, Exit");
    }
}