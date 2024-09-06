// See https://aka.ms/new-console-template for more information

using Algorithms;
using Algorithms.Medium;

var test = new ListNode
{  // 6 2 2 3 3 4 4 4 5 5
    val = 6,
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

var test00 = new ListNode
{  // 6 9 2 7 6
    val = 6,
    next = new ListNode
    {
        val = 9,
        next = new ListNode
        {
            val = 2,
            next = new ListNode
            {
                val = 7,
                next = new ListNode
                {
                    val = 6,
                    next = null
                }
            }
        }
    }
};

var test1 = new ListNode
{ // 9 3 5 9 6 8 9
    val = 9,
    next = new ListNode
    {
        val = 3,
        next = new ListNode
        {
            val = 5,
            next = new ListNode
            {
                val = 9,
                next = new ListNode
                {
                    val = 6,
                    next = new ListNode
                    {
                        val = 8,
                        next = new ListNode
                        {
                            val = 9,
                            next = null
                        }
                    }
                }
            }
        }
    }
};

var test11 = new ListNode
{ // 9 3 5 
    val = 9,
    next = new ListNode
    {
        val = 3,
        next = new ListNode
        {
            val = 5,
            next = null
        }
    }
};

//var result =DeleteDuplicates.DeleteDuplicatesTask(test);
//var result = PlusOne.PlusOneTask(new[] { 9, 9, 9 });
//LengthOfLastWord_class.LengthOfLastWord("   fly me   to   the moon  ");
//PascalsTriangle.Generate(6);
//Console.WriteLine(result);

var t = AddTwoNumbers.AddTwoNumbersTask(test00, test11);
var rs = 0;