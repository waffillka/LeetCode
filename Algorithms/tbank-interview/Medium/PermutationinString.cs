namespace Algorithms.tbank_interview.Medium;

//!dict1.Except(dict2).Any()
public static class PermutationinString
{
    private static bool CheckInclusion(string s1, string s2)
    {
        var dict = new Dictionary<char, int>();
        foreach (var item in s1)
        {
            if (!dict.TryAdd(item, 1))
            {
                dict[item]++;
            }
        }

        var left = 0;
        var right = 0;

        var dict2 = new Dictionary<char, int>();
        while (right < s2.Length)
        {
            if (!dict2.TryAdd(s2[right], 1))
            {
                dict2[s2[right]]++;
            }

            if (right - left + 1 == s1.Length)
            {
                if (!dict.Except(dict2.Where(x => x.Value != 0)).Any())
                {
                    return true;
                }

                dict2[s2[left]]--;
                left++;
            }

            right++;
        }


        return false;
    }

    private static bool CheckInclusion_2gen(string s1, string s2)
    {
        if (s1.Length > s2.Length)
        {
            return false;
        }

        var dict = new int[26];
        foreach (var item in s1)
        {
            dict[item - 'a']++;
        }

        var left = 0;
        var right = 0;

        var dict2 = new int[26];
        while (right < s2.Length)
        {
            dict2[s2[right] - 'a']++;
            if (right - left + 1 == s1.Length)
            {
                if (dict2.SequenceEqual(dict))
                {
                    return true;
                }

                dict2[s2[left] - 'a']--;
                left++;
            }

            right++;
        }


        return false;
    }

    public static void Test()
    {
        //"ab", s2 = "eidbaooo" //true
        var result = CheckInclusion_2gen("ab", "eidbaooo");
        Console.WriteLine(result);

        //Input: s1 = "ab", s2 = "eidboaoo"
        // Output: false
        var result1 = CheckInclusion_2gen("ab", "eidboaoo");
        Console.WriteLine(result1);
    }
}