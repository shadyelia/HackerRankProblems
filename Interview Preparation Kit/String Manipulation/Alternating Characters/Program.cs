using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'alternatingCharacters' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int alternatingCharacters(string s)
    {
        int result = 0;
        for(int i = 0; i < s.Length-1; i++)
        {
            if (s[i] == s[i + 1]) result += 1;
        }

        return result;
    }

}

class Solution
{
    public static void Main()
    {

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = Result.alternatingCharacters(s);

            Console.WriteLine(result);
        }
    }
}
