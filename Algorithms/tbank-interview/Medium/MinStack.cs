using System.IO.Compression;

namespace Algorithms.tbank_interview.Medium;

public class MinStack
{
    private readonly Stack<int> _stack;
    private readonly Stack<int> _minStack;

    public MinStack()
    {
        _stack = new();
        _minStack = new();
    }

    public void Push(int val)
    {
        _stack.Push(val);
        _minStack.Push(Math.Min(val, _minStack.Count > 0 ? _minStack.Peek() : val));
    }

    public void Pop()
    {
        _stack.Pop();
        _minStack.Pop();
    }

    public int Top()
    {
        return _stack.Peek();
    }

    public int GetMin()
    {
        return _minStack.Peek();
    }
}

public class MinStack_List
{
    private readonly List<int> _stack;
    private int _index;
    private readonly List<int> _minStack;

    public MinStack_List()
    {
        _stack = new();
        _index = -1;
        _minStack = new();
    }

    public void Push(int val)
    {
        _stack.Add(val);
        _minStack.Add(Math.Min(val, _index >= 0 ? _minStack[_index] : val));
        _index++;
    }

    public void Pop()
    {
        if (_index >= 0)
        {
            _stack.RemoveAt(_index);
            _minStack.RemoveAt(_index);
            _index--;
        }
    }

    public int Top()
    {
        if (_index < 0)
        {
            return default;
        }

        return _stack[_index];
    }

    public int GetMin()
    {
        if (_index < 0)
        {
            return default;
        }

        return _minStack[_index];
    }
}

public static class MinStackTask
{
    public static void Test()
    {
        var stack = new MinStack_List();
        stack.Push(-2);
        stack.Push(0);
        stack.Push(-3);
        Console.WriteLine(stack.GetMin());
        stack.Pop();
        Console.WriteLine(stack.Top());
        Console.WriteLine(stack.GetMin());
    }
}