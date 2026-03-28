namespace Algorithms.tbank_interview.Real_T;

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

    private static int NumIslands_gen(char[][] grid)
    {
        var result = 0;
        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    result++;
                    DeleteIsland(grid, i, j);
                }
            }
        }

        return result;
    }

    private static void DeleteIsland(char[][] grid, int row, int col)
    {
        if (row < 0 || col < 0 || row >= grid.Length || col >= grid[row].Length || grid[row][col] == '0')
        {
            return;
        }
        
        grid[row][col] = '0';

        DeleteIsland(grid, row + 1, col);
        DeleteIsland(grid, row - 1, col);
        DeleteIsland(grid, row, col + 1);
        DeleteIsland(grid, row, col - 1);
    }


    public static void Test()
    {
        var result = NumIslands_gen([['1', '1', '1', '1', '0'], ['1', '1', '0', '1', '0'], ['1', '1', '0', '0', '0'], ['0', '0', '0', '0', '0']]);
        Console.WriteLine(result);
    }
}