namespace VisualCSharpHowToProgram.ChapterEight;

public class Game
{
    
}


public class Pen
{
    public bool PenDown { get; set; }

    public Pen()
    {
        PenDown = false;
    }
}

public class Turtle
{
    public int PosX { get; set; }
    public int PosY { get; set; }

    public Turtle()
    {
        PosX = 0;
        PosY = 0;
    }
}


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