using ArraySorting.ArraySort;

namespace ArraySorting.Arrays;

public interface IArray<T>
{
    public int Count { get; }

    public void Add(T value);

    void Sort(ISortAlgorithm algorithm);
}