
namespace VisualCSharpHowToProgram.ChapterEight;

public class Game
{
    public void RunGame()
    {
        var gameBoard = new Board();
        var turtle = new Turtle();
        GameUi.ShowCommands();
        var gameCommands = (GameCommands)Input.GetPositiveInteger("Enter a command");
        do
        {
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
                case GameCommands.Move:
                    turtle.Move(gameBoard);
                    break;
                case GameCommands.DisplayMap:
                    gameBoard.DisplayBoard();
                    break;
                case GameCommands.EndGame:
                    Console.WriteLine("Thank you for playing");
                    break;
                default:
                    Console.WriteLine("Wrong command"); 
                    break;
            }
            GameUi.ShowCommands();
            gameCommands = (GameCommands)Input.GetPositiveInteger("Enter a command");
        } while (gameCommands != GameCommands.EndGame);
        
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


    public void Move(Board gameBoard)
    {
        Console.WriteLine($"current location: {PosX}{PosY}");
        Console.WriteLine($"Is pen down: {IsPenDown}");
        Console.WriteLine($"direction: {Direction}");
        var moveSpace = Input.GetPositiveInteger("How many spaces to move");
        switch (Direction)
        {
            case TurtleDirection.Up:
                //PosX - moveSpace < 0
                //cont
                if (PosX - moveSpace < 0)
                {
                    Console.WriteLine("Out of bound. ReEnter");
                    return;
                }
                if (IsPenDown)
                {
                    for (int i = PosX; i < PosX-moveSpace; i--)
                    {
                        gameBoard.GameBoard[i, PosY] = 1;
                    }
                    PosX -= moveSpace;
                }
                else
                {
                    PosX -= moveSpace;
                }
                break;
            case TurtleDirection.Right:
                //PosY + moveSpace > game-board(1) length
                //cont
                if (PosY + moveSpace > gameBoard.GameBoard.GetLength(1))
                {
                    Console.WriteLine("Out of bound. ReEnter");
                    return;
                }
                if (IsPenDown)
                {
                    for (int i = PosY; i < PosY+moveSpace -1; i++)
                    {
                        gameBoard.GameBoard[PosX, i] = 1;
                    }
                    PosY += moveSpace -1;
                }
                else
                {
                    PosY += moveSpace -1;
                }
                break;
            case TurtleDirection.Down:
                //PosX + moveSpace > game-board(0) length
                //cont
                if (PosX + moveSpace > gameBoard.GameBoard.GetLength(0))
                {
                    Console.WriteLine("Out of bound. ReEnter");
                    return;
                }
                if (IsPenDown)
                {
                    for (int i = PosX; i < PosX+moveSpace -1; i++)
                    {
                        gameBoard.GameBoard[i, PosY] = 1;
                    }
                    PosX += moveSpace-1;
                }
                else
                {
                    PosX += moveSpace-1;
                }
                break;
            case TurtleDirection.Left:
                //PosY - moveSpace < 0
                //cont
                if (PosY - moveSpace < 0)
                {
                    Console.WriteLine("Out of bound. ReEnter");
                    return;
                }
                if (IsPenDown)
                {
                    for (int i = PosY; i < PosY-moveSpace; i--)
                    {
                        gameBoard.GameBoard[PosX, i] = 1;
                    }
                    PosY -= moveSpace;
                }
                else
                {
                    PosY -= moveSpace;
                }
                
                break;
        }
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

    internal void DisplayBoard()
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
        Console.WriteLine("3, Turtle Direction Up");
        Console.WriteLine("4, Turtle Direction Right");
        Console.WriteLine("5, Turtle Direction Down");
        Console.WriteLine("6, Turtle Direction Left");
        Console.WriteLine("7, Move");
        Console.WriteLine("8  Display Board");
        Console.WriteLine("9, Exit");
    }
}