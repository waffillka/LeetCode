namespace Algorithms.tbank_interview.Medium;

//https://leetcode.com/problems/merge-intervals
public static class MergeIntervals
{
    private static int[][] Merge(int[][] intervals)
    {
        if (intervals.Length == 0)
        {
            return [];
        }

        var sortedIntervals = intervals.OrderBy(x => x[0]).ToList();
        var newInter = new List<int[]>(sortedIntervals.Count) { sortedIntervals[0] };

        for (var i = 1; i < sortedIntervals.Count; i++)
        {
            var last = newInter.Last();

            if (last[1] >= sortedIntervals[i][0])
            {
                last[1] = Math.Max(last[1], sortedIntervals[i][1]);
            }
            else
            {
                newInter.Add(sortedIntervals[i]);
            }
        }

        return newInter.ToArray();
    }
    
    private static int[][] Merge_2Gen(int[][] intervals)
    {
        if (intervals.Length == 0)
        {
            return [];
        }

        Array.Sort(intervals, (f, s) => f[0].CompareTo(s[0]));
        var newInter = new List<int[]>(intervals.Length) { intervals[0] };

        for (var i = 1; i < intervals.Length; i++)
        {
            var last = newInter.Last();

            if (last[1] >= intervals[i][0])
            {
                last[1] = Math.Max(last[1], intervals[i][1]);
            }
            else
            {
                newInter.Add(intervals[i]);
            }
        }

        return newInter.ToArray();
    }

    public static void Test()
    {
        var result = Merge([[1, 3], [2, 6], [8, 10], [9, 12], [15, 18]]);
        Console.WriteLine(result);
    }
}