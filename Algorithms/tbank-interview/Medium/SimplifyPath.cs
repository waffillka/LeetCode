using System.Text;
//https://leetcode.com/problems/simplify-path/description/
//https://neetcode.io/solutions/simplify-path
namespace Algorithms.tbank_interview.Medium;

public static class SimplifyPath
{
    private static string SimplifyPath_Gen(string path)
    {
        var stack = new Stack<string>();
        var slised = path.Split('/');
        foreach (var item in slised)
        {
            if (item == "..")
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            else
            {
                if (item != string.Empty && item != ".")
                {
                    stack.Push(item);
                }
            }
        }
        
        var resList = new List<string>(stack);
        resList.Reverse();

        return "/" + string.Join("/", resList);
    }

    public static void Test()
    {
        var result = SimplifyPath_Gen("/home/");
        Console.WriteLine(result);

        result = SimplifyPath_Gen("/home//foo/");
        Console.WriteLine(result);

        result = SimplifyPath_Gen("/home/user/Documents/../Pictures");
        Console.WriteLine(result);

        result = SimplifyPath_Gen("/../");
        Console.WriteLine(result);

        result = SimplifyPath_Gen("/.../a/../b/c/../d/./");
        Console.WriteLine(result);
    }
}