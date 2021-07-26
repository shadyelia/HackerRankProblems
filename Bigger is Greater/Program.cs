using System;
using System.Linq;
using System.Text;

class Result
{
    /*****************************
     * super useful link for the algorithm
     * https://www.nayuki.io/page/next-lexicographical-permutation-algorithm
     *************************/

    /*
     * Complete the 'biggerIsGreater' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING w as parameter.
     */

    public static string biggerIsGreater(string w)
    {
        string result = "no answer";
        int len = w.Length - 1;
        if (len <= 0) return result;
        for (int i = len; i > 0; i--)
        {   
            if (w[i] > w[i - 1])
            {
                char pivot = w[i - 1];
                int pivotIndex = i - 1;
                StringBuilder beforePivot = new StringBuilder(w.Substring(0, pivotIndex));
                StringBuilder afterPivot = new StringBuilder(w.Substring(pivotIndex + 1));

                for (int j = i; j <= len; j++)
                {
                    if (w[j] <= pivot)
                    {
                        beforePivot.Append(w[j - 1]);
                        afterPivot[j - i - 1] = pivot;
                        break;
                    }
                    else if (j == len)
                    {
                        beforePivot.Append(w[j]);
                        afterPivot[j - i] = pivot;
                        break;
                    }
                }
                beforePivot.Append(String.Concat(afterPivot.ToString().OrderBy(c => c)));
                result = beforePivot.ToString();
                break;
            }


        }
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int T = Convert.ToInt32(Console.ReadLine().Trim());

        for (int TItr = 0; TItr < T; TItr++)
        {
            string w = Console.ReadLine();

            string result = Result.biggerIsGreater(w);

            Console.WriteLine(result);
        }

    }
}
