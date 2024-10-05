namespace Algorithms.tbank.Easy;

public static class BestTimeToBuyAndSellStock
{
    public static int MaxProfit(int[] prices)
    {
        var minValue = prices[0];
        var result = 0;

        for (var i = 1; i < prices.Length; i++)
        {
            minValue = Math.Min(minValue, prices[i]);
            result = Math.Max(result, prices[i] - minValue);
        }

        return result;
    }
}