namespace Algorithms.Medium;

public static class TwoSum
{
    public static int[] TwoSum1(int[] numbers, int target)
    {
        int low = 0;
        int high = numbers.Length - 1;
        while (low < high) {
            int sum = numbers[low] + numbers[high];
                          
            if (sum == target) {
                return [low + 1, high + 1];
            } else if (sum < target) {
                ++low;
            } else {
                --high;
            }
        }
        
        return [-1, -1];
    }
}