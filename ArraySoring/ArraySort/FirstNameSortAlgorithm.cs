using System.Globalization;

namespace ArraySorting.ArraySort;

public class FirstNameSortAlgorithm : ISortAlgorithm
{
    public int Compare<T>(T x, T y) where T : Item
    {
        for (int j = 0; j < x.FirstName.Length - 2; j++)
        {
            for (int i = 0; i < x.FirstName.Length - 1; i++)
            {

                Console.WriteLine();
                Console.WriteLine(char.ToLower(x.FirstName[i]));

                if (char.ToLower(x.FirstName[i]) < char.ToLower(y.FirstName[i]))
                {
                  
                  
                }
                if (char.ToLower(x.FirstName[i]) == char.ToLower(y.FirstName[i])) return 0;

                else return 1;

            }

        }

        return 0;


        // for (int i = 0; i < x.Length - 1; i++)
        // {
        //     for (int j = 0; j < y.Count - 1; i++)
        //     {



        //     }
        // }
    }
}