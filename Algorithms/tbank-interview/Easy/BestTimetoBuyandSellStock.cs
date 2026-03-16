namespace Algorithms.tbank_interview.Easy;

public static class BestTimetoBuyandSellStock
{
    private static int MaxProfit(int[] prices)
    {
        if (prices.Length < 1)
        {
            return 0;
        }

        var maxProf = 0;
        var buy = 0;

        for (var i = 1; i < prices.Length; i++)
        {
            if (prices[buy] < prices[i])
            {
                maxProf = Math.Max(maxProf, prices[i] - prices[buy]);
            }
            else
            {
                buy = i;
            }
        }

        return maxProf;
    }

    public static void Test()
    {
        var result = MaxProfit([7, 1, 5, 3, 6, 4]);
        Console.WriteLine(result);
    }
}