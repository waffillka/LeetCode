namespace Algorithms.tbank_interview.Medium;

public static class MaximizeDistancetoClosestPerson
{
    private static int MaxDistToClosestIndex(int[] seats)
    {
        var maxLeft = 0;
        var maxRight = 0;
        var left = 0;
        var right = 0;

        while (right < seats.Length)
        {
            if (seats[right] == 1)
            {
                if (right - left > maxRight - maxLeft)
                {
                    maxRight = right;
                    maxLeft = left;
                }

                left = right + 1;
            }

            right++;
        }

        if (right - left > maxRight - maxLeft)
        {
            maxRight = right;
            maxLeft = left;
        }

        if (maxRight == seats.Length)
        {
            return maxRight - 1;
        }

        if (maxLeft == 0)
        {
            return maxLeft;
        }

        var result = maxRight - ((maxRight - maxLeft) / 2) - 1;
        return result;
    }


    private static int MaxDistToClosest_2gen(int[] seats)
    {
        var maxD = 0;
        var lastP = -1;

        for (var i = 0; i < seats.Length; i++)
        {
            if (seats[i] == 1)
            {
                if (lastP == -1)
                {
                    maxD = i;
                }
                else
                {
                    maxD = Math.Max(maxD, (i - lastP) / 2);
                }

                lastP = i;
            }
        }

        return Math.Max(maxD, seats.Length - lastP - 1);
    }

    public static void Test()
    {
        var result7 = MaxDistToClosest_2gen([1, 0, 0, 0, 1, 0, 1]);
        Console.WriteLine(result7);

        var result1 = MaxDistToClosest_2gen([1, 0, 0, 0, 1]);
        Console.WriteLine(result1);

        var result2 = MaxDistToClosest_2gen([1, 0, 0, 0]);
        Console.WriteLine(result2);

        var result3 = MaxDistToClosest_2gen([0, 1]);
        Console.WriteLine(result3);

        var result4 = MaxDistToClosest_2gen([1, 0]);
        Console.WriteLine(result4);

        var result5 = MaxDistToClosest_2gen([0, 0, 0, 0, 0]);
        Console.WriteLine(result5);

        var result6 = MaxDistToClosest_2gen([1, 0, 0, 0, 0, 1]);
        Console.WriteLine(result6);
    }
}