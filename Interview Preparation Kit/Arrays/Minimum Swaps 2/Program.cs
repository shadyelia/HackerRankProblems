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

class Solution
{

    // Complete the minimumSwaps function below.
    static int minimumSwaps(int[] arr)
    {
        int result = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] != i + 1)
            {
                Swap(arr, arr[i] - 1, i);
                i--;
                result++;
            }
        }
        return result;
    }

    private static void Swap(int[] arr, int left, int right)
    {
        var buffer = arr[left];
        arr[left] = arr[right];
        arr[right] = buffer;
    }


    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int res = minimumSwaps(arr);

        Console.WriteLine(res);
    }
}
