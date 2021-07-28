using System;
using System.Collections.Generic;
using System.Linq;

class Result
{

    /*
     * Complete the 'larrysArray' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER_ARRAY A as parameter.
     */

    public static string larrysArray(List<int> A)
    {
        int len = A.Count;
        for (int i = 0; i < len - 2; i++)
        {
            if (IsPairSorted(A,i))
                continue;
            else
            {
                SwapPair(A, i);
                if (!IsPairSorted(A, i)) SwapPair(A, i);
                i = i-3 > -1 ? i-3 : -1 ;
            }
        }
        return A[len - 1] > A[len - 2] ? "YES" : "NO";
    }


    private static bool IsPairSorted(List<int> A, int index)
    {
        return A[index] <= A[index+1] && A[index] <= A[index+2] ? true : false;
    }
    private static void SwapPair(List<int> A,int index)
    {
        int firstNumber = A[index];
        A[index] = A[index+1];
        A[index+1] = A[index+2];
        A[index+2] = firstNumber;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> A = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(ATemp => Convert.ToInt32(ATemp)).ToList();

            string result = Result.larrysArray(A);

            Console.WriteLine(result);
        }

    }
}
