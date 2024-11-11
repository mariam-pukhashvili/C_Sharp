using System.Text;
using ArraySorting.ArraySort;

namespace ArraySorting.Arrays;

public class MyArray<T> : IArray<T>
{
    public MyArray(List<T> list)
    {
        Items = list;
    }

    public List<T> Items { get; private set; }

    public int Count
    {
        get { return this.Items.Count; }
    }

    public void Add(T value)
    {
        throw new NotImplementedException();
    }

    public void Sort(ISortAlgorithm algorithm)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder($"List contains {Count} Elements");
        Items.ForEach(x => builder.AppendLine(x.ToString()));

        return builder.ToString();
    }

}