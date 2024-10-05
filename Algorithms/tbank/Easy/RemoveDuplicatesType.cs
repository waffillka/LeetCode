namespace Algorithms.tbank.Easy;

public static class RemoveDuplicatesType
{
    public static int RemoveDuplicates(int[] nums) {
      
        return 0;
    }
    
    public static int RemoveDuplicatesDone(int[] nums) {
        if (nums.Length == 0)
            return 0;
        
        var k = 0;
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[k])
            {
                k++;
                nums[k] = nums[i];
            }
        }

        return k + 1;
    }
}