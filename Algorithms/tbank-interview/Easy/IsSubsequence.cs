namespace Algorithms.tbank_interview.Easy;

public static class IsSubsequence
{
    private static bool IsSubsequence_gen(string s, string t)
    {
        if (s.Length == 0)
        {
            return true;
        }

        if (s.Length > t.Length)
        {
            return false;
        }

        var i = 0;
        var j = 0;
        while (i < t.Length)
        {
            if (t[i] == s[j])
            {
                j++;
                if (s.Length == j)
                    return true;
            }

            i++;
        }

        return false;
    }

    public static void Test()
    {
        var result = IsSubsequence_gen("abc", "ahbgdc");
        Console.WriteLine(result);

        result = IsSubsequence_gen("abc", "ahbgabcdc");
        Console.WriteLine(result);

        result = IsSubsequence_gen("axc", "ahbgabcdc");
        Console.WriteLine(result);
    }
}