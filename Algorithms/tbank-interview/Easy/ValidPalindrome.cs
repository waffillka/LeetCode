namespace Algorithms.tbank_interview.Easy;
//https://leetcode.com/problems/valid-palindrome/
public static class ValidPalindrome
{
    private static bool IsPalindrome(string s)
    {
        if (s == null || s == string.Empty)
        {
            return false;
        }

        if (string.IsNullOrEmpty(s))
        {
            return true;
        }

        var letters = s.ToLower().Where(char.IsLetterOrDigit).ToArray();

        var left = 0;
        var right = letters.Length - 1;
        while (left < right)
        {
            if (letters[left] != letters[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }

    private static bool IsPalindrome_2gen(string s)
    {
        var left = 0;
        var right = s.Length - 1;
        s = s.ToLower();
        while (left < right)
        {
            if (!char.IsLetterOrDigit(s[left]))
            {
                left++;
            }
            else if (!char.IsLetterOrDigit(s[right]))
            {
                right--;
            }
            else if (s[left] != s[right])
            {
                return false;
            }
            else
            {
                left++;
                right--;
            }
        }

        return true;
    }

    public static void Test()
    {
        var result = IsPalindrome_2gen("A man, a plan, a canal: Panama");
        Console.WriteLine(result);

        // result = IsPalindrome("A man, a plan, a canal: Panama");
        // Console.WriteLine(result);
        //
        // result = IsPalindrome("0P");
        // Console.WriteLine(result);
    }
}