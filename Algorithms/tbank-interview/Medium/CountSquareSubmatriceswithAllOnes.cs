namespace Algorithms.tbank_interview.Medium;

public static class CountSquareSubmatriceswithAllOnes
{
    private static int CountSquares(int[][] matrix)
    {
        var rows = matrix.Length;
        var cols = matrix[0].Length;

        // Memoization table: -1 means not computed yet
        var memo = new int[rows][];
        for (var i = 0; i < rows; i++)
        {
            memo[i] = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                memo[i][j] = -1;
            }
        }

        var total = 0;
        for (var r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                total += Dfs(r, c);
            }
        }

        return total;

        // DFS function
        int Dfs(int r, int c)
        {
            if (r == rows || c == cols || matrix[r][c] == 0)
                return 0;

            if (memo[r][c] != -1)
                return memo[r][c];

            memo[r][c] = 1 + Math.Min(Dfs(r + 1, c),
                Math.Min(Dfs(r, c + 1),
                    Dfs(r + 1, c + 1)));
            return memo[r][c];
        }
    }

    public static void Test()
    {
        var result = CountSquares([
            [0, 1, 1, 1],
            [1, 1, 1, 1],
            [0, 1, 1, 1]
        ]);

        Console.WriteLine(result);
    }
}