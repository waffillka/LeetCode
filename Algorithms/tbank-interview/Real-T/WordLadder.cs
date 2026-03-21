namespace Algorithms.tbank_interview.Real_T;

// Даны строки start, finish и массив строк wordsl].
// Все строки одной длины К.
// Строку start можно превратить в строку finish, если существует цепочка преобразований: start → s_1 →... → s_N → finish,
// в которой соседние строки отличаются ровно на одну
// букву и каждая строка s_і входит в массив wordsl.
// Найти длину кратчайшей цепочки преобразований из start в
// finish.
// Input: start = "пир", finish = "сок", words =
// ["пик", "кот", "сок", "тик", "тир", "ток",
// "ком"]
// Output: 5 (пир → тир → тик → ток → сок)
public static class WordLadder
{
    private static int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        var set = new HashSet<string>(wordList);
        if (!set.Contains(endWord))
        {
            return 0;
        }

        var queue = new Queue<(string word, int steps)>();
        queue.Enqueue((beginWord, 1));

        while (queue.Count > 0)
        {
            var (word, step) = queue.Dequeue();

            if (word == endWord)
            {
                return step;
            }

            var chars = word.ToCharArray();

            for (var i = 0; i < chars.Length; i++)
            {
                var orig = chars[i];

                for (var letter = 'a'; letter <= 'z'; letter++)
                {
                    if (letter == orig)
                    {
                        continue;
                    }

                    chars[i] = letter;
                    var str = new string(chars);
                    Console.WriteLine(str);
                    if (set.Contains(str))
                    {
                        queue.Enqueue((str, step + 1));
                        set.Remove(str);
                    }
                }

                Console.WriteLine("---------------------------------");
                chars[i] = orig;
            }
        }


        return 0;
    }

    public static void Test()
    {
        var result = LadderLength("hit", "cog", new List<string> { "hot", "dot", "dog", "lot", "log", "cog" });
        Console.WriteLine(result);
    }
}