namespace Algorithms.tbank_interview.Easy;

//https://leetcode.com/problems/valid-parentheses/description/
public static class ValidParentheses
{
    private static bool IsValid(string s)
    {
        if (s.Length < 2)
        {
            return false;
        }

        var stack = new Stack<char>();
        foreach (var item in s)
        {
            if (item is ')' or ']' or '}')
            {
                if (!stack.TryPop(out var top))
                {
                    return false;
                }

                if ((item == ')' && top == '(') || (item == ']' && top == '[') || (item == '}' && top == '{'))
                {
                   continue; 
                }
                else
                {
                    return false;
                }
            }
            else
            {
                stack.Push(item);
            }
        }

        return stack.Count == 0;
    }
    
    public static void Test()
    {
        var result = IsValid("()[]{}()");
        Console.WriteLine(result);
        
        result = IsValid("()[]((}()");
        Console.WriteLine(result);
    }
}