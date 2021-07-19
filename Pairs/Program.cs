using System;
using System.Collections.Generic;
using System.Linq;

class Result
{

    /*
     * Complete the 'pairs' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY arr
     */

    /*
     * convert the array to hash
     * then search for item + k (or item - k) 
     * if you found it 
     * result +1
     * 
     */

    public static int pairs(int k, List<int> arr)
    {
        var set = new HashSet<int>(arr);
        int result = 0;
        foreach(int item in arr)
        {
            if (set.Contains(item + k))
                result++;
        }
        return result;
    }


    public static int pairs2(int k, List<int> arr)
    {
        int result = 0;
        int currentValue = 0;
        for (int i = 0; i < arr.Count - 1; i++)
        {
            currentValue = arr[i];
            for (int j = i+1; j < arr.Count; j++)
            {
                if (currentValue + k == arr[j] || currentValue - k == arr[j])
                {
                    result++;
                    break;
                }
            }
        }
        return result;
    }

}

class Solution
{
    public static void Main()
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.pairs(k, arr);

        Console.WriteLine(result);

    }
}
