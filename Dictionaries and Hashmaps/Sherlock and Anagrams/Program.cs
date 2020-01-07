using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Sherlock_and_Anagrams
{
    class Program
    {

        static int sherlockAndAnagrams(string s)
        {
            int result = 0;

            Hashtable subStrings = new Hashtable();
            for (int i = 1; i < s.Length; i++)
            {
                subStrings.Clear();
                for (int j = 0; j < s.Length - (i - 1); j++)
                {
                    var subStringSort = String.Concat(s.Substring(j, i).OrderBy(c => c)); 
                    subStrings.Add(j, subStringSort);
                }


                for (int b = 0; b < subStrings.Count - 1; b++)
                {
                    for (int k = b + 1; k < subStrings.Count; k++)
                    {
                        if (subStrings[b].ToString() == subStrings[k].ToString())
                            result += 1;
                    }
                }

            }

            return result;
        }

        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = sherlockAndAnagrams(s);

                Console.WriteLine(result);
            }

        }
    }
}
