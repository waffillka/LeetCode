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
PascalsTriangle.Generate(6);
//Console.WriteLine(result);