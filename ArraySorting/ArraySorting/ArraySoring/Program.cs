using ArraySorting;
using ArraySorting.Arrays;
using ArraySorting.ArraySort;

IArray<Item> array = new MyArray<Item>(new List<Item> { new Item(1, "test", "testiashvili", 100) });

array.Add(new Item(2, "abg", "dev", 200));

ISortAlgorithm algorithm = new IdSortAlgorithm();

array.Sort(algorithm);

Console.WriteLine(array);

algorithm = new FirstNameSortAlgorithm();

array.Sort(algorithm);

Console.WriteLine(array);
