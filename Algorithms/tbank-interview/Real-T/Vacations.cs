namespace Algorithms.tbank_interview.Real_T;

//Программист Изосим хочет в отпуск, длительностью не меньше, чем к дней подряд. Тимлид Иннокентий не отпускает Изосима в отпуск, если в день отсутствия Изосима будет релиз.
// На вход получаем k - минимальную продолжительность отпуска, на который согласен Изосим и список дней в виде массива из чисел 0 (релиза не будет) и 1 (запланировал релиз).
// Найти количество вариантов для отпуска Изосима, с учетом того, что отпуск не должен прерываться рабочими днями.
// findDayoffs(2, [0,0,1,0,0]) → 2
// findDayoffs(1, [0,0,1,0]) -> 4 // Три варианта продолжительностью 1 день и один вариант 2 дня
// findDayoffs(3, [0,0,1,0,0]) -> e

public static class Vacations
{
    private static int MaxVacations(int[] days, int k)
    {
        var left = 0;
        var right = 0;
        var count = 0;
        while (right < days.Length)
        {
            if (days[right] == 1)
            {
                right++;
                left = right;
                continue;
            }

            if (right - left + 1 == k)
            {
                count++;
                left++;
            }

            right++;
        }


        return count;
    }

    public static void Test()
    {
        var result = MaxVacations([0, 0, 1, 0, 0], 2);
        Console.WriteLine(result);

        var result1 = MaxVacations([0, 0, 1, 0], 1);
        Console.WriteLine(result1);

        var result2 = MaxVacations([0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0], 2);
        Console.WriteLine(result2);

        var result3 = MaxVacations([0, 0, 1, 0, 0], 3);
        Console.WriteLine(result3);

        var result4 = MaxVacations([], 3);
        Console.WriteLine(result4);
    }
}