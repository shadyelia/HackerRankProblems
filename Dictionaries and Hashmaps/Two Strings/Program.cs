using System;
using System.Collections;

namespace Two_Strings
{
    class Program
    {
        static string twoStrings(string s1, string s2)
        {
            Hashtable firstStringHashTable = new Hashtable();
            int key = 1;

            foreach (var chat in s1)
            {
                if (firstStringHashTable[chat] == null)
                {
                    firstStringHashTable.Add(chat, key);
                }
            }

            foreach(char chat in s2)
            {
                var isExist = firstStringHashTable[chat];
                if (isExist != null)
                {
                    return "YES";
                }
            }

            return "NO";
        }

        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s1 = Console.ReadLine();

                string s2 = Console.ReadLine();

                string result = twoStrings(s1, s2);

                Console.WriteLine(result);
            }
        }
    }
}
