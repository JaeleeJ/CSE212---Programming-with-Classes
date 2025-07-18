namespace teach_01;

public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}

        var l3 = new[] { 'A', 'A', 'A', 'A', 'A'};
        var l4 = new[] { 'B', 'B', 'B', 'B', 'B'};
        select = new[] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2};
        var charResult = ListSelector(l3, l4, select);
        Console.WriteLine("<char[]>{" + string.Join(", ", charResult) + "}"); // <char[]>{A, B, A, B, A, B, A, B, A, B}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        var selectorIntArray = new int[select.Length];
        var x = 0;
        var y = 0;
        for (int i = 0; i < select.Length; i++)
        {
            if (select[i] == 1)
            {
                selectorIntArray[i] = list1[x++];
            }
            else
            {
                selectorIntArray[i] = list2[y++];
            }
        }
        
        return selectorIntArray;
    }

    private static char[] ListSelector(char[] list1, char[] list2, int[] select)
    {
        var selectorCharArray = new char[select.Length];
        var x = 0;
        var y = 0;
        for (int i = 0; i < select.Length; i++)
        {
            if (select[i] == 1)
            {
                selectorCharArray[i] = list1[x++];
            }
            else
            {
                selectorCharArray[i] = list2[y++];
            }
        }
        
        return selectorCharArray;
    }
}