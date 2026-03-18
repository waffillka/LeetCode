using System.Text;
//https://leetcode.com/problems/backspace-string-compare
namespace Algorithms.tbank_interview.Easy;

public static class BackspaceStringCompare
{
    private static bool BackspaceCompare(string s, string t)
    {
        return BuildString(s) == BuildString(t);
    }

    private static string BuildString(string s)
    {
        var stack = new Stack<char>();
        foreach (var item in s)
        {
            if (item == '#')
            {
                stack.TryPop(out var c);
            }
            else
            {
                stack.Push(item);
            }
        }

        var newString = string.Empty;
        foreach (var item in stack.Reverse())
        {
            newString += item;
        }


        return newString;
    }

    private static bool BackspaceCompare_2Gen(string s, string t)
    {
        var sStack = BuildString_2Gen(s);
        var tStack = BuildString_2Gen(t);

        if (sStack.Count != tStack.Count)
        {
            return false;
        }

        while (sStack.Count > 0)
        {
            if (sStack.TryPop(out var c) != tStack.TryPop(out var c2) || c != c2)
            {
                return false;
            }
        }

        return true;
    }

    private static Stack<char> BuildString_2Gen(string s)
    {
        var stack = new Stack<char>();
        foreach (var item in s)
        {
            if (item == '#')
            {
                stack.TryPop(out var c);
            }
            else
            {
                stack.Push(item);
            }
        }

        return stack;
    }

    public static void Test()
    {
        var result = BackspaceCompare("ab#c", "adc");
        Console.WriteLine(result);
    }
}