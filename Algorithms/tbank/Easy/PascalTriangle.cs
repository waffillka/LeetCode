namespace Algorithms.tbank.Easy;

public static class PascalTriangle
{
    public static IList<IList<int>> Generate(int numRows)
    {
        var result = new List<IList<int>>();

        if (numRows == 1)
        {
            result.Add(new List<int>() { 1 });
            return result;
        }

        result.Add(new List<int>() { 1 });
        result.Add(new List<int>() { 1, 1 });

     
        for (var i = result.Count - 1; i < numRows-1; i++)
        {
            var tempList = new List<int>() { 1 };
            for (var y = 0; y < result[i].Count - 1; y++)
            {
                tempList.Add(result[i][y] + result[i][y + 1]);
            }

            tempList.Add(1);
            result.Add(tempList);
        }

        return result;
    }
}