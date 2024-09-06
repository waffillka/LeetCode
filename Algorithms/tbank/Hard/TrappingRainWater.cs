namespace Algorithms.tbank.Hard;

public static class TrappingRainWater
{
    public static int Trap(int[] height)
    {
        var result = 0;
        var left = height.Length - 1;
        var right = 0;
        var maxLeft = 0;
        var maxRight = 0;

        return result = 0;
    }

    public static int Trap1(int[] height)
    {
        int n = height.Length;
        int left = 0, right = n - 1;
        int res = 0;
        int maxLeft = 0, maxRight = 0;
        while (left <= right)
        {
            if (height[left] <= height[right])
            {
                if (height[left] >= maxLeft)
                {
                    maxLeft = height[left];
                }
                else
                {
                    res += maxLeft - height[left];
                }

                left++;
            }
            else
            {
                if (height[right] >= maxRight)
                {
                    maxRight = height[right];
                }
                else
                {
                    res += maxRight - height[right];
                }

                right--;
            }
        }

        return res;
    }
}