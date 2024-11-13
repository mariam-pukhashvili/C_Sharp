using ArraySorting;
using ArraySorting.Arrays;
using ArraySorting.ArraySort;

IArray<Item> array = new MyArray<Item>(new List<Item> { new Item(1, "test", "testiashvili", 100) });
try
{
    array.Add(new Item(2, "abg", "dev", 200));
}
catch (NotImplementedException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
//vitripache finally-s gamoyenebac vici metqi, tore aucilebeli araa:d
finally
{
    Console.WriteLine("Finally Block");
}
ISortAlgorithm algorithm = new IdSortAlgorithm();
array.Sort(algorithm);
try
{
    array.Sort(algorithm);
}
catch (NotImplementedException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
//vitripache finally-s gamoyenebac vici metqi, tore aucilebeli araa:d
finally
{
    Console.WriteLine("Finally Block");
}
Console.WriteLine(array);
algorithm = new FirstNameSortAlgorithm();
//array.Sort(algorithm);
Console.WriteLine(array);
