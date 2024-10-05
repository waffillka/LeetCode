namespace Algorithms.tbank.Easy;

public static class MinCostClimbingStairsЕнзу
{
    public static int MinCostClimbingStairs(int[] cost)
    {
        var flow1 = 0;
        var flow2 = 0;
        var temp = 0;
        for (var i = cost.Length - 1; i >= 0; i--)
        {
            temp = cost[i] + Math.Min(flow1, flow2);
            flow2 = flow1;
            flow1 = temp;
        }

        return Math.Min(flow1, flow2);
    }

    public static int MinCostClimbingStairs1(int[] cost)
    {
        int f1 = 0, f2 = 0;
        for (int i = cost.Length - 1; i >= 0; --i)
        {
            int f0 = cost[i] + Math.Min(f1, f2);
            f2 = f1;
            f1 = f0;
        }

        return Math.Min(f1, f2);
    }
}