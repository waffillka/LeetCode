namespace Algorithms.tbank_interview.Easy;

public static class ValidAnagram
{
    private static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var sDict = new Dictionary<char, int>();
        var tDict = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++)
        {
            sDict[s[i]] = sDict.GetValueOrDefault(s[i], 0) + 1;
            tDict[t[i]] = tDict.GetValueOrDefault(t[i], 0) + 1;
        }

        return sDict.Count == tDict.Count && !sDict.Except(tDict).Any();
    }

    private static bool IsAnagram_2gen(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var count = new int[26];

        for (var i = 0; i < s.Length; i++)
        {
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }

        return count.All(c => c == 0);
    }

    private static bool IsAnagram_3gen(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var count = new int[26];

        for (var i = 0; i < s.Length; i++)
        {
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }

        foreach (var item in count)
        {
            if (item != 0)
            {
                return false;
            }
        }

        return true;
    }

    public static void Test()
    {
        var result = IsAnagram("anagram", "nagaram");
        Console.WriteLine(result);
    }
}