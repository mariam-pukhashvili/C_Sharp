/********** Task 1 *******/
//find Min number
int[] nums = { 15, 56, 44, 12, 90, 22, 32, 67, 81, 20 };
int min = nums[0], max = nums[0], avg = nums[0], sum = 0;
for (int i = 0; i < nums.Length; i++)
{
    //find Min number 
    min = min < nums[i] ? min : nums[i];
    //find Max number 
    max = max > nums[i] ? max : nums[i];
    // find Sum
    sum += nums[i];
}
Console.WriteLine($"Min value of nums array is {min}");
Console.WriteLine($"Max value of nums array is {max}");
if (nums.Length != 0) Console.WriteLine($"Max value of nums array is {sum / nums.Length}");

/********** Task 2 *******/

int[,] multiarray = {
            { 11, 41, 23, 44, 21, 32,68 },
            { 32, 5, 62 , 23,19,33, 1},
            { 15, 10, 3 , 91, 21,34, 56},
            { 55,71,73,22,12,42,99}
        };

int min_m = multiarray[0, 0];
int max_m = multiarray[0, 0];
int sum_m = 0;

for (int i = 0; i < multiarray.GetLength(0); i++)
{
    for (int j = 0; j < multiarray.GetLength(1); j++)
    {
        if (multiarray[i, j] < min_m)
        {
            min_m = multiarray[i, j];
        }
        if (multiarray[i, j] > max_m)
        {
            max_m = multiarray[i, j];
        }
        sum_m += multiarray[i, j];
    }
}

Console.WriteLine($"The minimum element in the multi array is: {min_m}");
Console.WriteLine($"The maximum element in the multi array is: {max_m}");
Console.WriteLine($"The average element in the multi array is: {sum_m / multiarray.Length}");
/********** Task 3 *******/

int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[2] { 3, 5 }; // (3,2)
jaggedArray[1] = new int[5] { 12, 3, 5, 66, 12 }; // (3,5)
jaggedArray[2] = new int[3] { 21, 5, 88 }; // (3,3)


for (int i = 0; i < jaggedArray.Length; i++)
{
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.WriteLine($"jaggedArray element: {jaggedArray[i][j]}");
    }
}


/********** Task 3 *******/

int[,,] threeArray = new int[3, 4, 5]

        {
            {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15 },
                { 16, 17, 18, 19, 20 }
            },
            {
                { 21, 22, 23, 24, 25 },
                { 26, 27, 28, 29, 30 },
                { 31, 32, 33, 34, 35 },
                { 36, 37, 38, 39, 40 }
            },
            {
                { 41, 42, 43, 44, 45 },
                { 46, 47, 48, 49, 50 },
                { 51, 52, 53, 54, 55 },
                { 56, 57, 58, 59, 60 }
            }
        };

int[] oneArray = new int[threeArray.Length];
int index = 0;
for (int i = 0; i < threeArray.GetLength(0); i++)
{

    for (int j = 0; j < threeArray.GetLength(1); j++)
    {
        for (int y = 0; y < threeArray.GetLength(2); y++)
        {

            oneArray[index++] = threeArray[i, j, y];

        }
    }

}
Array.Sort(oneArray);

for (int i = 0; i < oneArray.Length; i++)
{
    Console.WriteLine($"sortedarray {oneArray[i]}");
}
