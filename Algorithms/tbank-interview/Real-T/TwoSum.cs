namespace Algorithms.tbank_interview.Real_T;

// https://leetcode.com/problems/two-sum
public static class TwoSum
{
    private static int[] TwoSum_2GEN(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length - 1; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }

        return [-1, -1];
    }

    private static int[] TwoSum_3GEN(int[] nums, int target)
    {
        var numbers = nums.Select((num, index) => (num, index)).ToArray();
        Array.Sort(numbers, (a, b) => a.num.CompareTo(b.num));

        var left = 0;
        var right = numbers.Length - 1;

        while (left < right)
        {
            var sum = numbers[left].num + numbers[right].num;
            if (sum == target)
            {
                return [numbers[left].index, numbers[right].index];
            }

            if (sum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }


        return [-1, -1];
    }

    private static int[] TwoSum_4GEN(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>(nums.Length)
        {
            [nums[0]] = 0
        };

        for (var i = 1; i < nums.Length; i++)
        {
            var value = nums[i];
            var diff = target - value;
            if (dict.TryGetValue(diff, out var index))
            {
                return [index, i];
            }

            dict[value] = i;
        }

        return [-1, -1];
    }

    private static int[] TwoSum_5GEN(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>(nums.Length);

        for (var i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];
            if (dict.TryGetValue(diff, out var index))
            {
                return [index, i];
            }

            dict[nums[i]] = i;
        }

        return [-1, -1];
    }

    public static void Test()
    {
        var result = TwoSum_5GEN([1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1], 11);
        Console.WriteLine(result);
    }
}