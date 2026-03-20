namespace Algorithms.tbank_interview.Medium;

public static class BattleshipsinBoard
{
    private static int CountBattleships(char[][] board)
    {
        var count = 0;
        for (var i = 0; i < board.Length; i++)
        {
            for (var j = 0; j < board[i].Length; j++)
            {
                if (board[i][j] == 'X')
                {
                    count++;
                    if ((i > 0 && board[i - 1][j] == 'X') || (i < board.Length - i && board[i + 1][j] == 'X'))
                    {
                        DeleteBattleshipRow(board, i, j);
                    }
                    else
                    {
                        DeleteBattleshipRowCol(board, i, j);
                    }
                }
            }
        }

        return count;
    }

    private static void DeleteBattleshipRow(char[][] board, int row, int col)
    {
        board[row][col] = '.';
        var topIndex = row - 1;
        var bottomIndex = row + 1;
        while ((topIndex > 0 && board[topIndex][col] == 'X') || (bottomIndex < board.Length && board[bottomIndex][col] == 'X'))
        {
            if (bottomIndex < board.Length && board[bottomIndex][col] == 'X')
            {
                board[bottomIndex][col] = '.';
                bottomIndex++;
            }

            if (topIndex > 0 && board[topIndex][col] == 'X')
            {
                board[topIndex][col] = '.';
                topIndex--;
            }
        }
    }

    private static void DeleteBattleshipRowCol(char[][] board, int row, int col)
    {
        board[row][col] = '.';
        var left = col - 1;
        var right = col + 1;
        while ((left > 0 && board[row][left] == 'X') || (right < board[row].Length && board[row][right] == 'X'))
        {
            if (right < board[row].Length && board[row][right] == 'X')
            {
                board[row][right] = '.';
                right++;
            }

            if (left > 0 && board[row][left] == 'X')
            {
                board[row][left] = '.';
                left--;
            }
        }
    }

    private static int CountBattleships_gen(char[][] board)
    {
        var count = 0;
        for (var i = 0; i < board.Length; i++)
        {
            for (var j = 0; j < board[i].Length; j++)
            {
                if (board[i][j] == 'X')
                {
                    if (i > 0 && board[i - 1][j] == 'X')
                        continue;


                    if (j > 0 && board[i][j - 1] == 'X')
                        continue;

                    count++;
                }
            }
        }

        return count;
    }


    public static void Test()
    {
        var result = CountBattleships_gen([['X', '.', '.', 'X'], ['.', 'X', '.', 'X'], ['.', '.', '.', 'X']]);
        Console.WriteLine(result);
    }
}