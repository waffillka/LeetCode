namespace Algorithms.tbank_interview.Medium;

// https://leetcode.com/problems/number-of-islands/description/
public static class NumberOfIslands
{
    private static int NumIslands(char[][] grid)
    {
        var islands = 0;
        var rows = grid.Length;

        for (var row = 0; row < rows; row++)
        {
            for (var col = 0; col < grid[row].Length; col++)
            {
                if (grid[row][col] == '1')
                {
                    islands++;
                    Dfs(grid, row, col);
                }
            }
        }
        
        return islands;
    }

    private static void Dfs(char[][] grid, int row, int col)
    {
        var rows = grid.Length;
        var cols = grid[0].Length;

        if (row < 0 || col < 0 || row >= rows || col >= cols || grid[row][col] == '0')
        {
            return;
        }

        grid[row][col] = '0';

        Dfs(grid, row + 1, col);
        Dfs(grid, row - 1, col);
        Dfs(grid, row, col + 1);
        Dfs(grid, row, col - 1);
    }

    public static void Test()
    {
        var result = NumIslands([['1', '1', '1', '1', '0'], ['1', '1', '0', '1', '0'], ['1', '1', '0', '0', '0'], ['0', '0', '0', '0', '0']]);
        Console.WriteLine(result);
    }
}