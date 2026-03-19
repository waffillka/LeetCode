using System.Numerics;
//https://leetcode.com/problems/number-of-1-bits
namespace Algorithms.tbank_interview.Easy;

public static class Numberof1Bits
{
    private static int HammingWeight(int n)
    {
        var result = 0;
        
        var binary = Convert.ToString(n, 2);
        foreach (var item in binary)
        {
            if (item == '1')
            {
                result++;
            }
        }
        return result;
    }
    
    private static int HammingWeight_2gen(int n)
    {
        return (int)BitOperations.PopCount((uint)n);
    }
    
    public static void Test()
    {
        var result = HammingWeight(11);
        Console.WriteLine(result);
    }
}