namespace Algorithms.tbank_interview.Easy;

//https://leetcode.com/problems/climbing-stairs/description/
public static class ClimbingStairs
{
    private static int ClimbStairs(int n)
    {
        if (n <= 2)
        {
            return n;
        }

        var current = 3;
        var second = 2;
        var first = 1;

        for (var i = 2; i < n; i++)
        {
            current = second + first;
            first = second;
            second = current;
        }

        return current;
    }
    
    public static void Test()
    {
        var result = ClimbStairs(5);
        Console.WriteLine(result);
    }
}