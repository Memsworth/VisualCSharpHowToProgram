
namespace VisualCSharpHowToProgram.ChapterTen;


public class TicTacToe
{
    public static void RunProgram()
    {
        var board = new TicTacBoard();
        board.DisplayBoard();
    }

    public static bool PlayGame(TicTacBoard board)
    {
        int rInput;
        int cInput;

        Console.WriteLine("Enter destination (1,2,3)");
        int.TryParse(Console.ReadLine(), out rInput);
        int.TryParse(Console.ReadLine(), out cInput);

        if (!ValidBoard(board, rInput, cInput))
        {
            
        }
    }

    private static bool ValidBoard(TicTacBoard board, int rInput, int cInput)
    {
        var valid = false;

        if (rInput > 3|| cInput > 3 && rInput<1 || cInput < 1)
        {
            valid = false;
        }
        else if (expr)
        {
            
        }
        {
            
        }
    }

    public static bool IsGameWon(TicTacToe board)
    {
        
    }
        
    public bool VerticalCondition(TicTacToe board)
    {
        
    }

    public bool HorizontalCondition(TicTacToe board)
    {
        
    }

    public bool CrossCondition(TicTacToe board)
    {
            
    }
}



public class TicTacBoard
{
    public int[,] GameBoard { get; private set; }
    public TicTacBoard()
    {
        GameBoard = new int[3, 3];
    }
    public void DisplayBoard()
    {
        Console.WriteLine("\tTic Tac Toe\n");

        Console.WriteLine("Player 1 (1)  -  Player 2 (2)\n");


        Console.WriteLine("     |     |     ");
        Console.WriteLine($"  {GameBoard[0,0]}  |  {GameBoard[0,1]}  |  {GameBoard[0,2]} ");

        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");

        Console.WriteLine($" {GameBoard[1,0]}   |  {GameBoard[1,1]}  |  {GameBoard[1,2]} ");

        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");

        Console.WriteLine($" {GameBoard[2,0]}   |  {GameBoard[2,1]}  |  {GameBoard[2,2]} ");

        Console.WriteLine("     |     |     \n");
    }
}