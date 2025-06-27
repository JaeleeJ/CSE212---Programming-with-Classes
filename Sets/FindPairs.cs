namespace prove_05;

/**
 * CSE212 
 * (c) BYU-Idaho
 * 05-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 */
public static class FindPairs {
    public static void Run() {
        DisplayPairs(new[] { "am", "at", "ma", "if", "fi" }); // ma & am, fi & if
        Console.WriteLine("=============");
        DisplayPairs(new[] { "ab", "bc", "cd", "de", "ba" }); // ba & ab
        Console.WriteLine("=============");
        DisplayPairs(new[] { "ab", "ba", "ac", "ad", "da", "ca" }); // ba & ab, da & ad, ca & ac
        Console.WriteLine("=============");
        DisplayPairs(new[] { "ab", "ac" }); // None
        Console.WriteLine("=============");
        DisplayPairs(new[] { "ab", "aa", "ba" }); // ba & ab
        Console.WriteLine("=============");
        DisplayPairs(new[] { "23", "84", "49", "13", "32", "46", "91", "99", "94", "31", "57", "14" });
        // 32 & 23, 94 & 49, 31 & 13
    }

    /// <summary>
    /// The words parameter contains a list of two character 
    /// words (lower case, no duplicates). Using sets, find an O(n) 
    /// solution for displaying all symmetric pairs of words.  
    ///
    /// For example, if words was: [am, at, ma, if, fi], we would display:
    /// am & ma
    /// if & fi
    /// The order of the display above does not matter.  'at' would not 
    /// be displayed because 'ta' is not in the list of words.
    ///
    /// As a special case, if the letters are the same (example: 'aa') then
    /// it would not match anything else (remember no the assumption above
    /// that there were no duplicates) and therefore should not be displayed.
    /// </summary>
    /// <param name="words">An array of 2-character words (lowercase, no duplicates)</param>
    private static void DisplayPairs(string[] words) {
        // TODO Problem 2
        List<string> list = new List<string>();
        int count = 0;
       
        foreach (var word in words)
        {
            char first = word[0];
            char last = word[1];
            
            // compare 2 words
            foreach (var t in words)
            {
                // if the words are not the same and the 2 letters are not the same
                if ((t != word) && (first != last))
                {
                    // if the second words contains both the letters of the first word
                    if (t.Contains(first) && t.Contains(last))
                    {
                        // if not yet found, print the pair
                        if (!list.Contains(word) || !list.Contains(t))
                        {
                            list.Add(word);
                            list.Add(t);
                            Console.WriteLine($"{word} & {t}");
                            count++;
                        }

                    }
                    
                }
                
            }
        }

        if (count == 0)
        {
            Console.WriteLine("None");
        }
        
    }
}