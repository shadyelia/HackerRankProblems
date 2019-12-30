using System;
using System.Linq;

namespace Sparse_Arrays
{
    class Program
    {
        static int[] matchingStrings(string[] strings, string[] queries) {
            int[] res = new int[queries.Count()];

            for(int i=0;i<queries.Count();i++){
                res[i] = strings.Count(stringInput => stringInput == queries[i]);
            }

            return res;
        }

        static void Main(string[] args)
        {
            int stringsCount = Convert.ToInt32(Console.ReadLine());

            string[] strings = new string [stringsCount];

            for (int i = 0; i < stringsCount; i++) {
                string stringsItem = Console.ReadLine();
                strings[i] = stringsItem;
            }

            int queriesCount = Convert.ToInt32(Console.ReadLine());

            string[] queries = new string [queriesCount];

            for (int i = 0; i < queriesCount; i++) {
                string queriesItem = Console.ReadLine();
                queries[i] = queriesItem;
            }

            int[] res = matchingStrings(strings, queries);

            Console.WriteLine(string.Join("\n", res));
        }
    }
}
