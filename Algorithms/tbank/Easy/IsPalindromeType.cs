namespace Algorithms.tbank.Easy;

public static class IsPalindromeType
{
    public static bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        if (x % 10 == 0) return true;

        var tmp = x;
        var y = x % 10;
        while (tmp / 10 != 0)
        {
            tmp /= 10;
            y = y * 10 + tmp % 10;
        }

        return y == x;
    }

    public static bool IsPalindrome1(int x)
    {
        if (x < 0) return false;
        if (x / 10 == 0) return true;

        var tmp = x;
        var y = tmp % 10;
        while (tmp / 10 != 0)
        {
            y = (y * 10) + (tmp /= 10) % 10;
        }

        return y == x ? true : false;
    }

    public static bool IsPalindrome2(int x)
    {
        if (x < 0) return false;
        if (x / 10 == 0) return true;

        var xString = Convert.ToString(x);
        var size = xString.Length - 1;
        int middleSize = size / 2;
        for (var i = 0; i <= middleSize; i++)
        {
            if (xString[i] != xString[size - i])
            {
                return false;
            }
        }
        
        return true;
    }
}