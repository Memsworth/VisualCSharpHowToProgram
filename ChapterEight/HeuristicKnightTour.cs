namespace VisualCSharpHowToProgram.ChapterEight;

public class HeuristicKnightTour
{
    private static readonly Random Rand = new Random();

    public static void StartProgram()
    {
        var horizontal = new[] {2, 1, -1, -2, -2, -1, 1, 2};
        var vertical = new[] { -1, -2, -2, -1, 1, 2, 2, 1 };
        var chessBoard = new int[8,8];
        var heuristic = new int[,]
        {
            { 2, 3, 4, 4, 4, 4, 3, 2 }, { 3, 4, 6, 6, 6, 6, 4, 3 },
            { 4, 6, 8, 8, 8, 8, 6, 4 }, { 4, 6, 8, 8, 8, 8, 6, 4 },
            { 4, 6, 8, 8, 8, 8, 6, 4 }, { 4, 6, 8, 8, 8, 8, 6, 4 },
            { 3, 4, 6, 6, 6, 6, 4, 3 }, { 2, 3, 4, 4, 4, 4, 3, 2 }
        };
        var currentRow = Rand.Next(8);
        var currentColumn = Rand.Next(8);
        var successMoveCount = 0;
        var counter = 0;

        while (counter<5000)
        {
            Console.WriteLine($"move count: {counter+1}");
            Console.WriteLine($"Knight at {currentRow} {currentColumn}");
            var moveNumber = 0;
            var nodeWeight = 10;
            bool allowPassage = false;
            
            for (int i = 0; i < 8; i++)
            {
                var row = currentRow + vertical[i];
                var col = currentColumn + horizontal[i];
                
                if (row is > 7 or < 0)
                {
                    continue;
                }

                if (col is > 7 or < 0)
                {
                    continue;
                }
                
                if (chessBoard[row, col] == 1)
                {
                    counter++;
                    continue;
                }

                if (heuristic[row, col] >= nodeWeight) continue;
                nodeWeight = heuristic[row, col];
                moveNumber = i;
                allowPassage = true;
            }


            if (allowPassage)
            {
                currentRow += vertical[moveNumber];
                currentColumn += horizontal[moveNumber];
                Console.WriteLine($"Knight moving to {currentRow} {currentColumn}");
                chessBoard[currentRow, currentColumn] = 1;
                successMoveCount++;
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