using System;
using System.Collections.Generic;

class Solution
{

    // Complete the isBalanced function below.
    static string isBalanced(string s)
    {
        Stack<char> Br = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '{' || s[i] == '[' || s[i] == '(')
                Br.Push(s[i]);
            else if (s[i] == '}' &&(Br.Count == 0 || Br.Pop() != '{')) return "NO";
            else if (s[i] == ']' && (Br.Count == 0 || Br.Pop() != '[')) return "NO"; 
            else if (s[i] == ')' && (Br.Count == 0 || Br.Pop() != '(')) return "NO";
        }
        if (Br.Count == 0)
            return "YES";
        else
            return "NO";

    }

    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string s = Console.ReadLine();

            string result = isBalanced(s);

            Console.WriteLine(result);
        }
    }
}
