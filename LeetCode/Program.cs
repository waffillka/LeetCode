// See https://aka.ms/new-console-template for more information

using Algorithms;

var test = new ListNode
{
    val = 1,
    next = new ListNode
    {
        val = 2,
        next = new ListNode
        {
            val = 2,
            next = new ListNode
            {
                val = 3,
                next = new ListNode
                {
                    val = 3,
                    next = new ListNode
                    {
                        val = 4,
                        next = new ListNode
                        {
                            val = 4,
                            next = new ListNode
                            {
                                val = 4,
                                next = new ListNode
                                {
                                    val = 5,
                                    next = new ListNode
                                    {
                                        val = 5,
                                        next = null
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
};

//var result =DeleteDuplicates.DeleteDuplicatesTask(test);
//var result = PlusOne.PlusOneTask(new[] { 9, 9, 9 });
//LengthOfLastWord_class.LengthOfLastWord("   fly me   to   the moon  ");
MergeSortedArray.Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);
MergeSortedArray.Merge(new int[] { 0 }, 0, new int[] { 1 }, 1);
MergeSortedArray.Merge(new int[] { 1 }, 1, new int[] { 0 }, 0);
//Console.WriteLine(result);