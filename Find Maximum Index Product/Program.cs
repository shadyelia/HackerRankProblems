using System;
using System.Linq;

class Solution
{

    // Complete the solve function below.
    static ulong solve(uint arrCount, ulong[] arr)
    {
        ulong maxIndexProduct = 0, maxValueUntilNow = arr[0], maxNumberInArray = arr.Max();

        for (uint i = 1; i < arrCount - 1; i++)
        {
            uint leftI = 0;
            uint rightI = 0;
            ulong currentValue = arr[i];


            if (currentValue == maxNumberInArray||maxValueUntilNow <= currentValue)
            {
                maxValueUntilNow = currentValue;
                continue;
            }

            //right
            for (uint j = i + 1; j < arrCount; j++)
            {
                if (arr[j] > currentValue) { rightI = j + 1; break; }
                if (j == arrCount - 1 )
                {
                    maxNumberInArray = arr[j];
                }
            }
            if (rightI != 0)
            {
                //left
                for (uint j = i - 1; j >= 0; j--)
                {
                    if (arr[j] > currentValue) { leftI = j + 1; break; }
                }
            }

            if ((leftI * rightI) > maxIndexProduct) maxIndexProduct = (leftI * rightI);

        }

        return maxIndexProduct;
    }

    static void Main(string[] args)
    {

        uint arrCount = Convert.ToUInt32(Console.ReadLine());

        ulong[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToUInt64(arrTemp));

        ulong result = solve(arrCount, arr);

        Console.WriteLine(result);
    }
}
