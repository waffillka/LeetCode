namespace Algorithms.tbank_interview.Easy;

public static class IsomorphicStrings
{
    public static bool IsIsomorphic(string s, string t)
    {
        return IsIsomorphicHelp(s, t) && IsIsomorphicHelp(t, s);
    }

    private static bool IsIsomorphicHelp(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var dict = new Dictionary<char, char>();

        for (var i = 0; i < s.Length; i++)
        {
            if (dict.TryGetValue(s[i], out var ch))
            {
                if (t[i] != ch)
                {
                    return false;
                }
            }
            else
            {
                dict[s[i]] = t[i];
            }
        }

        return true;
    }

    public static bool IsIsomorphic_2Gen(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var dictS = new Dictionary<char, char>();
        var dictT = new Dictionary<char, char>();

        for (var i = 0; i < s.Length; i++)
        {
            if ((dictS.TryGetValue(s[i], out var ch1) && t[i] != ch1)
                || (dictT.TryGetValue(t[i], out var ch2) && s[i] != ch2))
            {
                return false;
            }

            dictS[s[i]] = t[i];
            dictT[t[i]] = s[i];
        }

        return true;
    }
}