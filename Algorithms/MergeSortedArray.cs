namespace Algorithms;

public static class MergeSortedArray
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var tempList = new List<int>(nums1.Take(m));
        tempList.AddRange(nums2.Take(n));
        tempList.Sort();
        nums1 = tempList.ToArray();
    }

    public static void Merge1(int[] nums1, int m, int[] nums2, int n)
    {
        List<int> tempList = new List<int>(nums1.Take(m));
        tempList.AddRange(nums2.Take(n));
        tempList.Sort();

        for (int i = 0; i < tempList.Count; i++)
        {
            nums1[i] = tempList[i];
        }
    }  
    
    public static void Merge2(int[] nums1, int m, int[] nums2, int n)
    {
        int j = 0;
        for(int i = m; i < (m + n); i++)
        {
            nums1[i] = nums2[j];
            j++;
        }

        Array.Sort(nums1);
    }
}