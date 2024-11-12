using ArraySorting;
using ArraySorting.Arrays;
using ArraySorting.ArraySort;

IArray<Item> array = new MyArray<Item>(new List<Item> { new Item(1, "test", "testiashvili", 100) });


array.Add(new Item(2, "abg", "dev", 100));
array.Add(new Item(31, "abg", "dev", 400));
array.Add(new Item(4, "abg", "dev", 230));
array.Add(new Item(52, "abg", "dev", 260));


ISortAlgorithm algorithm = new IdSortAlgorithm();

array.Sort(algorithm);

Console.WriteLine(array);

algorithm = new SalarySortAlgorithm();

array.Sort(algorithm);

Console.WriteLine(array);
