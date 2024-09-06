namespace Algorithms.Medium;

public static class LongestSubstringWithoutRepeatingCharacters
{
    public static int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 0)
            return 0;

        if (s.Length == 1)
            return 1;

        int maxLength = 0;
        bool[] visited = new bool[256];

        int left = 0, right = 0;
        while (right < s.Length)
        {
            while (visited[s[right]])
            {
                visited[s[left]] = false;
                left++;
            }

            visited[s[right]] = true;
            maxLength = Math.Max(maxLength, right - left + 1);

            right++;
        }

        return maxLength;
    }
}