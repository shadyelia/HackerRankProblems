using System;
using System.Numerics;

class Result
{

    /*
     * Complete the 'extraLongFactorials' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void extraLongFactorials(int n)
    {
        Console.WriteLine(getFactory(n));
    }

    public static BigInteger getFactory(BigInteger n)
    {
        if (n == 1) return 1;
        return n * getFactory(n - 1);
    }

}

class Solution
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.extraLongFactorials(n);
    }
}
