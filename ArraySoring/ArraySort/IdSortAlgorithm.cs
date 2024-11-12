namespace ArraySorting.ArraySort;

public class IdSortAlgorithm : ISortAlgorithm
{
    public int Compare<T>(T x, T y) where T : Item
    {
        if (x.Id > y.Id) return 1;
        else if (x.Id < y.Id) return -1;
        else return 0;
    }
}