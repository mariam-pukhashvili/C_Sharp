using System.Text;
using ArraySorting.ArraySort;
using Microsoft.VisualBasic;

namespace ArraySorting.Arrays;

public class MyArray<T> : IArray<T>
where T : Item
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
        Items.Add(value);

    }

    public void Sort(ISortAlgorithm algorithm)
    {
        T shed;
        for (int j = 0; j < Items.Count - 2; j++)
        {
            for (int i = 0; i < Items.Count - 1; i++)
            {
                int comp = algorithm.Compare<T>(Items[i], Items[i + 1]);
                if (comp == 1)
                {
                    shed = Items[i];
                    Items[i] = Items[i + 1];
                    Items[i + 1] = shed;
                }

            }
        }

    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder($"List contains {Count} Elements");
        Items.ForEach(x => builder.AppendLine(x.ToString()));

        return builder.ToString();
    }

}