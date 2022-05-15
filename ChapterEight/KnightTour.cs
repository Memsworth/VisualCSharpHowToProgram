namespace VisualCSharpHowToProgram.ChapterEight;

public class KnightTour
{

    private static readonly Random Rand = new Random();
    
    public static void StartProgram()
    {
        var horizontal = new[] {2, 1, -1, -2, -2, -1, 1, 2};
        var vertical = new[] { -1, -2, -2, -1, 1, 2, 2, 1 };
        var chessBoard = new int[8,8];
        var currentRow = Rand.Next(8);
        var currentColumn = Rand.Next(8);
        var successMoveCount = 0;
        var counter = 0;

        while (counter<5000)
        {
            Console.WriteLine($"move count: {counter+1}");
            Console.WriteLine($"Knight at {currentRow} {currentColumn}");
            var moveNumber = Rand.Next(8);
            var row = currentRow + vertical[moveNumber];
            var col = currentColumn + horizontal[moveNumber];
                
            if (row is > 7 or < 0)
            {
                Console.WriteLine($"Out of bound at row: {row} col: {col}");
                continue;
            }

            if (col is > 7 or < 0)
            {
                Console.WriteLine($"Out of bound at row: {row} col: {col}");
                continue;
            }

            if (chessBoard[row, col] == 1)
            {
                Console.WriteLine($"Knight already went at {row} {col}. Skip");
                counter++;
                continue;
            }
            
            else
            {
                currentRow += vertical[moveNumber];
                currentColumn += horizontal[moveNumber];
                Console.WriteLine($"Knight moving to {currentRow} {currentColumn}");
                chessBoard[currentRow, currentColumn] = 1;
                successMoveCount++;
            }



            var displayInput = 2;
            switch (displayInput)
            {
                case 1:
                    DisplayBoard(chessBoard);
                    break;
                case 2:
                    Console.WriteLine("Knight will move again");
                    break;
                default:
                    Console.WriteLine("Wrong command");
                    break;
            }

            counter++;
        }

        DisplayBoard(chessBoard);
        Console.WriteLine($"Successful moves {successMoveCount}");
    }

    private static void DisplayBoard(int[,] chessBoard)
    {
        for (int i = 0; i < chessBoard.GetLength(0); i++)
        {
            for (int j = 0; j < chessBoard.GetLength(1); j++)
            {
                Console.Write($"{chessBoard[i,j]} ");
            }

            Console.WriteLine();
        }
    }
}