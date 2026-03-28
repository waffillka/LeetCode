using System.Text;

// https://leetcode.com/problems/decode-string/description/
namespace Algorithms.tbank_interview.Medium;

public static class DecodeString
{
    private static string DecodeString_gen(string s)
    {
        if (s.Length == 0)
        {
            return string.Empty;
        }

        var numStack = new Stack<int>();
        var strStack = new Stack<string>();
        var num = 0;
        var str = string.Empty;

        foreach (var item in s)
        {
            if (char.IsDigit(item))
            {
                num = num * 10 + (item - '0');
            }
            else if (item == '[')
            {
                strStack.Push(str);
                numStack.Push(num);
                str = string.Empty;
                num = 0;
            }
            else if (item == ']')
            {
                var count = numStack.Pop();
                var prevStr = strStack.Pop();
                var sb = new StringBuilder();
                for (var i = 0; i < count; i++)
                {
                    sb.Append(str);
                }

                str = prevStr + sb;
            }
            else
            {
                str += item;
            }
        }

        return str;
    }

    public static void Test()
    {
        var result = DecodeString_gen("3[a]2[bc]");
        Console.WriteLine(result);

        var result1 = DecodeString_gen("3[a2[c]a]");
        Console.WriteLine(result);

        var result2 = DecodeString_gen("2[abc]3[cd]ef");
        Console.WriteLine(result);
    }
}