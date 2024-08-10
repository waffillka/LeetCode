namespace Algorithms;

public static class PascalsTriangle
{
    public static IList<IList<int>> Generate(int numRows)
    {
        var results = new List<IList<int>>()
        {
            new List<int> { 1 }
        };

        if (numRows == 1)
        {
            return results;
        }

        results.Add(new List<int>() { 1, 1 });
        
        for (var i = 0; i < numRows - 2; i++)
        {
            var item = new List<int>() { 1 };
            for (var j = 0; j < results[i].Count - 1; j++)
            {
                item.Add(results[i][j] + results[i][j + 1]);
            }

            item.Add(1);
            results.Add(item);
        }


        return results;
    }
}