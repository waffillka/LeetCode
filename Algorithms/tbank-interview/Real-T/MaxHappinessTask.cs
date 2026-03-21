namespace Algorithms.tbank_interview.Real_T;

//Петя хочет устроить вечеринку. У него есть список друзей, заданный в виде двумерного массива [[w1, h1l, [W2, h2l, ..].
//Все числа натуральные.
// Где
// w; - уровень достатка у і-ого друга,
// а h; - уровень счастья Пети, если этот друг
// будет присутствовать на встрече.
// Итоговое счастье Пети будет равняться сумме уровней счастья пришедших друзей.
// Также Петя знает, что если у кого-то из друзей уровень достатка в два или более раза меньше уровня достатка кого-либо на вечеринке,
// то он будет чуствовать себя некомфортно.
// Петя не хочет, чтобы кому-то из его гостей было некомфортно.
// Найдите максимальный уровень счастья вечеринки, которую может устроить Петя.

//maxHappiness([1,3], [5, 2], [3, 2])
public static class MaxHappinessTask
{
    private static long MaxHappiness(int[][] friends)
    {
        if (friends.Length == 0)
        {
            return 0;
        }

        if (friends.Length == 1)
        {
            return friends[0][1];
        }


        var sorted = friends.OrderBy(x => x[0]).ToList();

        var maxHappiness = 0; //3
        var tempHappiness = sorted[0][1]; //3

        var left = 0;
        var right = 1;

        while (right < sorted.Count)
        {
            if (2 * sorted[left][0] <  sorted[right][0]) //2 * 1 < 5    >>     2 * 5 < 3
            {
                tempHappiness -= sorted[left][1];
                left++;
                continue;
            }
            
            tempHappiness += sorted[right][1];
            maxHappiness = Math.Max(maxHappiness, tempHappiness);
            right++;
        }


        return maxHappiness;
    }

    public static void Test()
    {
        var result = MaxHappiness([[1, 3], [5, 2], [3, 2]]);
        Console.WriteLine(result);

        var result1 = MaxHappiness([[1, 3], [5, 2], [3, 2], [1, 3], [1, 3], [3, 11]]);
        Console.WriteLine(result1);

        var result2 = MaxHappiness([[1, 3]]);
        Console.WriteLine(result2);

        var result3 = MaxHappiness([[1, 1], [1, 2], [1, 3], [1, 4]]);
        Console.WriteLine(result3);
        
        var result4 = MaxHappiness([[1, 1], [1, 2], [12, 12], [1, 4]]);
        Console.WriteLine(result4);
    }
}