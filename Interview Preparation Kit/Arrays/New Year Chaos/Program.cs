using System;
using System.Collections.Generic;
using System.Linq;

class Result
{

    /*
     * Complete the 'minimumBribes' function below.
     *
     * The function accepts INTEGER_ARRAY q as parameter.
     */

    public static void minimumBribes(List<int> q)
    {
        int result = 0;
        for (int i = q.Count - 1; i >= 0; i--)
        {
            int currentValue = q[i];
            if (currentValue > i + 1)
            {
                if (currentValue - 1 > i + 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
                else if (currentValue - 1 == i + 2)
                {
                    Swap(q, i + 1, i);
                    Swap(q, i + 2, i + 1);
                    result += 2;
                }
                else
                {
                    Swap(q, i + 1, i);
                    result += 1;
                }
                i++;
            }
        }
        Console.WriteLine(result);
    }
    private static void Swap(List<int> arr, int left, int right)
    {
        var buffer = arr[left];
        arr[left] = arr[right];
        arr[right] = buffer;
    }

}

class Solution
{
    public static void Main()
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> q = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();

            Result.minimumBribes(q);
        }
    }
}
