namespace Algorithms.tbank_interview.Medium;

public static class ContainerWithMostWater
{
    private static int MaxArea(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;
        var result = 0;

        while (left < right)
        {
            result = Math.Max(result, Math.Min(height[right], height[left]) * (right - left));
            if (height[right] > height[left])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return result;
    }

    private static int MaxArea_gen(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;
        var result = 0;

        while (left < right)
        {
            if (height[right] > height[left])
            {
                result = Math.Max(result, height[left] * (right - left));
                left++;
            }
            else
            {
                result = Math.Max(result, height[right] * (right - left));
                right--;
            }
        }

        return result;
    }

    public static void Test()
    {
        var result = MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]);
        Console.WriteLine(result);
    }
}