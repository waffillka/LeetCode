namespace Algorithms.tbank.Easy;

public static class IslandPerimeterType
{
    public static int IslandPerimeter(int[][] grid)
    {
        var result = 0;
        var rows = grid.Length;
        var cols = grid[0].Length;
        for (var row = 0; row < rows; row++)
        {
            for (var col = 0; col < cols; col++)
            {
                if (grid[row][col] == 1)
                {
                    result += IsLand(grid, row - 1, col);
                    result += IsLand(grid, row, col - 1);
                    result += IsLand(grid, row + 1, col);
                    result += IsLand(grid, row, col + 1);
                }
            }
        }

        return result;
    }

    private static int IsLand(int[][] grid, int row, int col)
    {
        if (row < 0 || col < 0 || row >= grid.Length || col >= grid[0].Length)
        {
            return 1;
        }
        return grid[row][col] == 1 ? 0 : 1;
    }
}