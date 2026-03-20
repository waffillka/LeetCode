namespace Algorithms.tbank_interview.Medium;

public static class Search2DMatrix
{
    private static bool SearchMatrix(int[][] matrix, int target)
    {
        foreach (var t in matrix)
        {
            if (t[0] <= target && t[t.Length - 1] >= target)
            {
                if (t[0] == target || t[t.Length - 1] == target)
                {
                    return true;
                }

                return SearchMatrix(t, target);
            }
        }

        return false;
    }

    private static bool SearchMatrix(int[] arr, int target)
    {
        var left = 0;
        var right = arr.Length - 1;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            if (arr[mid] == target)
            {
                return true;
            }


            if (target > arr[mid])
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return false;
    }

    public static void Test()
    {
        var result = SearchMatrix(new int[][] { [1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60] }, 5);
        Console.WriteLine(result);
    }
}