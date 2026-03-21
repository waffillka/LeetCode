namespace Algorithms.tbank_interview.Real_T;

//Дан массив целых чисел.
//Разрешается выполнение следующей операции любое количество раз: два соседних элемента меняются между собой знаками
// Выведите максимальную сумму элементов массива, которую можно получить.
// [ -2,1,3] 
public static class SumWithMines
{
    private static int TaskT(int[] nums)
    {
        var sum = 0;
        var minAbs = int.MaxValue;
        var negCount = 0;

        foreach (var item in nums)
        {
            if (item < 0)
            {
                negCount++;
            }

            var abs = Math.Abs(item);
            minAbs = Math.Min(abs, minAbs);
            sum += abs;
        }

        if (negCount % 2 != 0)
        {
            sum -= minAbs * 2;
        }

        return sum;
    }

    public static void Test()
    {
        var result = TaskT([-2, 1 , -3 , 5, -6, 1, 3]);
        Console.WriteLine(result);
        
        result = TaskT([0,0,0,0]);
        Console.WriteLine(result);
        
        result = TaskT([-1,-1,-1]);
        Console.WriteLine(result);
        
        result = TaskT([-1,0,-1, -1]);
        Console.WriteLine(result);
        
        result = TaskT([]);
        Console.WriteLine(result);
    }
}