namespace ArraySorting.ArraySort;

public class LastNameSortAlgorithm : ISortAlgorithm
{
    public int Compare<T>(T x, T y) where T : Item
    {
        int check = 0;
        check = IsGreater(x.LastName, y.LastName) ? 1 : 2;
        return check;
    }
    static bool IsGreater(string str1, string str2)
    {
        int minLength = Math.Min(str1.Length, str2.Length);
        for (int i = 0; i < minLength; i++)
        {
            if (str1[i] > str2[i]) return true;  // str1 is greater
            if (str1[i] < str2[i]) return false; // str2 is greater
        }
        return str1.Length > str2.Length;
    }
}