namespace ArraySorting.ArraySort;

public class SalarySortAlgorithm : ISortAlgorithm
{
    public int Compare<T>(T x, T y) where T : Item
    {
        if (x.Salary > y.Salary) return 1;
        else if (x.Salary < y.Salary) return -1;
        else return 0;
    }
}