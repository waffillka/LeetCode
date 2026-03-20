namespace Algorithms.tbank_interview.Medium;

public static class RotateImage
{
    private static void Rotate(int[][] matrix)
    {
        if (matrix.Length <= 1)
        {
            return;
        }

        Array.Reverse(matrix);
        var size = matrix.Length;
        for (var i = 0; i < size; i++)
        {
            for (var j = i; j < size; j++)
            {
                (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
            }
        }
    }


    public static void Test()
    {
        var matrix = new int[][] { [1, 2, 3], [4, 5, 6], [7, 8, 9] };
        Rotate(matrix);
        Console.WriteLine(matrix);
    }
}