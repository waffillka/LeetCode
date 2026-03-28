namespace Algorithms.tbank_interview.Medium;

public static class GroupAnagrams
{
    private static IList<IList<string>> GroupAnagrams_gen(string[] strs)
    {
        var dict = new Dictionary<string, IList<string>>();

        foreach (var item in strs)
        {
            var temp = new int[26];
            foreach (var t in item)
            {
                temp[t - 'a']++;
            }

            var key = string.Join(',', temp);
            
            if (!dict.ContainsKey(key))
            {
                dict[key] = [item];
            }
            else
            {
                dict[key].Add(item);
            }
        }

        return dict.Values.ToList();
    }

    private static bool isAnagram(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }

        var temp = new int[26];
        for (var i = 0; i < str1.Length; i++)
        {
            temp[str1[i] - 'a']++;
            temp[str2[i] - 'a']--;
        }

        return temp.All(x => x == 0);
    }

    public static void Test()
    {
        var result = GroupAnagrams_gen(["eat", "tea", "tan", "ate", "nat", "bat"]);
        Console.WriteLine(result);
    }
}