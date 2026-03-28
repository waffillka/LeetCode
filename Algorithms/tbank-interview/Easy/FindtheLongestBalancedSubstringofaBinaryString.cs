namespace Algorithms.tbank_interview.Easy;

// https://leetcode.com/problems/find-the-longest-balanced-substring-of-a-binary-string/description/
public static class FindtheLongestBalancedSubstringofaBinaryString
{
    //Wrong
    private static int FindTheLongestBalancedSubstring(string s)
    {
        if (s.Length == 0)
        {
            return 0;
        }

        var balance = 0;
        var lastBalance = 0;
        var max = 0;
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '1')
            {
                balance++;
            }
            else
            {
                balance--;
            }

            if (balance == 0 && s[lastBalance] == '0')
            {
                max = Math.Max(max, i - lastBalance + 1);
                lastBalance = i + 1;
            }

            
        }
        
        return max;
    }
    
    public static void Test()
    {
        var result1 = FindTheLongestBalancedSubstring("01010101");
        Console.WriteLine(result1); 
        
        var result2 = FindTheLongestBalancedSubstring("01000111");
        Console.WriteLine(result2); 
        
        var result3 = FindTheLongestBalancedSubstring("00111");
        Console.WriteLine(result3); 
        
        var result4 = FindTheLongestBalancedSubstring("111");
        Console.WriteLine(result4);
    }
}