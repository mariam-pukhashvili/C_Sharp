using ArraySorting;
using ArraySorting.Arrays;
using ArraySorting.ArraySort;

IArray<Item> array = new MyArray<Item>(new List<Item> { new Item(1, "Ana", "testiashvili", 100) });


array.Add(new Item(2, "sofio", "shanidze", 100));
array.Add(new Item(4, "mari", "sikharulidze", 230));
array.Add(new Item(52, "magda", "chokuri", 260));


ISortAlgorithm algorithm = new IdSortAlgorithm();
ISortAlgorithm fNames = new IdSortAlgorithm();
//array.Sort(algorithm);

//Console.WriteLine(array);

//algorithm = new SalarySortAlgorithm();

fNames = new FirstNameSortAlgorithm();
//
array.Sort(fNames);

Console.WriteLine(array);
