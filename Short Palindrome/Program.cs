using System;

class Result
{

    /*
     * Complete the 'shortPalindrome' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    /*
     * 
     * 
     * 
     */

    public static int shortPalindrome(string s)
    {
        int result = 0;
        int index = 0;

        for (int i = 0; i < s.Length - 3; i++)
        {
            for(int j = i + 2; j < s.Length; j++)
            {
                
            }
        }
        return result % (int)(Math.Pow(10, 9) + 7);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        int result = Result.shortPalindrome(s);

        Console.WriteLine(result);
    }
}
