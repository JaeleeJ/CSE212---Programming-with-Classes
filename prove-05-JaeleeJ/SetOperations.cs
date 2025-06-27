namespace prove_05;

/**
 * CSE212 
 * (c) BYU-Idaho
 * 05-Prove - Problem 1
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 */
public static class SetOperations {
    public static void Run() {
        var s1 = new HashSet<int>(new[] { 1, 2, 3, 4, 5 });
        var s2 = new HashSet<int>(new[] { 4, 5, 6, 7, 8 });
        Console.WriteLine(Intersection(s1, s2).AsString()); // Should show {4, 5}
        Console.WriteLine(Union(s1, s2).AsString()); // Should show {1, 2, 3, 4, 5, 6, 7, 8}

        s1 = new HashSet<int>(new[] { 1, 2, 3, 4, 5 });
        s2 = new HashSet<int>(new[] { 6, 7, 8, 9, 10 });
        Console.WriteLine(Intersection(s1, s2).AsString()); // Should show an empty set
        Console.WriteLine(Union(s1, s2).AsString()); // Should show {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
    }

    /// <summary>
    /// Performs a set intersection operation.
    /// </summary>
    /// <param name="set1">A set of integers</param>
    /// <param name="set2">A set of integers</param>
    private static HashSet<int> Intersection(HashSet<int> set1, HashSet<int> set2) {
        var result = new HashSet<int>();
        // TODO Problem 1.1
        foreach (var x in set1)
        {
            if (set2.Contains(x))
            {
                // add elements to result if they are in both sets
                result.Add(x);
            }
        }
        
        return result;
    }

    /// <summary>
    /// Performs a set union operation.
    /// </summary>
    /// <param name="set1">A set of integers</param>
    /// <param name="set2">A set of integers</param>
    private static HashSet<int> Union(HashSet<int> set1, HashSet<int> set2) {
        var result = new HashSet<int>();
        // TODO Problem 1.2
        //add all elements from the first set to results
        foreach (var x in set1)
        {
            result.Add(x);
        }
        
        foreach (var x in set2)
        {
            // add elements to result if they were not yet added from set1
            if (!result.Contains(x))
            {
                result.Add(x);
            }
        }
        return result;
    }
}