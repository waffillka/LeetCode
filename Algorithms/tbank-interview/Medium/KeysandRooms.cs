namespace Algorithms.tbank_interview.Medium;

//https://leetcode.com/problems/keys-and-rooms/
public static class KeysandRooms
{
    //работает при условии если мы идем по порядку
    private static bool CanVisitAllRooms(IList<IList<int>> rooms)
    {
        var keys = new HashSet<int>(rooms[0]);

        for (var i = 1; i < rooms.Count; i++)
        {
            if (!keys.Contains(i))
            {
                return false;
            }

            foreach (var item in rooms[i])
            {
                keys.Add(item);
            }
        }

        return true;
    } 
    
    private static bool CanVisitAllRooms_2gen(IList<IList<int>> rooms)
    {
        var visited = new bool[rooms.Count];
        visited[0] = true;
        
        var keys = new Stack<int>(rooms[0]);
        while (keys.Count > 0)
        {
            var current = keys.Pop();
            if (!visited[current])
            {
                visited[current] = true;
                foreach (var item in rooms[current])
                {
                    keys.Push(item);
                }
                
            }
        }

        foreach (var item in visited)
        {
            if (!item)
            {
                return false;
            }
        }

        return true;
    }

    public static void Test()
    {
        var result = CanVisitAllRooms_2gen(new List<IList<int>>()
        {
            new List<int>() { 1 },
            new List<int>() { 2 },
            new List<int>() { 3 },
            new List<int>() { }
        });
        Console.WriteLine(result);

        //rooms = [[1,3],[3,0,1],[2],[0]]
        result = CanVisitAllRooms_2gen(new List<IList<int>>(new List<IList<int>>()
        {
            new List<int>() { 1, 3 },
            new List<int>() { 3, 0, 1 },
            new List<int>() { 2 },
            new List<int>() { 0 }
        }));
        Console.WriteLine(result); 
        
         result = CanVisitAllRooms_2gen(new List<IList<int>>(new List<IList<int>>()
        {
            new List<int>() { 2 },
            new List<int>() { },
            new List<int>() { 1},
        }));
        Console.WriteLine(result);
    }
}