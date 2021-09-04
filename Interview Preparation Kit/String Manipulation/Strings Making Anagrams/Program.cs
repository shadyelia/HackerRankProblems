using System;
using System.Collections;
using System.IO;

class Result
{

    /*
     * Complete the 'makeAnagram' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING a
     *  2. STRING b
     */

    public static int makeAnagram(string a, string b)
    {
        int matched = 0;

        Hashtable data = new Hashtable();
        for (int i = 0; i < a.Length; i++)
        {
            if (data.ContainsKey(a[i]))
                data[a[i]] = (int)data[a[i]] + 1;
            else
                data.Add(a[i], 1);
        }
        for (int i = 0; i < b.Length; i++)
        {
            if (data.ContainsKey(b[i]))
            {
                var value = (int)data[b[i]];
                if (value > 0)
                {
                    data[b[i]] = (int)data[b[i]] - 1;
                    matched += 2;
                }
            }

        }

        return a.Length + b.Length - matched;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string a = Console.ReadLine();

        string b = Console.ReadLine();

        int res = Result.makeAnagram(a, b);

        Console.WriteLine(res);
    }
}
