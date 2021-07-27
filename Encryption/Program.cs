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
     * Complete the 'encryption' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string encryption(string s)
    {
        StringBuilder result = new StringBuilder();
        s= Regex.Replace(s, @"\s+", "");
        int len = s.Length;
        
        int column = (int)Math.Ceiling(Math.Sqrt(len));
        
        for(int i = 0; i < column; i++)
        {
            for(int j = i; j < len; j+=column)
            {
                result.Append(s[j]);
            }
            if (i != column - 1) result.Append(' ');
        }

        return result.ToString();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        string result = Result.encryption(s);

        Console.WriteLine(result);
    }
}
