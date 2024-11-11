namespace ArraySorting.ArraySort;

public interface ISortAlgorithm
{
    /// <summary>
    /// Should return -1 if x < y
    /// Should return 0 if x = y
    /// Should return 1 if x > y
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    int Compare<T>(T x, T y) where T : Item;
}