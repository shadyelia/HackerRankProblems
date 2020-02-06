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

    public static int pickingNumbers(List<int> a)
    {
        a.Sort();
        int lowValue = a[0];
        int length = 1 ,maxLength = 0;

        for(int i=1;i<a.Count;i++){
            if(lowValue == a[i] || lowValue+1 == a[i]) length++;
            else {
                if(maxLength < length) maxLength = length;

                length = 1;
                lowValue = a[i];
            }
        }
        if(maxLength < length) maxLength = length;
        return maxLength;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        Console.WriteLine(result);

    }
}
